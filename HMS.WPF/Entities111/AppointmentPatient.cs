using System;

namespace HMS.WPF.Entities
{
    public class AppointmentPatient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Diagnosis { get; set; }
    }
}
