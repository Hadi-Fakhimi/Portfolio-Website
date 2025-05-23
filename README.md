# 🧑‍💼 Resume Website – Hadi Fakhimi

A professional and secure resume website built with **ASP.NET Core 5, following the **Clean Architecture** pattern.  
Includes 🔐 authentication, ✉️ email service, 📈 visit tracking, and a 📝 blog system in version 2.

---

## ✨ Features

- 🧱 Built using **Clean Architecture**
- 🔐 **Authentication** with secure password hashing
- ✉️ **Email sender** using MailKit
- 📈 **Visit counter** for tracking page views
- 📝 **Blog system** added in [`version-2`](https://github.com/Hadi-Fakhimi/Portfolio-Website/tree/version-2)
- 🧪 **Unit & Integration Tests**
- 🌐 **RESTful API**

---

## 🛠 Technologies & Tools

| 🔧 Stack              | 💡 Details                 |
|----------------------|------------------------------|
| Framework            | ASP.NET Core 5               |
| Architecture         | Clean Architecture           |
| ORM                  | Entity Framework Core        |
| Authentication       | Identity , Password Hashing  |
| Email Service        | MailKit                      |
| Validation           | FluentValidation             |
| Database             | SQL Server                   |

---

## 🗂️ Project Structure

```bash
├── ResumeApp.Api           # API entry point
├── ResumeApp.Application   # Application layer (Use Cases)
├── ResumeApp.Domain        # Domain models (Entities, Enums)
├── ResumeApp.Infrastructure# Services (Email, Auth, etc.)
├── ResumeApp.Persistence   # Data access (EF Core, Migrations)
├── ResumeApp.Web           # (Optional) Razor-based UI
└── Tests                   # Unit and integration tests
