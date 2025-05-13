using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms;

internal class AppDbContext : DbContext {

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseMySql(
            "server=localhost;database=test;user=root;password=",
            new MariaDbServerVersion(new Version(10, 4, 32)))
            .LogTo(msg => {System.Diagnostics.Debug.WriteLine(msg);}, LogLevel.Information);
    }
}
