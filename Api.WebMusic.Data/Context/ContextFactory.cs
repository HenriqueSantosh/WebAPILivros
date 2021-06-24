using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-EGGHI11\\SQLEXPRESS;Database=ALURATUNES;Trusted_Connection=true;")
                .EnableSensitiveDataLogging();
            return new MyContext(optionsBuilder.Options);
            

        }
    }
}
