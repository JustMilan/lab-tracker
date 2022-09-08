using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab_tracker.Models;

namespace lab_tracker.Data
{
    public class lab_trackerContext : DbContext
    {
        public lab_trackerContext (DbContextOptions<lab_trackerContext> options)
            : base(options)
        {
        }

        public DbSet<lab_tracker.Models.Student> Student { get; set; } = default!;

        public DbSet<lab_tracker.Models.Assignment> Assignment { get; set; }

        public DbSet<lab_tracker.Models.AssignmentStudentStatus> AssignmentStudentStatus { get; set; }
    }
}
