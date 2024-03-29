//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescription
    {
        public int PrescriptionID { get; set; }
        public Nullable<int> DrugID { get; set; }
        public Nullable<int> ScheduleID { get; set; }
        public string PrescriptionDetails { get; set; }
    
        public virtual Drug Drug { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
