//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Brand3
    {
        public Brand3()
        {
            this.product2 = new HashSet<product2>();
        }
    
        public int id { get; set; }
        public string Brand_Name { get; set; }
    
        public virtual ICollection<product2> product2 { get; set; }
    }
}
