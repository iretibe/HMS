using System;

namespace HMS.WPF.Data
{
    public class Appointment
    {
        public Guid AppointmentID { get; set; }
        public DateTime Date { get; set; }        
        public int Duration { get; set; }
        public decimal Bill { get; set; }

        //Foreign Key
        public Guid DoctorID { get; set; }
        public Guid PatientID { get; set; }

        //Navigation property
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
