# Shopping Cart System (C# Console Application)

A modular, command-line shopping cart application built with C# and .NET, focusing on Object-Oriented Programming (OOP) principles and robust user input validation.

## 🚀 Achievements & Features

### 1. Object-Oriented Architecture
- **Data Modeling:** Created a `Product` class to encapsulate item properties.
- **Logic Separation:** Refactored the main script into a `ShoppingCart` manager class to follow the **Single Responsibility Principle**.
- **Encapsulation:** Used private fields within the manager class to protect data integrity.

### 2. Robust Input Validation ("Mini-Loop" Pattern)
- Implemented nested `while` loops for product entry to ensure:
  - Product names cannot be empty.
  - Prices must be valid decimals.
  - Quantities must be valid integers greater than zero.
- Users stay on the current question until valid data is provided, preventing "start-over" resets.

### 3. Advanced Command Parsing
- Developed a "Flat Loop" menu system allowing direct commands:
  - `add`: Enter the multi-step product creation flow.
  - `check`: View an alphabetized, formatted receipt.
  - `remove [index]`: Targeted removal of items using string splitting and index parsing.
  - `clear`: Wipe the cart with a safety confirmation prompt.
  - `exit/done`: Graceful program termination.

### 4. Professional Console UI
- **Formatting:** Used string interpolation and padding to create aligned table columns.
- **Currency:** Utilized C# format specifiers (`:C`) for regional currency support.
- **Real-time Feedback:** Added success messages and "Cancel/Back" options.

### 5. Data Integrity
- Integrated **In-place Sorting** to ensure the cart remains alphabetized automatically.

## 🛠️ Tech Stack
- **Language:** C#
- **Platform:** .NET
- **Concepts:** OOP, LINQ, Collections, String Manipulation, Input Parsing.

## 🗺️ Roadmap
- [x] Basic CRUD functionality (Add/Remove/Check)
- [x] Object-Oriented Refactoring (ShoppingCart Class)
- [x] Data Persistence (JSON Saving/Loading)
- [ ] Receipt Generation (.txt file export)
- [ ] Sales Tax & Discount Code Logic
- [ ] Unit Testing for Business Logic