using HMS.WPF.Models;

namespace HMS.WPF.Data
{
    class SemiPrivateRoom : Room
    {
        public SemiPrivateRoom() : base(Hospital.Config.SemiPrivateRoomCapacity, Hospital.Config.SemiPrivateRoomPrice)
        {
        }
    }
}
