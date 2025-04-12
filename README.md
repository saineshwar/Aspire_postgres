# 🐘 Integrating PostgreSQL with .NET Aspire

This repository demonstrates how to integrate **PostgreSQL** with **.NET Aspire**, a powerful and modern framework for building cloud-native, distributed applications.

## 🚀 What is .NET Aspire?

[.NET Aspire](https://devblogs.microsoft.com/dotnet/introducing-dotnet-aspire/) is a cloud-native development stack for .NET, designed to streamline microservice orchestration, observability, and integration with essential infrastructure like databases, message queues, and cloud services.

## 🛢️ Why PostgreSQL?

**PostgreSQL** is a robust, open-source, enterprise-grade relational database. It’s highly extensible and supports advanced data types and indexing features, making it ideal for modern applications.

Integrating PostgreSQL with .NET Aspire enables:
- Scalable and reliable data storage
- Entity Framework Core support
- Full observability and health checks

## 📘 Full Tutorial

Read the full tutorial here:  
🔗 [How to Integrate .NET Aspire with PostgreSQL](https://tutexchange.com/how-to-integrate-net-aspire-with-postgresql/)

### 📚 What You'll Learn:
- Running PostgreSQL using Docker with Aspire
- Configuring Aspire to connect using `builder.AddPostgres(...)`
- Implementing data access using Entity Framework Core
- Applying database migrations and building APIs
- Viewing logs and health checks through Aspire tooling

## 🧰 Tech Stack

- .NET 8 / .NET Aspire
- ASP.NET Core
- PostgreSQL
- Entity Framework Core (Npgsql provider)
- Docker

## 🛠️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Run the Project

```bash
git clone https://github.com/saineshwar/Aspire_postgres.git
cd aspire-postgresql-integration
dotnet run --project AspireApp
