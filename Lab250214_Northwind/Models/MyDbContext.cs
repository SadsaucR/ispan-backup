using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab250214_Northwind.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }



}
