# 📌 Clean Architecture .NET 9 API

## 📚 Overview
The **Clean Architecture .NET 9 API** is a structured and well-organized example of implementing Clean Architecture using **.NET Core 9**. This project serves as a learning reference for developers who want to understand and implement Clean Architecture using best practices and modern development patterns. 🚀

This repository demonstrates:

👉 **Separation of Concerns (SoC) through Clean Architecture** 🏰  
👉 **Implementation of Code First with Migrations** 🛂  
👉 **Usage of Repository Pattern and Unit of Work** 🔄  
👉 **Automated Testing with xUnit** 🧪  
👉 **Authentication and Authorization with JWT** 🔑   

## 🎼 Screenshots
<p align="center">
  <img src="https://github.com/user-attachments/assets/53ace5f6-274a-4d5e-b38f-e57d689db2f7" alt="Screenshot 2">
</p>

## 🚀 Getting Started

### 📝 Prerequisites
Make sure you have the following installed:
- [.NET Core 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Postman](https://www.postman.com/) (optional, for API testing)

### 🔧 Installation
```bash
# Clone the repository
git clone https://github.com/omatheussribeiro/clean-architecture-template-dotnet.git
cd clean-architecture-template-dotnet
```

### ⚙️ Configuration
Before running the application, configure the **database connection string** in:
- `appsettings.json`
- `appsettings.Development.json`

Example:
```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=localhost\\SQLEXPRESS;Initial Catalog=clean-architecture-dotnet;Integrated Security=True;TrustServerCertificate=True"
}
```

### ▶️ Running the Application
```bash
# Start the API
dotnet run --project clean-architecture-dotnet.Api
```
The application will automatically check if the database and tables exist. If not, they will be created upon execution.

## 🔑 Authentication & Initial Token Usage
To generate an authentication token, use the following credentials in the **login endpoint**:
- **Email:** `usertest@test.com.br`

## 🛠️ Features & Modules
This application includes:

👉 **User Registration (With Address & Contact Info)** 👤  
👉 **Product Management (With Product Types)** 🛂  
👉 **Sales Registration (With Business Rules Applied)** 💰  

## 🛠️ Technologies Used
- **.NET Core 9** 🚀
- **Entity Framework Core (Code First + Migrations)** 🏰
- **SQL Server** 📂
- **AutoMapper** 🔄
- **xUnit (Unit Testing)** 🧪
- **JWT Authentication** 🔑
- **Repository & Service Layer Pattern** 📚

## 📄 License
This project is licensed under the MIT License.
