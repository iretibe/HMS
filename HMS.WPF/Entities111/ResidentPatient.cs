using System;

namespace HMS.WPF.Entities
{
    public class ResidentPatient
    {
        public Guid ResidentPatientID { get; set; }
        public Guid RoomID { get; set; }
        public DateTime? EntryDate { get; set; } = DateTime.Now;
        public string History { get; set; }
        public Guid DepartmentID { get; set; }
    }
}
