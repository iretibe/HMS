using HMS.WPF.Models;

namespace HMS.WPF.Data
{
    class StandardWard : Room
    {
        public StandardWard() : base(Hospital.Config.StandardWardCapacity, Hospital.Config.StandardWardPrice)
        {
        }
    }
}
