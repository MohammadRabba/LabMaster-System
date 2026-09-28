# AAUP LabMaster

<div align="center">

![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind_CSS-38B2AC?style=for-the-badge&logo=tailwind-css&logoColor=white)

**An ASP.NET Core MVC web application designed to manage university laboratories, equipment, users, supervisors, and laboratory booking requests.**

</div>

---

## 📖 Overview

**AAUP LabMaster** provides role-based workflows for Administrators, Clients, and Supervisors, supporting equipment management, laboratory management, booking approvals, notifications, availability tracking, and usage reports.

---

## 🚀 Features

### 👤 User & Authentication Management
* User registration and login
* Cookie-based authentication
* Role-based access control
* Password recovery and reset
* User profile management
* Administrator user management

### 🧪 Laboratory Management
* Create, edit, and delete laboratories
* Assign supervisors to laboratories
* View laboratory information
* Track laboratory usage

### 🔧 Equipment Management
* Create, edit, and delete equipment
* Equipment name and description
* Quantity and availability status
* Equipment pricing
* Laboratory association
* Image uploads
* External equipment links
* Equipment search and filtering

### 📅 Booking Management
* Submit equipment booking requests
* Check equipment availability
* Review and approve/reject booking requests
* Track booking status
* View booking history
* Filter booking requests
* Administrative booking management

*Booking statuses include:* **Pending**, **Approved**, **Rejected**.

### 🔔 Notifications
* Booking status notifications
* User notification management
* Updates for booking approvals and rejections

### 📊 Reports
* Total booking statistics
* Most-used laboratories
* Basic laboratory and booking usage information

---

## 🛠️ Technology Stack

| Category | Technology |
| :--- | :--- |
| **Language** | C# |
| **Frontend** | HTML, Razor, CSS, JavaScript |
| **Framework** | ASP.NET Core MVC |
| **Runtime** | .NET 9 |
| **Database** | Microsoft SQL Server |
| **ORM** | Entity Framework Core 9 |
| **Authentication** | Cookie-based authentication with role claims |
| **UI** | Razor Views |
| **CSS** | Tailwind CSS / PostCSS |
| **IDE** | Visual Studio 2022, JetBrains Rider, or VS Code |

### Main Libraries
* `Microsoft.EntityFrameworkCore`
* `Microsoft.EntityFrameworkCore.SqlServer`
* `Microsoft.EntityFrameworkCore.Tools`
* `Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation`
* Tailwind CSS
* PostCSS

---

## 📁 Project Structure

```text
AAUP_LabMaster/
│
├── Controllers/
│   ├── AccountControllers.cs       # Authentication, registration, login, password recovery
│   ├── AdminControllers.cs         # User, lab, booking, and reporting administration
│   ├── HomeControllers.cs          # Public and home pages
│   ├── SupervisourController.cs    # Supervisor lab, equipment, and booking management
│   └── UserControllers.cs          # Client equipment, bookings, and notifications
│
├── EntityDTO/
│   ├── LoginDTO.cs                 # Login data
│   ├── UserDTO.cs                  # User registration and profile data
│   ├── BookingDTO.cs               # Booking input data
│   ├── EquipmentDTO.cs             # Equipment input data
│   ├── LabDTO.cs                   # Laboratory input data
│   └── *PasswordDTO.cs             # Password recovery and reset data
│
├── EntityManager/
│   ├── AccountManager.cs           # Registration and authentication logic
│   ├── Admin Manager.cs            # Administrative operations
│   ├── BookingManager.cs           # Booking updates and status changes
│   ├── ClientManager.cs            # Client bookings and notifications
│   ├── EquipmentManager.cs         # Equipment CRUD and availability
│   ├── LabManager.cs               # Laboratory CRUD operations
│   ├── NotificationManager.cs      # User notification handling
│   └── SupervisourManager.cs       # Supervisor-specific operations
│
├── Models/
│   ├── DBCntext.cs                 # Entity Framework database context
│   ├── User.cs                     # Base user entity
│   ├── Admin.cs                    # Administrator entity
│   ├── Client.cs                   # Client entity
│   ├── Supervisour.cs              # Supervisor entity
│   ├── Lab.cs                      # Laboratory entity
│   ├── Equipment.cs                # Equipment and availability status
│   ├── Booking.cs                  # Booking and approval status
│   └── Notification.cs             # User notifications
│
├── Migrations/                     # Entity Framework database migrations
│
├── Views/
│   ├── Account/                    # Login, registration, and password pages
│   ├── Admin/                      # Administration dashboards and management
│   ├── Home/                       # Public pages
│   ├── Supervisour/                # Supervisor pages
│   ├── User/                       # Client pages
│   └── Shared/                     # Shared layouts and partial views
│
├── wwwroot/
│   ├── img/                        # Uploaded and static images
│   ├── css/                        # Stylesheets
│   └── js/                         # Client-side scripts
│
├── Program.cs                      # Application startup and dependency injection
├── AAUP_LabMaster.csproj           # .NET project and package references
├── appsettings.json                # Application configuration
├── package.json                    # Tailwind CSS/PostCSS tooling
└── AAUP_LabMaster.sln              # Visual Studio solution

```

> **Note:** Some existing filenames contain spelling inconsistencies such as `Supervisour`, `DBCntext`, and `Admin Manager`. These names are preserved above to match the current project structure.

