# User Management App

A simple Windows Forms application for managing a list of users with basic CRUD operations. Built with C# and Entity Framework Core.

---

## Features

- Add, edit, and delete users
- Filter users by first or last name
- Persist data using MySQL
- Real-time validation and error handling
- Clean separation using `BindingList`, `DbContext`, and `DataGridView`

---

##  Getting Started

### Requirements

- .NET 8 or later
- Visual Studio 2022 or later

### Setup

**1. Clone the repository**
   ```bash
   git clone https://github.com/vlastislavnovak/DataGridViewExample.git
   ```
**2. Open the solution in Visual Studio**

**3. Set your database provider**

In AppDbContext.cs, configure connection to SQL Server.

**4. Install dependencies**

If needed, restore NuGet packages:
   ```bash
   dotnet restore
   ```
   You may need to install EF Core tools:
   ```bash
   dotnet tool install dotnet-ef --create-manifest-if-needed
   ```
   
**5. Apply migrations (optional)**

Ensure your database is created and migrations are applied:

```bash
dotnet ef database update
```
**6. Run the application**