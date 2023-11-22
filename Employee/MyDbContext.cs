using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee
{
    public class MyDbContext : DbContext
    {
        public MyDbContext():base("name= Constr")
        { }
        public virtual DbSet<Department> Departments { get; set; } 
        public virtual DbSet<Emp> Emps { get; set; }    
        public virtual DbSet<EmployeeAddress> EmpsAddresses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Dept");
            modelBuilder.Entity<Department>().HasKey(d => d.DeptId);
            modelBuilder.Entity<Emp>().Property(e => e.EmpId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Emp>().Property(e => e.EmpName).HasColumnName("EName")
                                                             .IsRequired()
                                                              .HasMaxLength(100)
                                                            .HasColumnType("varchar");
            modelBuilder.Entity<Emp>().Property(e => e.PrimaryContact)
                                                .IsRequired()
                                                .HasMaxLength(10);
            modelBuilder.Entity<EmployeeAddress>().HasKey(ea=> ea.EmpId);
            //one to one RelationShip
            modelBuilder.Entity<Emp>().HasOptional(e => e.EmployeeAddress)
                                                   .WithRequired(ea => ea.Emp);
            //one to many relationship
            modelBuilder.Entity<Department>().HasMany(d => d.Employees)
                                              .WithRequired(e => e.Department)
                                              .HasForeignKey(e => e.DeptId);
            //one to mant relationship between team and  Employee [Nullable Foreign key]
            modelBuilder.Entity<Team>().HasMany(t => t.Emps)
                                        .WithOptional(e => e.Team)
                                        .HasForeignKey(e => e.TeamId);
            //Many to many relationship
            modelBuilder.Entity<Emp>().HasMany(e => e.Projects)
                                      .WithMany(p => p.Emps)
                                      .Map(ep =>
                                      {
                                          ep.MapLeftKey("EmployeeId");
                                          ep.MapRightKey("ProjectId");
                                          ep.ToTable("ProjectOfEmployee");


                                      });
                                               


        }


    }
}
