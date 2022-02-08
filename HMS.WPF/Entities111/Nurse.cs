using System;

namespace HMS.WPF.Entities
{
    public class Nurse
    {
        public Guid NurseID { get; set; }
        public Guid RoomID { get; set; }
        public Guid PatientID { get; set; }
    }
}
