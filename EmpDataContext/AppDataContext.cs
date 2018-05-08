using c_sharp_emp_app.Models;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_emp_app.EmpDataContext
{
    public class AppDataContext : DbContext {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
    
}