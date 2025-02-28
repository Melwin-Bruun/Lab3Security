# Lab3Security

## About

Lab3Security is an ASP.NET Core web application that provides security-related functionality, including authentication and role management. It utilizes ASP.NET Core Identity for user authentication and authorization.

## Features

- **User Registration & Login**: Users can sign up and log in using an email or username.
- **Two-Factor Authentication (2FA)**: Adds an extra layer of security using authenticator apps.
- **Role Management**: Admins can create, edit, remove roles, and assign them to users.
- **Profile Management**: Users can update their profiles, including profile picture uploads.
- **Email Confirmation & Password Reset**: Users receive verification emails and can reset their passwords.
- **Driving License Claim Enforcement**: Demonstrates policy-based access control using a "Korkort" claim.

## Prerequisites

- **.NET 9 SDK**
- **SQL Server** or another compatible database provider
- **Optional**: Visual Studio 2022 or Visual Studio Code for development

## Getting Started

### Clone the repository:

```sh
git clone https://github.com/Victor19941221/Lab3.git
cd Lab3Security
```

### Check .gitignore and appsettings.json
Ensure sensitive data (such as connection strings, passwords, and API keys) are not checked into source control. Use user secrets or environment variables for local development.

## Configuration

### Connection Strings
Update the `ConnectionStrings:DefaultConnection` value in `appsettings.json` or `appsettings.Development.json`.

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=YourDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### Email Settings
The application uses an `IEmailSender` implementation. Update credentials in `EmailSender.cs` or use environment variables. Replace placeholder credentials with your own SMTP service credentials.

## Running the Application

### Restore and Build:
```sh
dotnet restore
dotnet build
```

### Apply Migrations:
```sh
dotnet ef database update
```

### Run the application:
```sh
dotnet run
```

The application will be available at `https://localhost:5001` or `http://localhost:5000` by default (depending on launch settings).

## Database Setup

The project uses **Entity Framework Core Migrations** to manage the database schema.

### Create a new migration if needed:
```sh
dotnet ef migrations add InitialCreate
```

### Apply migrations to your local database:
```sh
dotnet ef database update
```

## Additional Information

- **Roles Initialization**: The application automatically seeds roles (Admin and User) via database migrations.
- **Admin User**: An admin user is seeded into the database. Check the migrations for details.

## Project Structure

```
Lab3Security/
│── Areas/                # Authentication and role management
│── Data/                 # Database-related files
│── Model/                # Data models
│── Pages/                # Razor Pages for UI
│── wwwroot/              # Static web assets
│── Program.cs            # Application entry point
│── appsettings.json      # Configuration file
│── Lab3Security.sln      # Visual Studio solution file
```


