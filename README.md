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

**4. Apply migrations (optional)**

If you use EF migrations, apply them with:

```bash
dotnet ef database update
```
**5. Run the application**