using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workday.Models;

    public class WorkdayContext : DbContext
    {
        public WorkdayContext (DbContextOptions<WorkdayContext> options)
            : base(options)
        {
        }

        public DbSet<Workday.Models.Employee> Employee { get; set; }

        public DbSet<Workday.Models.VacationRequest> VacationRequest { get; set; }
    }
