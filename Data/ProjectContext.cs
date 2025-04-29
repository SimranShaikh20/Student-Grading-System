using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

       
        public DbSet<Project.Models.Register> Register { get; set; } = default!;
        public DbSet<Project.Models.FacultyRegistration> FacultyRegistration { get; set; } = default!;
        public DbSet<Project.Models.Assignment> Assignments { get; set; } = default;

        public DbSet<Project.Models.StudentAssShow> StudentAssShow { get; set; } = default;
        public DbSet<Project.Models.Submission> Submission{ get; set; } = default;
        public DbSet<Project.Models.LoginData> LoginData { get; set; } = default!;

    }
}
