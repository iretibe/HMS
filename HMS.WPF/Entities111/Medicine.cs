using System;

namespace HMS.WPF.Entities
{
    public class Medicine
    {
        private Guid Id { get; set; }
        private string name { get; set; }
        private DateTime startingDate { get; set; }
        private DateTime endingDate { get; set; }
    }
}
