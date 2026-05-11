Copy this into a file named:

```text
README.md
```

Place it inside your main repository folder:

```text
SmartLibrarySystem/README.md
```

````markdown
# Smart Library Management System

## Project Overview

The Smart Library Management System is a digital solution designed to help libraries manage books, members, borrowing records, returns, and reports more efficiently. The system includes a web interface for library users and a Windows Forms desktop application for librarians/admin staff.

The project was created to reduce manual record keeping, improve book tracking, and provide faster access to library information.

---

## Project Components

This repository contains three main application components:

1. **SmartLibraryAdmin**  
   A Windows Forms desktop application used by the librarian/admin to manage the library system.

2. **SmartLibraryApi**  
   An ASP.NET Core Web API used to connect the website to the shared database.

3. **Website**  
   A front-end website where users can view the catalog, register, log in, and access borrowing services.

4. **Database**  
   A shared SQLite database used by both the Windows Forms application and the website through the API.

---

## Folder Structure

```text
SmartLibrarySystem
│
├── Database
│   ├── schema.sql
│   └── smart_library.db
│
├── SmartLibraryAdmin
│   ├── Program.cs
│   ├── DatabaseHelper.cs
│   ├── frmLogin.cs
│   ├── frmDashboard.cs
│   ├── frmManageBooks.cs
│   ├── frmManageMembers.cs
│   ├── frmBorrowReturn.cs
│   └── frmReports.cs
│
├── SmartLibraryApi
│   ├── Program.cs
│   └── SmartLibraryApi.csproj
│
└── Website
    ├── index.html
    ├── catalog.html
    ├── login.html
    ├── registration.html
    └── borrow-return.html
````

---

## Technologies Used

* C#
* Windows Forms
* ASP.NET Core Web API
* HTML
* CSS
* JavaScript
* SQLite
* Microsoft.Data.Sqlite
* .NET SDK

---

## Database Design

The system uses one shared SQLite database:

```text
Database/smart_library.db
```

The database contains the following tables:

### Users

Stores login details for librarians/admin users.

Fields include:

* UserID
* Username
* Password
* Role

### Members

Stores registered library members.

Fields include:

* MemberID
* MemberCode
* FirstName
* LastName
* Email
* Phone
* UserType

### Books

Stores books in the library catalog.

Fields include:

* BookID
* BookCode
* Title
* Author
* Category
* ISBN
* Quantity
* AvailableCopies
* Status

### BorrowRecords

Stores borrowing and return transactions.

Fields include:

* RecordID
* RecordCode
* MemberID
* BookID
* TransactionType
* BorrowDate
* DueDate
* ReturnDate
* Status

---

## Default Login

Use the following librarian login credentials:

```text
Username: librarian
Password: admin123
```

---

## How to Run the Windows Forms Application

1. Open a terminal.
2. Navigate to the Windows Forms project folder:

```powershell
cd SmartLibraryAdmin
```

3. Restore packages:

```powershell
dotnet restore
```

4. Run the application:

```powershell
dotnet run
```

5. Log in using:

```text
Username: librarian
Password: admin123
```

The Windows Forms application allows the librarian to:

* Log in
* Open the dashboard
* Manage books
* Manage members
* Process borrow/return records
* View reports

---

## How to Run the API

1. Open a second terminal.
2. Navigate to the API project folder:

```powershell
cd SmartLibraryApi
```

3. Restore packages:

```powershell
dotnet restore
```

4. Run the API:

```powershell
dotnet run
```

5. The terminal will show a URL similar to:

```text
http://localhost:5000
```

or

```text
http://localhost:5163
```

6. Test the API by opening this in a browser:

```text
http://localhost:5000/api/books
```

If the database is connected, it will return either an empty list or the books stored in the database.

---

## How to Run the Website

1. Open the `Website` folder.
2. Open `index.html` in a browser.
3. Make sure the API is running before using database-connected pages such as:

   * Book Catalog
   * Registration
   * Login

If the API uses a port other than `5000`, update the fetch URLs in the website JavaScript files.

Example:

```javascript
fetch("http://localhost:5000/api/books")
```

Change `5000` to the port shown in your API terminal.

---

## Main Website Pages

### Home Page

The home page introduces the Smart Library Management System and provides navigation to the main features.

### Book Catalog Page

Displays books from the shared database.

### Registration Page

Allows users to register as library members.

### Login Page

Allows users to log in before accessing protected features.

### Borrow/Return Page

Allows logged-in users to access borrowing and return options.

---

## Main Windows Forms Screens

### Login Form

Allows the librarian to sign in securely.

### Dashboard Form

Provides access to the main administration features.

### Manage Books Form

Allows the librarian to add, update, delete, and view books.

### Manage Members Form

Allows the librarian to add, update, delete, and view library members.

### Borrow/Return Form

Allows the librarian to save borrowing and return records.

### Reports Form

Displays summary reports such as total books, available books, registered members, and borrow records.

---

## Shared Database Functionality

Both applications use the same SQLite database.

The Windows Forms app connects directly to:

```text
Database/smart_library.db
```

The website connects to the database through:

```text
SmartLibraryApi
```

This means:

* Books added in the Windows Forms app can appear on the website catalog.
* Members registered through the website can be viewed in the Windows Forms app.
* Login details are stored in the database.
* Borrowing records can be saved and reported.

---

## API Endpoints

The API includes the following endpoints:

```text
GET /
```

Checks if the API is running.

```text
GET /api/books
```

Returns all books from the database.

```text
GET /api/members
```

Returns all registered members.

```text
POST /api/members
```

Registers a new member.

```text
POST /api/login
```

Checks login credentials.

---

## Important Notes

* The API must be running for the website to access the database.
* The Windows Forms app must be run from inside the project structure so it can find the `SmartLibrarySystem` folder.
* The database is automatically created if it does not already exist.
* The default librarian account is inserted automatically when the database is initialized.

---

## Project Purpose

The purpose of this project is to demonstrate a complete enterprise-style library management solution using:

* A desktop administration system
* A web user interface
* A shared database
* A backend API
* Basic CRUD operations
* Login functionality
* Book and member management

---

## Group Members

* Shavoy Brown – Group Leader / Project Coordinator
* Tashecca Mullings – Researcher
* Kyle Whitbly – Writer / Documentation Specialist
* Kayvian Johnson – System Designer
* Oneil Mullings – Presentation Coordinator

---

## Conclusion

The Smart Library Management System provides a digital approach to managing library operations. It reduces manual record keeping, improves book and member tracking, and allows both the website and Windows Forms application to share the same database. This makes the system more organized, efficient, and suitable for library administration.

```
```
