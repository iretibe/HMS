using System;

namespace HMS.WPF.Data
{
    public class ResidentPatient
    {
        public Guid ResidentPatientID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Diagnosis { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public DateTime? EntryDate { get; set; } = DateTime.Now;

        //Navigation property
        public Department Department { get; set; }
        public Room Room { get; set; }
    }
}
