using System;

namespace HMS.WPF.Entities
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public Guid DoctorID { get; set; }
        public Guid PatientID { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public double Bill { get; set; }
    }
}
