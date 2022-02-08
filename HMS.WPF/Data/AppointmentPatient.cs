using System;

namespace HMS.WPF.Data
{
    public class AppointmentPatient
    {
        public Guid AppointmentPatientID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Address { get; set; }
        public string Diagnosis { get; set; }
    }
}
