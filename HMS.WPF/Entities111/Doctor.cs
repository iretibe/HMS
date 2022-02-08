using System;

namespace HMS.WPF.Entities
{
    public class Doctor
    {
        public Guid DoctorID { get; set; }
        public bool ishead { get; set; }
        public double salary {get; set; }
        public Guid DepartmentID { get; set; }
    }
}
