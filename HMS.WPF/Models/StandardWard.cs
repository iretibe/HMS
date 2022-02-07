namespace HMS.WPF.Models
{
    class StandardWard : Room
    {
       
        public StandardWard() : base(Hospital.Config.StandardWardCapacity, Hospital.Config.StandardWardPrice)
        {
        }
    }
}