---

## 🏗️ Architecture

AAUP LabMaster follows the ASP.NET Core MVC architecture.

### Application Flow

```text
┌─────────────────┐
│   User Request  │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│ MVC Controllers │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│ Entity Managers │
│  Business Logic │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│ Entity Framework│
│      Core       │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│   SQL Server    │
└─────────────────┘

```

1. Users send requests to MVC controllers.
2. Controllers validate requests and handle application flow.
3. Business and database operations are delegated to manager classes.
4. Entity Framework Core communicates with SQL Server.
5. Controllers return Razor views to the client.
6. Cookie authentication provides the current user's identity and role claims.

### Main Domain Entities

* User
* Administrator
* Client
* Supervisor
* Laboratory
* Equipment
* Booking
* Notification

---

## ⚙️ Getting Started

### Prerequisites

Make sure the following software is installed:

* [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0?utm_source=gemini)
* Microsoft SQL Server or SQL Server Express
* Node.js and npm *(optional for frontend tooling)*
* Visual Studio 2022, JetBrains Rider, or VS Code

### 1. Clone the Repository

```bash
git clone [https://github.com/MohammadRabba/AAUP_LabMaster.git](https://github.com/MohammadRabba/AAUP_LabMaster.git)
cd AAUP_LabMaster

```

### 2. Configure the Database

The application uses the connection string named `DefaultConnection`. For local development, you can configure the connection string in `appsettings.json`. However, **.NET User Secrets** are recommended so sensitive information is not committed to source control.

Initialize User Secrets:

```bash
dotnet user-secrets init

```

Set the database connection string:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost;Database=AAUP_LabMasterDB;Trusted_Connection=True;TrustServerCertificate=True"

```

**SQL Server Express**
For SQL Server Express, the connection string may look like:

```text
Server=localhost\SQLEXPRESS;Database=AAUP_LabMasterDB;Trusted_Connection=True;TrustServerCertificate=True

```

> ⚠️ **Important:** Never commit real database credentials, passwords, API keys, or machine-specific connection strings to the repository.

### 3. Restore Dependencies

Restore the .NET dependencies:

```bash
dotnet restore

```

### 4. Apply Entity Framework Migrations

Update the database using the existing Entity Framework migrations:

```bash
dotnet ef database update

```

*(If the Entity Framework CLI is not installed: `dotnet tool install --global dotnet-ef`)*

### 5. Install Frontend Dependencies

Install the npm dependencies:

```bash
npm install

```

*Note: The current `package.json` does not define a frontend build script. If Tailwind CSS compilation is required, an appropriate build/watch script must be configured.*

### 6. Run the Application

Start the application using:

```bash
dotnet run

```

For development with automatic reload:

```bash
dotnet watch

```

After the application starts, open the URL displayed in the terminal (typically `https://localhost:xxxx`).

### 7. Default MVC Route

The application uses the following default MVC route:

```text
/{controller=Home}/{action=Index}/{id?}

```

---

## 🔨 Build & Testing

### Build

To build the project:

```bash
dotnet build

```

### Testing

There is currently no automated test project or configured test suite in the repository (the current `package.json` contains a placeholder `npm test` command).

For production readiness, **Unit**, **Integration**, and **End-to-End** tests should be added for:

* Authentication & Authorization
* Role-based access control
* Booking availability & status transitions
* Equipment & Laboratory management
* Manager/business logic
* Database operations & Controller integration

---

## 🔐 Security Considerations

Before deploying the application to production, address the following security improvements:

* **Password Security:** Passwords should be securely hashed rather than stored as plain text.
* **Secrets Management:** Sensitive configuration values (DB connections, JWT signing keys, API keys) should be stored using environment variables, .NET User Secrets, or a secure secret-management service like Azure Key Vault.
* **Authorization:** Ensure authorization attributes are consistently applied to all protected controller actions.
* **File Uploads:** Validate uploaded files on the server (File type, size, extension, and content).
* **Anti-Forgery Protection:** Use anti-forgery validation (`[ValidateAntiForgeryToken]`) on all state-changing requests to protect against CSRF attacks.
* **Error Handling:** Avoid exposing detailed exception messages or stack traces to end users in production.
* **Authentication Claims:** Review role claims to ensure User IDs are consistently available, roles are correctly assigned, and unauthorized users cannot access protected resources.

**Production Configuration:**

* Enable HTTPS and HSTS.
* Configure production logging.
* Secure database credentials and configure backups.
* Disable development-only error pages.
* Configure appropriate security headers.

---

## 📌 Project Status

AAUP LabMaster currently provides the core functionality required for managing university laboratories, equipment, users, supervisors, bookings, and notifications. Areas such as automated testing, production security hardening, and frontend build configuration require additional work before a production deployment.

---

## 👨‍💻 Repository & Support

**GitHub Repository:** [https://github.com/MohammadRabba/AAUP_LabMaster](https://github.com/MohammadRabba/AAUP_LabMaster?utm_source=gemini)

If you encounter an issue or have a suggestion, please open an issue in the GitHub repository.

### ⭐ Contributing

Contributions, suggestions, and improvements are welcome:

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -m "Add your feature"`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Open a Pull Request
#   L a b M a s t e r - S y s t e m  
 