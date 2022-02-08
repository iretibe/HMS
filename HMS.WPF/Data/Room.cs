using System;

namespace HMS.WPF.Data
{
    public class Room
    {
        public Guid Id{get; set; }
        public int RoomNumber{get; set; }
        public Guid PatientID{get; set; }
        public Guid NurseID {get; set; }
        public int capacity{get; set; }
        public double price{get; set; }
    }
}
