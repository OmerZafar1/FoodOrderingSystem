//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodOderingSys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeLogin
    {
        public int EmployeeLoginID { get; set; }
       [Required (ErrorMessage ="Empty Field")]
       [EmailAddress]
        public string EmployeeEmail { get; set; }
        [Required(ErrorMessage = "Empty Field")]
        [DataType(DataType.Password)]
        public string EmployeePassword { get; set; }
        public Nullable<int> EmployeeInfoID { get; set; }
    
        public virtual EmployeeTbl EmployeeTbl { get; set; }
    }
}