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