namespace HMS.WPF.Data
{
    class PrivateRoom : Room
    {
        public PrivateRoom() : base(Models.Hospital.Config.PrivateRoomCapacity, Models.Hospital.Config.PrivateRoomPrice)
        {
        }
    }
}
