using System.Collections.Generic;

namespace HMS.WPF.Data
{
    class Nurse : Employee
    {
        private Dictionary<string, Room> rooms;
        private Dictionary<string, Patient> patients;

        public Dictionary<string, Room> Rooms 
        { 
            get 
            { 
                return this.rooms; 
            } 
            set 
            { 
                this.rooms = value; 
            } 
        }

        public Dictionary<string, Patient> Patients 
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

        public Nurse()
        {
            Rooms = new Dictionary<string, Room>();
            Patients = new Dictionary<string, Patient>();
        }

        public void addRoom(Room room)
        {
            if (!Rooms.ContainsKey(room.RoomID))
                this.Rooms.Add(room.RoomID, room);
        }

        public void removeRoom(string id)
        {
            this.Rooms.Remove(id);
        }

        public void addPatient(Patient patient)
        {
            if (!Patients.ContainsKey(patient.PersonID))
                this.Patients.Add(patient.PersonID, patient);
        }

        public void removePatient(string id)
        {
            this.Patients.Remove(id);
        }
    }
}
