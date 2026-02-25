Inventory Management System (C# Console Application)
Overview

This project is a console-based Inventory Management System built using C# and .NET.
It simulates a small retail inventory workflow and demonstrates backend-focused software design without a graphical user interface.

The system highlights clean code practices, separation of concerns, object-oriented programming, and structured data persistence using file storage.

Tech Stack

Language: C#

Framework: .NET 6 / 7 / 8

Application Type: Console (CLI)

Data Storage: JSON file persistence

Serialization: System.Text.Json

IDE: Visual Studio / VS Code

Features

Add new products

View all products

Update product information

Delete products

Search products by ID or name

Stock quantity management

Persistent data storage using JSON

Input validation and error handling

Modular service-based architecture

Architecture

The application follows a simple layered structure:

Program.cs

Application entry point

Handles menu navigation and user interaction

Models/Product.cs

Defines product entity

Services/InventoryService.cs

Contains business logic

Handles CRUD operations

Data/FileRepository.cs

Manages file read/write operations

Handles serialization and deserialization

This structure ensures:

Separation of concerns

Maintainable and extensible code

Clear distinction between UI, logic, and persistence

Data Model
public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
Application Flow

Application starts.

Inventory data is loaded from JSON file.

User selects an option from the menu.

Business logic processes the request.

Updated data is saved back to the file.

Application continues until exit is selected.

How to Run

Clone the repository:

git clone https://github.com/yourusername/inventory-system-csharp.git
cd inventory-system-csharp

Build the project:

dotnet build

Run the application:

dotnet run
Sample Console Interface
=== INVENTORY MANAGEMENT SYSTEM ===
1. Add Product
2. View Products
3. Update Product
4. Delete Product
5. Search Product
6. Exit
Select Option:
Technical Concepts Demonstrated

Object-Oriented Programming (OOP)

SOLID principles (basic application)

Repository-style data abstraction

JSON serialization/deserialization

Exception handling

Input validation

Modular code organization

CLI application design

Edge Case Handling

Prevents duplicate product entries

Validates non-negative stock quantities

Handles missing or corrupted data files

Safe deserialization fallback

Scalability Potential

This system can be extended into:

ASP.NET Core Web API

Entity Framework Core with SQL Server

JWT Authentication

Role-Based Access Control (RBAC)

RESTful API endpoints

Frontend integration (React, Blazor)

Cloud deployment (Azure / AWS)

Author

John Prieto
C# Developer | Backend-Focused Engineer | Game Developer | WordPress Developer

License: Educational and portfolio use.
