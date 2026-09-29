# LabMaster System

<div align="center">

![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind_CSS-38B2AC?style=for-the-badge&logo=tailwind-css&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-blue.style=for-the-badge)

**A university laboratory and equipment management platform built with ASP.NET Core MVC and .NET 9.**

[Overview](#-overview) • [Key Features](#-key-features) • [Tech Stack](#-technology-stack) • [Architecture](#-architecture--design-patterns) • [Getting Started](#-getting-started) • [Project Structure](#-project-structure) • [Security](#-security--production-hardening)

</div>

---

## 📖 Overview

**AAUP LabMaster** is an enterprise-grade ASP.NET Core MVC web application designed to digitize and automate university laboratory management. It unifies lab operations, equipment inventory tracking, user roles, supervisor assignments, and real-time booking requests into a centralized workflow.

The system features robust **Role-Based Access Control (RBAC)** tailored for Administrators, Laboratory Supervisors, and Clients (Students/Faculty), streamlining equipment scheduling and mitigating double-booking conflicts.

---

## ✨ Key Features

### 👤 User & Authentication Management
* **Role-Based Control:** Granular workflows for **Admins**, **Supervisors**, and **Clients**.
* **Identity & Security:** Cookie-based authentication with claims-based authorization.
* **Account Recovery:** Self-service password reset and profile management.
* **Admin Governance:** Centralized user provisioning, role assignments, and account status management.

### 🔬 Laboratory & Equipment Inventory
* **Laboratory Management:** Create, configure, and monitor lab operational statuses and assign dedicated supervisors.
* **Equipment Cataloging:** Item tracking with availability flags, hourly/flat rate pricing, laboratory linkage, external documentation links, and image uploads.
* **Smart Search & Filter:** Dynamic filtering of equipment by lab, availability, name, and attributes.

### 📅 Booking & Reservation Engine
* **Availability Verification:** Automated checks preventing scheduling overlaps and resource exhaustion.
* **Approval Workflows:** Supervisor-driven request reviews (**Pending** $\rightarrow$ **Approved** / **Rejected**).
* **Audit & History:** Full reservation logging and historical tracking for users and lab managers.

### 🔔 Notifications & Analytics
* **Status Alerts:** Automated notifications triggered by booking approvals, rejections, or lab updates.
* **Reporting Dashboards:** Insights into overall booking volume, equipment utilization rates, and most frequently requested laboratories.

---

## 🛠 Technology Stack

| Domain | Technology | Description |
| :--- | :--- | :--- |
| **Framework** | ASP.NET Core MVC (.NET 9) | High-performance Web Application Framework |
| **Language** | C# 13 | Primary Backend Development Language |
| **Database** | Microsoft SQL Server | Relational Database Engine |
| **ORM** | Entity Framework Core 9 | Data Access & Code-First Migrations |
| **Frontend** | Razor Views, Tailwind CSS, PostCSS, JS | Responsive UI Engine |
| **Authentication** | ASP.NET Core Cookie Auth | Claims-Based Session Management |
| **Tooling** | Visual Studio 2022 / JetBrains Rider / VS Code | Primary IDE Environments |

---

## 🏗 Architecture & Design Patterns

The project implements a classic **Layered Model-View-Controller (MVC)** architecture combined with a **Manager/Service Pattern** (`EntityManager`) to isolate domain logic from HTTP request controllers.

```text
               ┌────────────────────────┐
               │    Client Web Browser  │
               └───────────┬────────────┘
                           │ HTTP Request
                           ▼
               ┌────────────────────────┐
               │   ASP.NET Core MVC     │
               │      Controllers       │
               └───────────┬────────────┘
                           │ Delegates Execution
                           ▼
               ┌────────────────────────┐
               │     EntityManager      │
               │ (Core Business Logic)  │
               └───────────┬────────────┘
                           │ Queries / Persists
                           ▼
               ┌────────────────────────┐
               │ Entity Framework Core  │
               │      (DBCntext)        │
               └───────────┬────────────┘
                           │ SQL Queries
                           ▼
               ┌────────────────────────┐
               │   MS SQL Server DB     │
               └────────────────────────┘
