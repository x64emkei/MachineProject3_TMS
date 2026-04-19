# TASK MANAGEMENT SYSTEM (TMS)

**Machine Project 3 — CS207L Data Structures & Programming**

---

## 📌 Project Overview

The **Task Management System (TMS)** is a desktop application built using **C# Windows Forms** for the front end and **MySQL** for the back end. It enables users to efficiently organize, track, and manage tasks through a clean and intuitive interface.

The system follows the **Metro Design Language**, emphasizing clarity, simplicity, and accessibility. It is structured as a multi-form application demonstrating strong implementation of GUI design, database connectivity, and object-oriented programming.

* **Repository:** [https://github.com/x64emkei/MachineProject3_TMS](https://github.com/x64emkei/MachineProject3_TMS)
* **Tech Stack:** C# WinForms + MySQL
* **Design:** Metro UI

---

## ⚙️ Development Workflow & Tools

* **GitHub** — Version control and repository management
* **Gemini** — Codebase analysis and logic tracing
* **Claude** — Documentation generation

> All tools were used strictly as assistants. The system design, logic, and implementation were executed by the developers.

---

## 🚀 System Features

### 🔐 Authentication (FrmLogin + FrmDBConnect)

* Secure login and registration
* Password recovery system
* Offline/demo mode fallback

### 🏠 Dashboard (FrmDashboard)

* Central navigation hub
* Metro-style UI tiles
* Session management

### ✅ Task Management (FrmTasks)

* Full CRUD operations
* Category assignment
* Real-time task counters
* Keyword search
* Smart date handling

### 🗂️ Category Management (frmCategories)

* Add, update, delete categories
* Deletion constraint protection
* Grid-to-editor synchronization

### 📊 Reports & Analytics (frmReports)

* Filter by status, priority, keywords
* LINQ-based statistics
* Export to CSV and TXT

### ⚙️ Database Configuration (FrmDBConnect)

* Dynamic MySQL connection setup

### ℹ️ About (frmAbout)

* Project details
* Credits and academic integrity

---

## 🧠 System Architecture

The system follows a **Separation of Concerns (SoC)** architecture:

### 🖥️ UI Layer (Forms)

* Handles presentation logic only
* No embedded SQL queries

### 🗄️ Data Access Layer (Classes)

* Encapsulates all SQL operations

#### Core Classes:

* `DbConnection.cs` — Manages database connections
* `TaskFunctions.cs` — Task-related queries
* `CategoryFunctions.cs` — Category-related queries

---

## 🗃️ Database Design

### Database Initialization

```sql
CREATE DATABASE IF NOT EXISTS task_management_db;
USE task_management_db;
```

### 👤 Users Table

| Column   | Type         | Description       |
| -------- | ------------ | ----------------- |
| user_id  | INT (PK)     | Unique user ID    |
| username | VARCHAR(50)  | Unique login name |
| password | VARCHAR(100) | Stored password   |
| name     | VARCHAR(100) | Full name         |
| email    | VARCHAR(100) | Used for recovery |

### 🗂️ Categories Table

| Column        | Type         | Description          |
| ------------- | ------------ | -------------------- |
| category_id   | INT (PK)     | Unique category ID   |
| category_name | VARCHAR(100) | Category name        |
| description   | VARCHAR(255) | Optional description |

### 📌 Tasks Table

| Column      | Type         | Description                   |
| ----------- | ------------ | ----------------------------- |
| task_id     | INT (PK)     | Unique task ID                |
| task_title  | VARCHAR(100) | Task title                    |
| description | VARCHAR(255) | Task details                  |
| due_date    | DATE         | Deadline                      |
| priority    | VARCHAR(20)  | High/Medium/Low               |
| status      | VARCHAR(20)  | Pending/In Progress/Completed |
| assigned_to | VARCHAR(100) | Responsible person            |
| category_id | INT (FK)     | Linked category               |

> **Constraint:** `ON DELETE RESTRICT` prevents deleting categories with assigned tasks.

---

## 🏗️ Technical Highlights

* **Separation of Concerns** — Clean architecture
* **Parameterized SQL** — Prevents SQL injection
* **Responsive UI** — Adaptive layout scaling
* **Defensive Programming** — Error handling and validation
* **Offline Mode** — Runs without database connection
* **LINQ Analytics** — Efficient in-memory statistics

---

## ⚡ Setup & Installation

### 📋 Prerequisites

* Visual Studio 2022/2026 (.NET Desktop Development)
* MySQL Server
* MySQL Connector/NET (NuGet: `MySql.Data`)

### 🗄️ Database Setup

1. Open MySQL Workbench
2. Create database: `task_management_db`
3. Run table initialization scripts
4. Insert default user:

   * **Username:** `admin`
   * **Password:** `admin123`

### 💻 Application Setup

1. Open solution file (`.sln`) in Visual Studio
2. Restore NuGet packages
3. Build and run
4. Configure database connection:

   * Server: `localhost`
   * Username: `root`
   * Password: *(blank or your setup)*
   * Database: `task_management_db`
5. Login using default credentials

---

## 🎓 Academic Integrity & Roles

This project was developed independently in compliance with academic policies. No unauthorized code sharing or plagiarism was involved.

### 👥 Team Roles

* **Ordenes** — UI Design & Application Logic
* **Baarde** — Core System Logic Implementation
* **Tumbaga** — Documentation & Database Design

### 🤖 AI Usage

* **Gemini** — Code analysis assistance
* **Claude** — Documentation support

> All architectural and implementation decisions are original work.

---

## 👨‍💻 Developers

**ORDENES · BAARDE · TUMBAGA**

---

## 📎 License / Disclaimer

This project is developed strictly for academic purposes under CS207L Machine Project 3 requirements.

All trademarks, tools, and technologies used (including Microsoft Visual Studio and MySQL) are the property of their respective owners.

---

## ⭐ Final Note

A well-designed system is not just about functionality, but about **user experience, maintainability, and resilience**. This project reflects a balance of all three.
