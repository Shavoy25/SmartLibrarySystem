using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.IO;

namespace SmartLibraryAdmin
{
    public static class DatabaseHelper
    {
        private static string GetDatabasePath()
        {
            DirectoryInfo? directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            while (directory != null && directory.Name != "SmartLibrarySystem")
            {
                directory = directory.Parent;
            }

            if (directory == null)
            {
                throw new Exception("SmartLibrarySystem folder was not found. Make sure SmartLibraryAdmin is inside SmartLibrarySystem.");
            }

            string databaseFolder = Path.Combine(directory.FullName, "Database");

            if (!Directory.Exists(databaseFolder))
            {
                Directory.CreateDirectory(databaseFolder);
            }

            return Path.Combine(databaseFolder, "smart_library.db");
        }

        private static string GetConnectionString()
        {
            return "Data Source=" + GetDatabasePath();
        }

        public static void InitializeDatabase()
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    PRAGMA foreign_keys = ON;

                    CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Members (
                        MemberID INTEGER PRIMARY KEY AUTOINCREMENT,
                        MemberCode TEXT NOT NULL UNIQUE,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        Email TEXT,
                        Phone TEXT,
                        UserType TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Books (
                        BookID INTEGER PRIMARY KEY AUTOINCREMENT,
                        BookCode TEXT NOT NULL UNIQUE,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        Category TEXT,
                        ISBN TEXT,
                        Quantity INTEGER NOT NULL DEFAULT 0,
                        AvailableCopies INTEGER NOT NULL DEFAULT 0,
                        Status TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS BorrowRecords (
                        RecordID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RecordCode TEXT NOT NULL UNIQUE,
                        MemberID INTEGER NOT NULL,
                        BookID INTEGER NOT NULL,
                        TransactionType TEXT NOT NULL,
                        BorrowDate TEXT,
                        DueDate TEXT,
                        ReturnDate TEXT,
                        Status TEXT NOT NULL,
                        FOREIGN KEY (MemberID) REFERENCES Members(MemberID),
                        FOREIGN KEY (BookID) REFERENCES Books(BookID)
                    );

                    INSERT OR IGNORE INTO Users (Username, Password, Role)
                    VALUES ('librarian', 'admin123', 'Librarian');
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool ValidateLogin(string username, string password)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

#pragma warning disable CS8605 // Unboxing a possibly null value.
                    long count = (long)command.ExecuteScalar();
#pragma warning restore CS8605 // Unboxing a possibly null value.

                    return count > 0;
                }
            }
        }

        public static void AddBook(string bookCode, string title, string author, string category, string isbn, int quantity, string status)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    INSERT INTO Books
                    (BookCode, Title, Author, Category, ISBN, Quantity, AvailableCopies, Status)
                    VALUES
                    (@BookCode, @Title, @Author, @Category, @ISBN, @Quantity, @AvailableCopies, @Status);
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BookCode", bookCode);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@AvailableCopies", quantity);
                    command.Parameters.AddWithValue("@Status", status);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateBook(int bookID, string bookCode, string title, string author, string category, string isbn, int quantity, int availableCopies, string status)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    UPDATE Books
                    SET BookCode = @BookCode,
                        Title = @Title,
                        Author = @Author,
                        Category = @Category,
                        ISBN = @ISBN,
                        Quantity = @Quantity,
                        AvailableCopies = @AvailableCopies,
                        Status = @Status
                    WHERE BookID = @BookID;
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.Parameters.AddWithValue("@BookCode", bookCode);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@AvailableCopies", availableCopies);
                    command.Parameters.AddWithValue("@Status", status);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteBook(int bookID)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = "DELETE FROM Books WHERE BookID = @BookID";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetBooks()
        {
            DataTable table = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    SELECT 
                        BookID,
                        BookCode,
                        Title,
                        Author,
                        Category,
                        ISBN,
                        Quantity,
                        AvailableCopies,
                        Status
                    FROM Books;
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }

        public static void AddMember(string memberCode, string firstName, string lastName, string email, string phone, string userType)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    INSERT INTO Members
                    (MemberCode, FirstName, LastName, Email, Phone, UserType)
                    VALUES
                    (@MemberCode, @FirstName, @LastName, @Email, @Phone, @UserType);
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberCode", memberCode);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@UserType", userType);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateMember(int memberID, string memberCode, string firstName, string lastName, string email, string phone, string userType)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    UPDATE Members
                    SET MemberCode = @MemberCode,
                        FirstName = @FirstName,
                        LastName = @LastName,
                        Email = @Email,
                        Phone = @Phone,
                        UserType = @UserType
                    WHERE MemberID = @MemberID;
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.Parameters.AddWithValue("@MemberCode", memberCode);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@UserType", userType);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteMember(int memberID)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = "DELETE FROM Members WHERE MemberID = @MemberID";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetMembers()
        {
            DataTable table = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    SELECT 
                        MemberID,
                        MemberCode,
                        FirstName,
                        LastName,
                        Email,
                        Phone,
                        UserType
                    FROM Members;
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }

        public static void AddBorrowRecord(
            string recordCode,
            int memberID,
            int bookID,
            string transactionType,
            string borrowDate,
            string dueDate,
            string returnDate,
            string status)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    INSERT INTO BorrowRecords
                    (RecordCode, MemberID, BookID, TransactionType, BorrowDate, DueDate, ReturnDate, Status)
                    VALUES
                    (@RecordCode, @MemberID, @BookID, @TransactionType, @BorrowDate, @DueDate, @ReturnDate, @Status);
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@RecordCode", recordCode);
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.Parameters.AddWithValue("@TransactionType", transactionType);
                    command.Parameters.AddWithValue("@BorrowDate", borrowDate);
                    command.Parameters.AddWithValue("@DueDate", dueDate);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                    command.Parameters.AddWithValue("@Status", status);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetBorrowRecords()
        {
            DataTable table = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = @"
                    SELECT 
                        BorrowRecords.RecordID,
                        BorrowRecords.RecordCode,
                        Members.MemberCode,
                        Members.FirstName || ' ' || Members.LastName AS MemberName,
                        Books.BookCode,
                        Books.Title AS BookTitle,
                        BorrowRecords.TransactionType,
                        BorrowRecords.BorrowDate,
                        BorrowRecords.DueDate,
                        BorrowRecords.ReturnDate,
                        BorrowRecords.Status
                    FROM BorrowRecords
                    INNER JOIN Members ON BorrowRecords.MemberID = Members.MemberID
                    INNER JOIN Books ON BorrowRecords.BookID = Books.BookID;
                ";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            return table;
        }

        public static DataTable GetReports()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ReportName");
            table.Columns.Add("Total");

            using (SqliteConnection connection = new SqliteConnection(GetConnectionString()))
            {
                connection.Open();

                table.Rows.Add("Total Books", ExecuteCount(connection, "SELECT COUNT(*) FROM Books"));
                table.Rows.Add("Available Books", ExecuteCount(connection, "SELECT COUNT(*) FROM Books WHERE Status = 'Available'"));
                table.Rows.Add("Registered Members", ExecuteCount(connection, "SELECT COUNT(*) FROM Members"));
                table.Rows.Add("Borrow Records", ExecuteCount(connection, "SELECT COUNT(*) FROM BorrowRecords"));
            }

            return table;
        }

        private static long ExecuteCount(SqliteConnection connection, string sql)
        {
            using (SqliteCommand command = new SqliteCommand(sql, connection))
            {
#pragma warning disable CS8605 // Unboxing a possibly null value.
                return (long)command.ExecuteScalar();
#pragma warning restore CS8605 // Unboxing a possibly null value.
            }
        }
    }
}