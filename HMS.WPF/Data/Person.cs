using System;

namespace HMS.WPF.Data
{
    abstract class Person
    {
        //Member variables
        protected Guid personId { get; set; }
        protected string name { get; set; }
        protected DateTime birthDate { get; set; }
        protected string address { get; set; }

        public string Name 
        { 
            get 
            { 
                return this.name; 
            } 
            set 
            { 
                this.name = value; 
            } 
        }

        public string PersonID 
        { 
            get 
            { 
                return this.PersonID; 
            } 
            set 
            { 
                this.PersonID = value; 
            } 
        }

        public DateTime BirthDate 
        { 
            get 
            { 
                return this.birthDate; 
            } 
            set 
            { 
                this.birthDate = value; 
            } 
        }

        public string Address 
        { 
            get 
            { 
                return this.address; 
            } 
            set 
            { 
                this.address = value; 
            } 
        }

        public int Year 
        { 
            get; 
        }

        public int Age
        {
            get
            {
                return Year - (this.birthDate.Year);
            }
        }

        //Constructors
        public Person()
        {
            this.PersonID = Guid.NewGuid().ToString();
            this.Name = "";
            this.Address = "";
            this.BirthDate = DateTime.Today;
        }

        public Person(string name, DateTime birthDate, string Address)
        {
            this.PersonID = Guid.NewGuid().ToString();
            this.Name = name;
            this.BirthDate = birthDate;
            this.Address = Address;
        }
    }
}
