﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace attfire1_assignment2
{
    class MusicClassesContext : DbContext
    {
        public DbSet<Ensemble> Ensemble { get; set; } 
        //public DbSet<Instrument> Instrument { get; set; } 
        //public DbSet<Lesson> Lesson { get; set; } 
        //public DbSet<Location> Location { get; set; } 
        public DbSet<Parent> Parent { get; set; } 
        //public DbSet<Performance> Performance { get; set; } 
        //public DbSet<PerformanceSheetMusic> PerformanceSheetMusic { get; set; } 
        public DbSet<Person> Person { get; set; } 
        public DbSet<PersonSheetMusic> PersonSheetMusic { get; set; } 
        //public DbSet<PositionsHeld> PositionsHeld { get; set; } 
        public DbSet<SheetMusic> SheetMusic { get; set; } 
        public DbSet<Student> Student { get; set; } 
        //public DbSet<StudentLesson> StudentLesson { get; set; } 
        //public DbSet<Tutor> Tutor { get; set; } 
        //public DbSet<TutorPositionsHeld> TutorPositionsHeld { get; set; }
    }

}
