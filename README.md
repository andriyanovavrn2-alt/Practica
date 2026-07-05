# 📦 Production Accounting System

**Production Accounting System** is a desktop application built with Windows Forms and PostgreSQL, designed to automate inventory management, controller model tracking, and failure/repair logging for industrial enterprises. This project was developed during my internships at **JSC "Ecoresource"** (Voronezh) as part of my college curriculum (specialty 09.02.07 – Information Systems and Programming).

The project covers two key practice modules:
- **PM.02** – Development and integration of software modules (first internship)
- **PM.04** – Software maintenance, testing, and security (second internship)

---

## 🚀 Features

| Category | Capabilities |
|----------|--------------|
| **Component Management** | Full CRUD operations; stock intake/issue; automatic minimum stock warnings; visual highlighting when quantity reaches zero. |
| **Controller Models** | Create, edit, delete models; define specifications (bill of materials) with component quantities per unit. |
| **Finished Controllers** | Add individual units with unique serial numbers, production date, and status (`In stock`, `Shipped`, `Under repair`). |
| **Failure Registration** | Log failures with date, description, and criticality (High/Medium/Low); automatically changes controller status to "Under repair". |
| **Repair Management** | Perform repairs: specify master, repair date, work description, replaced components; status returns to "In stock" upon completion. |
| **User Roles** | – **Administrator**: full access (create/edit/delete all records).<br>– **Engineer**: view‑only for reference data, can register failures and perform repairs. |
| **Search & Filter** | Global text search; filter by component type, controller status, failure criticality; sort by stock quantity (ascending/descending). |
| **Card‑based UI** | All entities displayed as interactive cards in a scrollable `FlowLayoutPanel` – intuitive and responsive. |

---

## 🛠️ Technologies Used

| Technology | Role |
|------------|------|
| **C#** (WinForms) | Application logic and UI |
| **.NET Framework 4.8** | Runtime environment |
| **PostgreSQL 12+** | Relational database |
| **Npgsql** | ADO.NET data provider for PostgreSQL |
| **draw.io** | Functional modelling (IDEF0 diagrams) |
| **Software Ideas Modeler** | UML and ER diagram design |
| **Git & GitHub** | Version control and repository hosting |
| **Visual Studio 2026** | Development environment |

---

## 📊 Database Design

The database consists of 9 interconnected tables (all in 3NF). Below is the physical schema:
<img width="883" height="330" alt="image" src="https://github.com/user-attachments/assets/a64b6728-f987-4726-ad44-16c5ede90269" />

---

## 👥 User Roles & Permissions

| Action | Administrator | Engineer |
|--------|---------------|----------|
| View components/models/controllers/failures/repairs | ✅ | ✅ |
| Add/Edit/Delete components, models, specifications | ✅ | ❌ |
| Register failures | ✅ | ✅ |
| Perform repairs | ✅ | ✅ |
| Manage users | ❌ | ❌ *(handled externally)* |

---

## 🧑‍💻 Development Process

### 1. Analysis & Requirements
- Studied the business processes of JSC "Ecoresource" – component stock, controller assembly, failure handling.
- Created functional models using **IDEF0** (draw.io) to map inputs, outputs, controls, and mechanisms.
- Formulated a detailed technical specification (GOST 34.602-2020) with functional and non‑functional requirements.

### 2. Design
- **UML Use‑Case Diagram** – identified actors and system boundaries.
- **ER Diagram** – defined entities, attributes, and relationships.
- **Physical Database Model** – designed tables, keys, and data types in PostgreSQL.
- **Class Diagram** – structured the application into forms, user controls, and data access logic.
- **Deployment Diagram** – illustrated client‑server architecture.

### 3. Implementation
- Built the Windows Forms interface with **FlowLayoutPanel** for dynamic card loading.
- Implemented all CRUD operations with **parameterised SQL queries** (to prevent injection).
- Added stock operation logic (intake/issue) with real‑time validation and stock‑level warnings.
- Integrated role‑based UI (buttons hidden/shown depending on role).
- Tested each feature thoroughly (positive and negative cases).

