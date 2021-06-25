using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Workday.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WorkdayContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WorkdayContext>>()))
            {
                if (context.Employee.Any())
                {

                    if (!context.VacationRequest.Any())
                    {
                        context.VacationRequest.AddRange(
                    new VacationRequest
                    {
                        Name = "Przemek Frankowski",
                        DateOfRequest = DateTime.Parse("2021-06-25"),
                        From = DateTime.Parse("2021-06-26"),
                        To = DateTime.Parse("2021-06-28"),
                        status = false
                    },
                    new VacationRequest
                    {
                        Name = "Marcin Kamiński",
                        DateOfRequest = DateTime.Parse("2021-06-25"),
                        From = DateTime.Parse("2021-06-26"),
                        To = DateTime.Parse("2021-06-30"),
                        status = false
                    }
                );
                        context.SaveChanges();

                    }
                    return;
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        Name = "Marcin Kamiński",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Position = "Java Developer",
                        Salary = 10000,
                        PersonalId = 98120200000
                    },

                    new Employee
                    {
                        Name = "Tomek Leśniak",
                        DateOfBirth = DateTime.Parse("1996-2-12"),
                        Position = "Senior Java Developer",
                        Salary = 15000,
                        PersonalId = 96120200000
                    },

                    new Employee
                    {
                        Name = "Paweł Domagalski",
                        DateOfBirth = DateTime.Parse("1988-2-12"),
                        Position = "Team Leader",
                        Salary = 12000,
                        PersonalId = 88120200000
                    },

                    new Employee
                    {
                        Name = "Przemek Frankowski",
                        DateOfBirth = DateTime.Parse("1977-2-12"),
                        Position = "Scrum Master",
                        Salary = 10000,
                        PersonalId = 77120200000
                    }
                );

                context.SaveChanges();
            }
        }
    }
}