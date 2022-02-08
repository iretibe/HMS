using System;

namespace HMS.WPF.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid HeadID { get; set; }
        public Guid DoctorID { get; set; }
        public Guid NurseID { get; set; }
        public Guid PatientID { get; set; }
    }
}
