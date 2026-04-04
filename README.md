📊 Task Management System (Metro UI)

A sleek, dark-mode "Metro UI" Task Management System built with C# (Windows Forms) and a MySQL database. This application is designed to help users efficiently organize, track, and report on their workloads using a flat, tile-based interface inspired by modern Windows design.

Built as a Machine Project for CS207L | Object Oriented Programming.

✨ Features

🔐 Secure Authentication: Complete user login, account registration, password recovery, and a hidden developer "Admin Bypass" mode.

🗂️ Tile-Based Dashboard: A centralized, color-coded hub for navigating the application modules.

✅ Full CRUD Capabilities: Create, Read, Update, and Delete both Tasks and Categories. Tasks track detailed metadata such as Due Dates, Priority (High/Med/Low), Status (Pending/Completed), and Assignees.

📊 Reports & Live Analytics: A comprehensive Task Viewer featuring custom search, quick filters, and live mini-tile stat counters (Total, Pending, Completed).

💾 Export Tools: Built-in options to export task data to TXT, CSV, PDF, or direct to Print.

⌨️ Power-User Accessibility: Completely keyboard-friendly with fully mapped MenuStrip items, access keys (&), and standard shortcut combinations (e.g., Ctrl+S to save) for rapid data entry.

🛠️ Technology Stack

Language: C#

Framework: .NET Framework (Windows Forms)

Database: MySQL

Tools Used: * Visual Studio 2022 Community Edition

MySQL Workbench 8 CE

📸 Screenshots

(Hint: Add your screenshots to an assets folder in GitHub and link them here!)

Dashboard: ![Dashboard UI](assets/dashboard.png)

Task Editor & Directory: ![Task Management UI](assets/tasks.png)

Reports & Statistics: ![Reports UI](assets/reports.png)

🚀 Installation & Setup

Clone the repository:

git clone [https://github.com/yourusername/TaskManagementSystem.git](https://github.com/yourusername/TaskManagementSystem.git)


Setup the Database:

Open MySQL Workbench (or XAMPP/WAMP).

Create a new database named task_management_db.

Import the provided database.sql script (if applicable) or run the necessary CREATE TABLE scripts for users, tasks, and categories.

Configure Connection String:

Open the project in Visual Studio 2022 CE.

Locate the connection string in the code files (e.g., entry_login.cs, frmTaskManagement.cs) and update the Uid and Pwd to match your local MySQL server credentials.

string connectionString = "Server=localhost;Database=task_management_db;Uid=root;Pwd=yourpassword;";


Run the Application:

Press F5 or click Start in Visual Studio to compile and run the program.

👨‍💻 Development Team

Michael Ordenes

Adrian Baarde

Kurt Cezmer Tumbaga

Course: CS207L | Object Oriented Programming

Instructor: Leandro "Jun" Ercia Jr.
