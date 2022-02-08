using System;

namespace HMS.WPF.Entities
{
    public class Person
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected DateTime BirthDate { get; set; }
        protected string Address { get; set; }
    }
}
