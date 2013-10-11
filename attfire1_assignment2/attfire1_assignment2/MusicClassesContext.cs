using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Text;

namespace attfire1_assignment2
{
    class MusicClassesContext : DbContext
    {
        public DbSet<Ensemble> Ensemble { get; set; }
        public DbSet<RepairStatus> RepairStatus { get; set; }
        public DbSet<Instrument> Instrument { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Lesson> Lesson { get; set; } 
        public DbSet<Location> Location { get; set; } 
        //public DbSet<Parent> Parent { get; set; } 
        public DbSet<Performance> Performance { get; set; } 
        //public DbSet<PerformanceSheetMusic> PerformanceSheetMusic { get; set; } 
        public DbSet<Person> Person { get; set; } 
        public DbSet<PersonSheetMusic> PersonSheetMusic { get; set; } 
        public DbSet<PositionsHeld> PositionsHeld { get; set; } 
        public DbSet<SheetMusic> SheetMusic { get; set; } 
        //public DbSet<Student> Student { get; set; } 
        //public DbSet<StudentLesson> StudentLesson { get; set; } 
        public DbSet<Tutor> Tutor { get; set; } 
        public DbSet<TutorPositionsHeld> TutorPositionsHeld { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasRequired(x => x.Parent)
                .WithMany(x => x.Student)
                .HasForeignKey(x => x.ParentParentId)
                .WillCascadeOnDelete(false);

            /*modelBuilder.Entity<Person>()
                .HasKey(t => t.PersonId);
            modelBuilder.Entity<Tutor>()
                .HasRequired(x => x.Person)
                .WithRequiredPrincipal()
                .WillCascadeOnDelete(false);*/
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();   


        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                var innerEx = e.InnerException;

                while (innerEx.InnerException != null)
                    innerEx = innerEx.InnerException;

                throw new Exception(innerEx.Message);
            }
            catch (DbEntityValidationException e)
            {
                var sb = new StringBuilder();

                foreach (var entry in e.EntityValidationErrors)
                {
                    foreach (var error in entry.ValidationErrors)
                    {
                        sb.AppendLine(string.Format("{0}-{1}-{2}",
                            entry.Entry.Entity,
                            error.PropertyName,
                            error.ErrorMessage
                            )
                        );
                    }
                }
                throw new Exception(sb.ToString());
            }
        }
    }

}
