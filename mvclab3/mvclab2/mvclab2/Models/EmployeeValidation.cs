using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvclab2.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
        [Bind(Exclude = "EmployeeID")]
        public class EmployeeMetaData
        {
            [ScaffoldColumn(false)]
            public int EmployeeID { get; set; }

            [DisplayName("Name")]
            [Required(ErrorMessage = "Employee name is required.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string Name { get; set; }

            [DisplayName("Position")]
            [Required(ErrorMessage = "Position is required.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string Position { get; set; }
        }
    }
}
