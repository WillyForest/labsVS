//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Exam = new HashSet<Exam>();
        }
    
        public int StudentId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime Birthday { get; set; }
        public string RecordBook { get; set; }
        public string BirthdayCity { get; set; }
        public int StudyGroupId { get; set; }
        public Nullable<decimal> Stipendia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exam { get; set; }
        public virtual StudyGroup StudyGroup { get; set; }
    }
}
