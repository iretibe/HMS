using System;

namespace HMS.WPF.Data
{
    class Medicine
    {
        private string medecineId;
        private string name;
        private DateTime startingDate;
        private DateTime endingDate;

        //Getters & setters
        public string MedecineID 
        { 
            get 
            { 
                return this.MedecineID; 
            } 
            set 
            { 
                this.MedecineID = value; 
            } 
        }

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

        public DateTime StartingDate 
        { 
            get 
            { 
                return this.startingDate; 
            } 
            set 
            { 
                this.startingDate = value; 
            } 
        }

        public DateTime EndingDate 
        { 
            get 
            { 
                return this.endingDate; 
            } 
            set 
            { 
                this.endingDate = value; 
            } 
        }

        //Constructors
        public Medicine()
        {
            this.MedecineID = Guid.NewGuid().ToString();
            this.Name = "";
            this.StartingDate = DateTime.Today;
            this.StartingDate = DateTime.Today;
        }

        public Medicine(string name, DateTime startingDate, DateTime endingDate)
        {
            this.MedecineID = Guid.NewGuid().ToString();
            this.Name = name;
            this.StartingDate = startingDate;
            this.EndingDate = endingDate;
        }
    }
}
