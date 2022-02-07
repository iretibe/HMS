namespace HMS.WPF.Models
{
    class PrivateRoom : Room
    {
       
        public PrivateRoom() : base(Hospital.Config.PrivateRoomCapacity, Hospital.Config.PrivateRoomPrice)
        {
        }
    }

}
