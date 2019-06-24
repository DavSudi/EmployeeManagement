using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                 new Employee
                 {
                     Id = 1,
                     Name = "Sarah",
                     Department = Dept.HR,
                     Email = "Sarah@thinktech.cd"
                 },
                  new Employee
                  {
                      Id = 2,
                      Name = "Sudi",
                      Department = Dept.IT,
                      Email = "Sudi@thinktech.cd"
                  }
                 );
        }
    }
}
