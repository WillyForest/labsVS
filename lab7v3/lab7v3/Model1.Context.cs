﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab7v3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Laba2_1Entities : DbContext
    {
        public Laba2_1Entities()
            : base("name=Laba2_1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DcDiscipline> DcDiscipline { get; set; }
        public virtual DbSet<DcPosition> DcPosition { get; set; }
        public virtual DbSet<DcSubdivision> DcSubdivision { get; set; }
        public virtual DbSet<Duties> Duties { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudyGroup> StudyGroup { get; set; }
    }
}
