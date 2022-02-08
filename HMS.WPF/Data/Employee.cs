using System;

namespace HMS.WPF.Data
{
    public class Employee
    {
        public Guid Id { get; set; }
        public double Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
        public Guid DepartmentID { get; set; }
    }
}
