//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject_1933112.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Building
    {
        public int BuildingID { get; set; }
        public int nbAppartments { get; set; }
        public int AppartmentID { get; set; }
        public int ManagerID { get; set; }
    
        public virtual Appartment Appartment { get; set; }
        public virtual Manager Manager { get; set; }
    }
}