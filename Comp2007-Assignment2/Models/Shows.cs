//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comp2007_Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shows
    {
        public Shows()
        {
            this.Records = new HashSet<Records>();
        }
    
        public int ShowID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string AltName { get; set; }
        public string Length { get; set; }
    
        public virtual ICollection<Records> Records { get; set; }
    }
}
