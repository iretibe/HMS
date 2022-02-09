using System;
using System.Collections.Generic;

namespace HMS.WPF.Data
{
    class ResidentPatient : Patient
    {
        //Member variables
        private Room room;
        private Dictionary<string, Medicine> history;
        private DateTime entryDate;
        private Department department;

        public Room Room 
        { 
            get 
            { 
                return this.room; 
            } 
            set 
            { 
                this.room = value; 
            } 
        }

        public Dictionary<string, Medicine> History 
        { 
            get 
            { 
                return this.history; 
            } 
            set 
            { 
                this.history = value; 
            } 
        }

        public DateTime EntryDate 
        { 
            get 
            { 
                return this.entryDate; 
            } 
            set 
            { 
                this.entryDate = value; 
            } 
        }

        public Department Department 
        { 
            get 
            { 
                return this.department; 
            } 
            set 
            { 
                this.department = value;
            } 
        }

        public ResidentPatient() : base()
        {
            this.entryDate = DateTime.Now;
            this.History = new Dictionary<string, Medicine>();
        }

        public ResidentPatient(string name, DateTime birthDate, string address, string diagnosis, Room room, Department department) : base(name, birthDate, address, diagnosis)
        {
            this.Room = room;
            this.EntryDate = DateTime.Now;
            this.History = new Dictionary<string, Medicine>();
            this.Department = department;
        }

        //Member methods
        public void addMedicine(Medicine medicine)
        {
            if (!History.ContainsKey(medicine.MedecineID))
                this.history.Add(medicine.MedecineID, medicine);
        }

        public override double getBill()
        {
            if (Room == null) return 0;
            double bill = ((DateTime.Now - EntryDate).Days * Room.Price);
            return bill;
        }
    }
}
