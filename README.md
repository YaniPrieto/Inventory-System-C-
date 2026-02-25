# Inventory Management System  
### C# | .NET Console Application | JSON Persistence

---

## Overview

The **Inventory Management System** is a console-based application developed in **C# using .NET**.  
It simulates a retail inventory workflow while focusing on backend architecture, clean code structure, and maintainability.

Although built as a CLI application, the project follows scalable design practices that allow seamless transition into a Web API or enterprise-level system.

---

## Tech Stack

- **Language:** C#
- **Framework:** .NET 6 / 7 / 8
- **Application Type:** Console (Non-GUI)
- **Data Storage:** JSON File Persistence
- **Serialization:** `System.Text.Json`
- **IDE:** Visual Studio / VS Code

---

## Core Features

- Create, Read, Update, Delete (CRUD) products
- Search products by ID or name
- Stock quantity management
- JSON-based data persistence
- Structured error handling
- Input validation
- Layered architecture design
- Menu-driven command interface

---


---

## Architecture Design

The application follows a **layered architecture**:

### 1. Presentation Layer
Handles user input and menu navigation via CLI.

### 2. Business Logic Layer (Service Layer)
Implements inventory rules and core operations.

### 3. Data Access Layer (Repository Pattern)
Abstracts file operations and manages JSON serialization.

This structure ensures:

- Separation of concerns  
- Maintainability  
- Extensibility  
- Cleaner debugging and testing  

---

## Data Model

```csharp
public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
