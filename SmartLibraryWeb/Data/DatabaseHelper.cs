using Microsoft.Data.Sqlite;
using SmartLibraryWeb.Models;

namespace SmartLibraryWeb.Data
{
    public static class DatabaseHelper
    {
        private static string GetDatabasePath()
        {
            DirectoryInfo? directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            while (directory != null && directory.Name != "SmartLibrarySystem") directory = directory.Parent;
            string databaseFolder = directory == null
                ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database")
                : Path.Combine(directory.FullName, "Database");
            Directory.CreateDirectory(databaseFolder);
            return Path.Combine(databaseFolder, "smart_library.db");
        }
        private static string GetConnectionString() => "Data Source=" + GetDatabasePath();
        public static void InitializeDatabase()
        {
            using SqliteConnection connection = new SqliteConnection(GetConnectionString());
            connection.Open();
            string sql = @"
                PRAGMA foreign_keys = ON;
                CREATE TABLE IF NOT EXISTS Users (UserID INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT NOT NULL UNIQUE, Password TEXT NOT NULL, Role TEXT NOT NULL);
                CREATE TABLE IF NOT EXISTS Members (MemberID INTEGER PRIMARY KEY AUTOINCREMENT, MemberCode TEXT NOT NULL UNIQUE, FirstName TEXT NOT NULL, LastName TEXT NOT NULL, Email TEXT, Phone TEXT, UserType TEXT NOT NULL);
                CREATE TABLE IF NOT EXISTS Books (BookID INTEGER PRIMARY KEY AUTOINCREMENT, BookCode TEXT NOT NULL UNIQUE, Title TEXT NOT NULL, Author TEXT NOT NULL, Category TEXT, ISBN TEXT, Quantity INTEGER NOT NULL DEFAULT 0, AvailableCopies INTEGER NOT NULL DEFAULT 0, Status TEXT NOT NULL);
                CREATE TABLE IF NOT EXISTS BorrowRecords (RecordID INTEGER PRIMARY KEY AUTOINCREMENT, RecordCode TEXT NOT NULL UNIQUE, MemberID INTEGER NOT NULL, BookID INTEGER NOT NULL, TransactionType TEXT NOT NULL, BorrowDate TEXT, DueDate TEXT, ReturnDate TEXT, Status TEXT NOT NULL, FOREIGN KEY (MemberID) REFERENCES Members(MemberID), FOREIGN KEY (BookID) REFERENCES Books(BookID));
                INSERT OR IGNORE INTO Users (Username, Password, Role) VALUES ('librarian', 'admin123', 'Librarian');";
            using SqliteCommand command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        public static bool ValidateLogin(string username, string password)
        {
            using SqliteConnection connection = new SqliteConnection(GetConnectionString()); connection.Open();
            using SqliteCommand command = new SqliteCommand("SELECT COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password", connection);
            command.Parameters.AddWithValue("@Username", username); command.Parameters.AddWithValue("@Password", password);
            return (long)command.ExecuteScalar()! > 0;
        }
        public static List<Book> GetBooks()
        {
            List<Book> books = new(); using SqliteConnection connection = new(GetConnectionString()); connection.Open();
            using SqliteCommand command = new("SELECT BookID, BookCode, Title, Author, Category, ISBN, Quantity, AvailableCopies, Status FROM Books ORDER BY BookID DESC", connection);
            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read()) books.Add(new Book{BookID=reader.GetInt32(0),BookCode=reader.GetString(1),Title=reader.GetString(2),Author=reader.GetString(3),Category=reader.IsDBNull(4)?"":reader.GetString(4),ISBN=reader.IsDBNull(5)?"":reader.GetString(5),Quantity=reader.GetInt32(6),AvailableCopies=reader.GetInt32(7),Status=reader.GetString(8)});
            return books;
        }
        public static Book? GetBookById(int id)
        {
            using SqliteConnection connection = new(GetConnectionString()); connection.Open();
            using SqliteCommand command = new("SELECT BookID, BookCode, Title, Author, Category, ISBN, Quantity, AvailableCopies, Status FROM Books WHERE BookID=@BookID", connection);
            command.Parameters.AddWithValue("@BookID", id); using SqliteDataReader reader = command.ExecuteReader();
            if(!reader.Read()) return null;
            return new Book{BookID=reader.GetInt32(0),BookCode=reader.GetString(1),Title=reader.GetString(2),Author=reader.GetString(3),Category=reader.IsDBNull(4)?"":reader.GetString(4),ISBN=reader.IsDBNull(5)?"":reader.GetString(5),Quantity=reader.GetInt32(6),AvailableCopies=reader.GetInt32(7),Status=reader.GetString(8)};
        }
        public static void AddBook(Book book)
        {
            using SqliteConnection connection = new(GetConnectionString()); connection.Open();
            using SqliteCommand command = new("INSERT INTO Books (BookCode,Title,Author,Category,ISBN,Quantity,AvailableCopies,Status) VALUES (@BookCode,@Title,@Author,@Category,@ISBN,@Quantity,@AvailableCopies,@Status)", connection);
            command.Parameters.AddWithValue("@BookCode", book.BookCode); command.Parameters.AddWithValue("@Title", book.Title); command.Parameters.AddWithValue("@Author", book.Author); command.Parameters.AddWithValue("@Category", book.Category ?? ""); command.Parameters.AddWithValue("@ISBN", book.ISBN ?? ""); command.Parameters.AddWithValue("@Quantity", book.Quantity); command.Parameters.AddWithValue("@AvailableCopies", book.AvailableCopies == 0 ? book.Quantity : book.AvailableCopies); command.Parameters.AddWithValue("@Status", book.Status); command.ExecuteNonQuery();
        }
        public static void UpdateBook(Book book)
        {
            using SqliteConnection connection = new(GetConnectionString()); connection.Open();
            using SqliteCommand command = new("UPDATE Books SET BookCode=@BookCode, Title=@Title, Author=@Author, Category=@Category, ISBN=@ISBN, Quantity=@Quantity, AvailableCopies=@AvailableCopies, Status=@Status WHERE BookID=@BookID", connection);
            command.Parameters.AddWithValue("@BookID", book.BookID); command.Parameters.AddWithValue("@BookCode", book.BookCode); command.Parameters.AddWithValue("@Title", book.Title); command.Parameters.AddWithValue("@Author", book.Author); command.Parameters.AddWithValue("@Category", book.Category ?? ""); command.Parameters.AddWithValue("@ISBN", book.ISBN ?? ""); command.Parameters.AddWithValue("@Quantity", book.Quantity); command.Parameters.AddWithValue("@AvailableCopies", book.AvailableCopies); command.Parameters.AddWithValue("@Status", book.Status); command.ExecuteNonQuery();
        }
        public static void DeleteBook(int id)
        { using SqliteConnection connection = new(GetConnectionString()); connection.Open(); using SqliteCommand command = new("DELETE FROM Books WHERE BookID=@BookID", connection); command.Parameters.AddWithValue("@BookID", id); command.ExecuteNonQuery(); }
        public static void AddMember(Member member)
        {
            using SqliteConnection connection = new(GetConnectionString()); connection.Open();
            using SqliteCommand command = new("INSERT INTO Members (MemberCode,FirstName,LastName,Email,Phone,UserType) VALUES (@MemberCode,@FirstName,@LastName,@Email,@Phone,@UserType)", connection);
            command.Parameters.AddWithValue("@MemberCode", member.MemberCode); command.Parameters.AddWithValue("@FirstName", member.FirstName); command.Parameters.AddWithValue("@LastName", member.LastName); command.Parameters.AddWithValue("@Email", member.Email ?? ""); command.Parameters.AddWithValue("@Phone", member.Phone ?? ""); command.Parameters.AddWithValue("@UserType", member.UserType); command.ExecuteNonQuery();
        }
        public static void AddBorrowRecord(BorrowRecord record)
        {
            using SqliteConnection connection = new(GetConnectionString()); connection.Open();
            using SqliteCommand command = new("INSERT INTO BorrowRecords (RecordCode,MemberID,BookID,TransactionType,BorrowDate,DueDate,ReturnDate,Status) VALUES (@RecordCode,@MemberID,@BookID,@TransactionType,@BorrowDate,@DueDate,@ReturnDate,@Status)", connection);
            command.Parameters.AddWithValue("@RecordCode", record.RecordCode); command.Parameters.AddWithValue("@MemberID", record.MemberID); command.Parameters.AddWithValue("@BookID", record.BookID); command.Parameters.AddWithValue("@TransactionType", record.TransactionType); command.Parameters.AddWithValue("@BorrowDate", record.BorrowDate.ToString("yyyy-MM-dd")); command.Parameters.AddWithValue("@DueDate", record.DueDate.ToString("yyyy-MM-dd")); command.Parameters.AddWithValue("@ReturnDate", record.ReturnDate.HasValue ? record.ReturnDate.Value.ToString("yyyy-MM-dd") : ""); command.Parameters.AddWithValue("@Status", record.Status); command.ExecuteNonQuery();
        }
        public static List<BorrowRecord> GetBorrowRecords()
        {
            List<BorrowRecord> records = new(); using SqliteConnection connection = new(GetConnectionString()); connection.Open();
            string sql = @"SELECT BorrowRecords.RecordID, BorrowRecords.RecordCode, BorrowRecords.MemberID, BorrowRecords.BookID, Members.FirstName || ' ' || Members.LastName, Books.Title, BorrowRecords.TransactionType, BorrowRecords.BorrowDate, BorrowRecords.DueDate, BorrowRecords.ReturnDate, BorrowRecords.Status FROM BorrowRecords INNER JOIN Members ON BorrowRecords.MemberID=Members.MemberID INNER JOIN Books ON BorrowRecords.BookID=Books.BookID ORDER BY BorrowRecords.RecordID DESC";
            using SqliteCommand command = new(sql, connection); using SqliteDataReader reader = command.ExecuteReader();
            while(reader.Read()) records.Add(new BorrowRecord{RecordID=reader.GetInt32(0),RecordCode=reader.GetString(1),MemberID=reader.GetInt32(2),BookID=reader.GetInt32(3),MemberName=reader.GetString(4),BookTitle=reader.GetString(5),TransactionType=reader.GetString(6),BorrowDate=DateTime.Parse(reader.GetString(7)),DueDate=DateTime.Parse(reader.GetString(8)),ReturnDate=reader.IsDBNull(9)||reader.GetString(9)==""?null:DateTime.Parse(reader.GetString(9)),Status=reader.GetString(10)});
            return records;
        }
    }
}
