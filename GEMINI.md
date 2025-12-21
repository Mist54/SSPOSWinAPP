# SSPOS-WINFORMS-25-09-2024

## Project Overview

This is a "Simple Point of Sale" (SSPOS) system developed as a Windows Forms application using C# and the .NET Framework 4.7.2. The project follows a 3-tier architecture:

*   **SSPOS.GUI:** The presentation layer, containing the user interface (WinForms).
*   **SSPOS.BLL:** The Business Logic Layer, which contains the business objects and logic.
*   **SSPOS.DLL:** The Data Logic Layer, responsible for data access and communication with the database.

The application uses a SQL Server database for data storage. The database backup (`SSPOS.bak`) and a SQL Server Database Project (`SSPOSDB.sqlproj`) are included in the repository.

### Key Technologies & Libraries

*   .NET Framework 4.7.2
*   C#
*   Windows Forms
*   SQL Server
*   MaterialSkin.2 (for UI theming)
*   Newtonsoft.Json (for JSON serialization)
*   QRCoder (for generating QR codes)

## Building and Running

To build and run this project, you will need:

*   Visual Studio (2017 or later recommended)
*   .NET Framework 4.7.2 Developer Pack
*   SQL Server (Express edition is sufficient)

### Steps:

1.  **Restore the Database:**
    *   Open SQL Server Management Studio (SSMS).
    *   Restore the database from the `Database/SSPOS.bak` file. Name the database `SSPOS`.

2.  **Configure the Connection String:**
    *   Open the `SSPOS.GUI/App.config` file.
    *   Locate the `<connectionStrings>` section.
    *   Update the `connectionString` attribute of the `SSPOSDBConnectionString` to point to your SQL Server instance. For example:
        ```xml
        <add name="SSPOSDBConnectionString" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=SSPOS;Integrated Security=True;" providerName="System.Data.SqlClient" />
        ```

3.  **Build and Run the Solution:**
    *   Open the `SSPOS.GUI/SSPOS.GUI.sln` file in Visual Studio.
    *   Set `SSPOS.GUI` as the startup project.
    *   Build the solution (Build > Build Solution or `Ctrl+Shift+B`).
    *   Run the project (Debug > Start Debugging or `F5`).

### Default Login

The application has a default administrator account for demonstration purposes:

*   **Username:** `SA`
*   **Password:** `SA`

## Development Conventions

*   **Naming Conventions:**
    *   Classes are named using PascalCase (e.g., `Product`, `LoginForm`).
    *   Methods are named using PascalCase (e.g., `RetrieveAll`, `userAuthentication`).
    *   Private fields are prefixed with an underscore and use camelCase (e.g., `_productName`).
    *   Properties are named using PascalCase (e.g., `ProductName`).
*   **Architecture:** The code is structured into three layers (GUI, BLL, DLL) to separate concerns.
*   **Data Access:** The Data Logic Layer (DLL) uses `System.Data.SqlClient` and stored procedures to interact with the SQL Server database.
*   **Error Handling:** `try-catch` blocks are used for exception handling, especially in the data access and business logic layers.
*   **UI:** The project uses the `MaterialSkin.2` library to create a modern, Material Design-inspired user interface.
