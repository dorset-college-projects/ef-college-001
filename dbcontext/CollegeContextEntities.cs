using EFDotNet001.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDotNet001.dbcontext
{
    public partial class CollegeContextEntities : DbContext
    {
        public CollegeContextEntities() : base("name = CollegeContextEntities") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
