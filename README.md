# 🦅 Eagle Project

Eagle is a **ASP.NET Core MVC application** that provides authentication, user management, and extendable modules for building secure web solutions. It is structured using **ASP.NET Identity**, Razor Pages, and Entity Framework Core.

## 🚀 Features

- ✅ User registration & authentication
- ✅ Email confirmation & password reset
- ✅ Role-based access control
- ✅ Two-factor authentication (2FA)
- ✅ ASP.NET Identity integration
- ✅ Configurable via `appsettings.json`
- ✅ Modular architecture for scalability

## 🛠 Tech Stack

- **Framework**: .NET 6 / .NET Core MVC
- **Frontend**: Razor Pages, Bootstrap
- **Backend**: ASP.NET Core
- **Database**: Entity Framework Core (SQL Server by default)
- **Authentication**: ASP.NET Core Identity
- **Configuration**: JSON-based (`appsettings.json`)
- **IDE**: Visual Studio 2022 / JetBrains Rider

## 📂 Project Structure

```
Eagle/
├── Areas/
│   └── Identity/                # ASP.NET Identity pages
│       └── Pages/
│           └── Account/         # Login, Register, ForgotPassword, etc.
│               ├── Login.cshtml
│               ├── Register.cshtml
│               ├── ForgotPassword.cshtml
│               └── ...
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
├── Controllers/                 # MVC Controllers
├── Models/                      # Data models and ViewModels
├── Views/                       # Razor views
│   ├── Shared/
│   └── Home/
├── wwwroot/                     # Static files (CSS, JS, images)
├── Data/                        # DbContext and database configurations
├── appsettings.json             # Main configuration file
├── appsettings.Development.json # Development configuration
├── Program.cs                   # Application entry point
├── Eagle.csproj                 # Project file
├── Eagle.sln                    # Solution file
└── ScaffoldingReadMe.txt        # EF Core scaffolding notes
```

## ⚙️ Installation & Setup

### 1️⃣ Prerequisites

Make sure you have the following installed:
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB or full installation)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### 2️⃣ Clone the Repository

```markdown
git clone https://github.com/yourusername/Eagle.git
cd Eagle
```

### 3️⃣ Install Dependencies

```markdown
dotnet restore
```

### 4️⃣ Configure Database

Update your **connection string** in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EagleDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

For SQL Server, use:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=EagleDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

### 5️⃣ Apply Migrations

```markdown
dotnet ef database update
```

If you don't have EF Core tools installed:
```markdown
dotnet tool install --global dotnet-ef
```

### 6️⃣ Run the Project

```markdown
dotnet run
```

Open your browser and navigate to:
- **HTTPS**: `https://localhost:5001`
- **HTTP**: `http://localhost:5000`

## 🔧 Configuration

### Main Configuration Files

- **`appsettings.json`** - Main configuration (Database, Logging, Identity)
- **`appsettings.Development.json`** - Development-specific settings
- **`Program.cs`** - Configures services (Identity, EF Core, MVC)

### Identity Configuration

The project uses ASP.NET Core Identity with the following default settings:

```json
{
  "Identity": {
    "RequireConfirmedEmail": false,
    "RequireUniqueEmail": true,
    "Password": {
      "RequiredLength": 6,
      "RequireNonAlphanumeric": false,
      "RequireDigit": false,
      "RequireUppercase": false
    }
  }
}
```

### Email Configuration (Optional)

For email functionality (password reset, email confirmation), configure SMTP in `appsettings.json`:

```json
{
  "EmailSettings": {
    "SmtpServer": "smtp.gmail.com",
    "SmtpPort": 587,
    "FromEmail": "noreply@yourdomain.com",
    "FromName": "Eagle App",
    "Username": "your-email@gmail.com",
    "Password": "your-app-password"
  }
}
```

## 🔑 Authentication & Identity

The project comes with a **complete ASP.NET Identity setup**:

### Available Features
- **User Registration** - Create new user accounts
- **Login/Logout** - Secure authentication
- **Password Recovery** - Email-based password reset
- **Email Verification** - Confirm user email addresses
- **Two-Factor Authentication** - Enhanced security
- **Role Management** - Admin and user roles
- **Account Management** - Profile editing, password changes

### Identity Pages Location
```
Areas/Identity/Pages/Account/
├── Login.cshtml
├── Register.cshtml
├── ForgotPassword.cshtml
├── ResetPassword.cshtml
├── ConfirmEmail.cshtml
├── Manage/
│   ├── Index.cshtml
│   ├── ChangePassword.cshtml
│   └── TwoFactorAuthentication.cshtml
└── ...
```

### Default Admin Account

After running migrations, you can create an admin account using the following steps:

1. Register a new account through the web interface
2. Update the user role in the database
3. Or implement seeding in `Program.cs`

## 🚀 Running in Production

### 1. Update Configuration

Create `appsettings.Production.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your-Production-Connection-String"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  }
}
```

### 2. Publish the Application

```markdown
dotnet publish -c Release -o ./publish
```

### 3. Deploy to IIS/Azure/Docker

Follow the standard ASP.NET Core deployment guidelines for your hosting platform.

## 🧪 Testing

Run the test suite (if available):

```markdown
dotnet test
```

## 📚 API Documentation

If the project includes API endpoints, they will be available at:
- **Swagger UI**: `https://localhost:5001/swagger` (Development only)

## 🛠 Development

### Adding New Features

1. **Controllers**: Add new controllers in the `Controllers/` folder
2. **Models**: Create models in the `Models/` folder
3. **Views**: Add corresponding Razor views in `Views/`
4. **Database Changes**: Create and apply EF Core migrations

### Database Migrations

Create a new migration:
```markdown
dotnet ef migrations add MigrationName
```

Apply migrations:
```markdown
dotnet ef database update
```

Remove last migration:
```markdown
dotnet ef migrations remove
```

## 🤝 Contributing

1. **Fork** the repository
2. Create a **feature branch** (`git checkout -b feature/amazing-feature`)
3. **Commit** your changes (`git commit -m 'Add some amazing feature'`)
4. **Push** to the branch (`git push origin feature/amazing-feature`)
5. Open a **Pull Request**

### Development Guidelines

- Follow C# coding conventions
- Write unit tests for new features
- Update documentation as needed
- Ensure all tests pass before submitting PR

## 📝 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- **ASP.NET Core Team** - For the amazing framework
- **Microsoft Identity** - For robust authentication
- **Entity Framework Core** - For seamless data access
- **Bootstrap** - For responsive UI components

---
![image](https://github.com/user-attachments/assets/f135c669-84f7-4acb-adbd-b98d82edaec8)

---

![{691E9BE0-C3CB-4F65-BE3D-D5654391FC6D}](https://github.com/user-attachments/assets/b2c6d048-757d-4e93-8550-5d273f45eb71)
