# Task & Team Management System

A clean-architecture based .NET 8 Web API project for managing Users, Teams, and Tasks using CQRS with MediatR, JWT authentication, and role-based access control.

---

## 📁 Project Structure

- `TMS.Domain` - Entity models and enums.
- `TMS.Application` - Application logic, DTOs, CQRS commands/queries/handlers, interfaces.
- `TMS.Infrastructure` - EF Core DbContext, repositories, seeders, DI configuration.
- `TMS.API` - Web API project with controllers, middleware, JWT authentication.

---

## 🛠️ Technologies Used

- ASP.NET Core 8
- Entity Framework Core
- MediatR (CQRS pattern)
- FluentValidation
- AutoMapper
- Swagger / OpenAPI
