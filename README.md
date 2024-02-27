# Library Management System (LMS)

This repository contains the source code for a Library Management System (LMS) implemented in C# using Windows Forms. The system allows users to perform various functions related to library operations such as searching for books, borrowing and returning books, managing memberships, adding books to the library inventory, and selling books as a supplier.

## UserFunction Form

### Features
- **Search Book**: Users can search for books by title.
- **Borrow Book**: Users can borrow a book from the library.
- **Return Book**: Users can return a borrowed book to the library.
- **Apply Membership**: Users can apply for a membership to access library services.

## SupplierFunction Form

### Features
- **Search Book**: Suppliers can search for books available in the inventory.
- **Sell Book**: Suppliers can sell books to the library by adding them to the inventory.

## LibraryStaffFunction Form

### Features
- **Add Book**: Library staff can add new books to the library inventory.
- **Search Book**: Library staff can search for books by title.
- **Reserve Book**: Library staff can mark books as reserved or not reserved.
- **Update Book**: Library staff can update the information of existing books.
- **Lend Book**: Library staff can lend books to library members.

## Usage

1. Run the application.
2. Select the appropriate function form based on your role (User, Supplier, or Library Staff).
3. Perform the desired action by following the instructions provided in each form.

## Note
- This application requires access to a SQL Server database. Update the connection string in the code to point to your database server.
