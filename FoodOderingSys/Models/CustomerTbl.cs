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

    public partial class CustomerTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerTbl()
        {
            this.OrderTbls = new HashSet<OrderTbl>();
        }
        
        public int CustomerID { get; set; }
        [Required (ErrorMessage ="Empty Field are not Allowed")]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Empty Field are not Allowed")]
        [Display(Name = "Customer Address ")]
        public string CustomerAddress { get; set; }
        [Required(ErrorMessage = "Empty Field are not Allowed")]
        [Display(Name = "Customer Contact ")]
        public string CustomerPhoneNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderTbl> OrderTbls { get; set; }
    }
}
