using System;

namespace HMS.WPF.Data
{
    public class Doctor
    {
        public Guid DoctorID { get; set; }
        public string Name { get; set; }
        public bool IsHead { get; set; }
        public double Salary {get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid DepartmentID { get; set; }
        public DateTime EmploymentDate { get; set; } = DateTime.Now;

        //Navigation property
        public Department Department { get; set; }
    }
}
