
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
    
public partial class Records
{

    public int RecordID { get; set; }

    public Nullable<int> GameID { get; set; }

    public Nullable<int> BookID { get; set; }

    public Nullable<int> ShowID { get; set; }

    public string UserID { get; set; }

    public Nullable<bool> Status { get; set; }

    public string Progress { get; set; }



    public virtual AspNetUsers AspNetUser { get; set; }

    public virtual Books Book { get; set; }

    public virtual Games Game { get; set; }

    public virtual Shows Show { get; set; }

}

}
