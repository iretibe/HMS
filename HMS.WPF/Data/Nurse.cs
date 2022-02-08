using System;

namespace HMS.WPF.Data
{
    public class Nurse
    {
        public Guid NurseID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> EmploymentDate { get; set; }
        public Nullable<System.Guid> DepartmentID { get; set; }
        public Nullable<decimal> Salary { get; set; }

        //Navigation property
        public Department Department { get; set; }
    }
}
