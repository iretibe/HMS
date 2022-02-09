using System;
using System.Collections.Generic;

namespace HMS.WPF.Data
{
    abstract class Room
    {
        protected string roomId;
        protected int roomNumber;
        protected Dictionary<String, Patient> patients;
        protected Dictionary<String, Nurse> nurses;
        protected int capacity;
        protected double price;

        public string RoomID 
        { 
            get 
            { 
                return this.RoomID; 
            } 
            set 
            { 
                this.RoomID = value; 
            } 
        }

        public int RoomNumber 
        { 
            get 
            { 
                return this.roomNumber; 
            } 
            set 
            { 
                this.roomNumber = value; 
            } 
        }

        public Dictionary<String, Patient> Patients 
        { 
            get 
            { 
                return this.patients; 
            } 
            set 
            { 
                this.patients = value; 
            } 
        }

        public Dictionary<String, Nurse> Nurses 
        { 
            get 
            { 
                return this.nurses; 
            } 
            set 
            { 
                this.nurses = value; 
            } 
        }

        public int Capacity 
        { 
            get 
            { 
                return this.capacity; 
            } 
            set 
            { 
                this.capacity = value; 
            } 
        }

        public double Price 
        { 
            get 
            { 
                return this.price; 
            } 
            set 
            { 
                this.price = value; 
            } 
        }

        //Constructors
        public Room()
        {
            this.RoomID = Guid.NewGuid().ToString();
            this.Capacity = 0;
            this.Price = 0;
            this.Patients = new Dictionary<String, Patient>();
            this.Nurses = new Dictionary<String, Nurse>();
        }

        public Room(int capacity, double price)
        {
            this.RoomID = Guid.NewGuid().ToString();
            this.Capacity = capacity;
            this.Price = price;
            this.Patients = new Dictionary<String, Patient>();
            this.Nurses = new Dictionary<String, Nurse>();
        }

        public void addPatient(Patient patient)
        {
            if (!Patients.ContainsKey(patient.PersonID))
                this.Patients.Add(patient.PersonID, patient);
        }
        public void removePatient(String patientID)
        {
            this.Patients.Remove(patientID);
        }

        public void addNurse(Nurse nurse)
        {
            if (!Nurses.ContainsKey(nurse.PersonID))
                this.Nurses.Add(nurse.PersonID, nurse);
        }

        public void removeNurse(String nurseID)
        {
            this.Nurses.Remove(nurseID);
        }

        public bool hasAvailableBed()
        {
            return (Capacity - Patients.Count) > 0;
        }
    }
}
