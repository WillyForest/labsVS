//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab7v2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Duties
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Duties()
        {
            this.Employee = new HashSet<Employee>();
        }
    
        public int DutiesId { get; set; }
        public int DcPositionId { get; set; }
        public Nullable<int> DcSubdivisionId { get; set; }
    
        public virtual DcPosition DcPosition { get; set; }
        public virtual DcSubdivision DcSubdivision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}