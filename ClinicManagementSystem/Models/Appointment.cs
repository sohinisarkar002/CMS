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
    
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int AppointmentID { get; set; }
        public System.DateTime AppointmentDateTime { get; set; }
        public string AppointmentReason { get; set; }
        public string AppointmentStatus { get; set; }
        public Nullable<int> PhysicianID { get; set; }
        public Nullable<int> PatientID { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Physician Physician { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
