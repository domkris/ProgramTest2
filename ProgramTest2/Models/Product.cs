//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramTest2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter name")]
        [MaxLength(100), MinLength(1)]
        public string Name { get; set; }
        public Nullable<double> Price { get; set; }
        [Required(ErrorMessage = "Choose category ")]
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