### 4. Version Control
- Used Git for source control throughout development.
- Repository hosted on GitHub: [Practica](https://github.com/andriyanovavrn2-alt/Practica)

---

## 🧪 Testing & Security (PM.04 – Maintenance Practice)

During the second internship, the application underwent comprehensive testing and security hardening:

### Black‑Box Testing
- **Login validation** – correct/incorrect credentials tested.
- **Form input validation** – mandatory fields checked; error messages appear for empty fields.
- **Stock operations** – preventing negative stock with clear error feedback.
- **All tests passed** – no critical defects were found; the system handles invalid input gracefully.

### White‑Box Testing
- Code review and structural analysis of key components:
  - `Autoriz` – authentication logic
  - `MainForm` – role‑based UI and data loading
  - `ComponentControl1` – component card with CRUD operations
  - `Add_Edit_Component_Formcs` – add/edit form with validation
- All methods were verified against expected behavior.

### Non‑Functional Testing
- Resource usage monitored via **Task Manager**:
  - CPU load: 0% during all operations
  - RAM usage: ~5–21 MB
  - Disk I/O: 0 MB/s
- The application is lightweight and does not overload system resources.

### Security Measures

#### Password Hashing (pgcrypto)
- Passwords are no longer stored in plain text.
- PostgreSQL `pgcrypto` extension with **Blowfish algorithm** (`crypt()` + `gen_salt('bf')`) is used.
- Login method was updated to use `password = crypt(entered_password, stored_password_hash)` for secure verification.

#### Role‑Based Access Control (RBAC)
- Two roles implemented: **Administrator** and **Engineer**.
- Access control enforced at two levels:
  - **UI level** – buttons and panels hidden for engineers.
  - **Database level** – queries include role checks where applicable.
- Engineers can **only** view reference data, register failures, and perform repairs – exactly what they need for production work.

### Backup & Maintenance
- A backup script was created using `pgAdmin` → **ERD for Database** → SQL dump.
- Full database backup stored in `back_up/sql_backup_controller.sql`.
- Backup includes all tables, constraints, and data.
- Version control via Git – all code changes tracked and pushed to GitHub.

---

## 📚 What I Learned

During this project, I gained practical experience in:

- **Requirements gathering** – translating business needs into technical specifications.
- **Database design** – normalisation, foreign keys, and writing efficient SQL queries.
- **C# Windows Forms** – building responsive user interfaces with custom user controls.
- **ADO.NET (Npgsql)** – connecting to PostgreSQL, executing commands, handling transactions.
- **Role‑based access** – implementing UI visibility and logic based on user roles.
- **Error handling** – validating user input, preventing negative stock, and providing clear feedback.
- **Git workflow** – committing, pushing, and maintaining a clean repository.
- **Technical documentation** – writing user manuals, test protocols, and project reports.
- **Software testing** – black‑box, white‑box, and non‑functional testing methodologies.
- **Database security** – encrypting passwords using `pgcrypto` and Blowfish hashing.
- **Backup strategies** – creating and storing database dumps for disaster recovery.

---

## 🔮 Future Improvements

- **Audit Log** – track who changed what and when.
- **Reporting** – generate PDF/XLS reports for inventory and repair statistics.
- **Automatic Reorder** – send notifications or create purchase orders when stock falls below minimum.
- **Modular Architecture** – separate data access layer (Repository pattern) for better maintainability.
- **Unit Testing** – add NUnit/xUnit tests to ensure code reliability.
- **Deployment Installer** – create an MSI installer using WiX or Inno Setup.
- **Multi‑language Support** – add English/Russian toggle.

---

## 🎥 Video Demo


https://github.com/user-attachments/assets/60bef6db-372d-47be-a7b3-7e152fdf434b




