using System;
using System.Collections.Generic;

namespace HMS.WPF.Data
{
    class Department
    {
        private string departmentId;
        private string name;
        private string headID;
        private Dictionary<string, Doctor> doctors;
        private Dictionary<string, Nurse> nurse;
        private Dictionary<string, Patient> patients;

        public string DepartmentID 
        { 
            get 
            { 
                return this.DepartmentID; 
            } 
            set 
            { 
                this.DepartmentID = value; 
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
        
        public string HeadID 
        { 
            get 
            { 
                return this.headID; 
            } 
            set 
            { 
                this.headID = value; 
            } 
        }
        
        public Dictionary<string, Doctor> Doctors 
        { 
            get 
            { 
                return this.doctors; 
            } 
            set 
            { 
                this.doctors = value; 
            } 
        }
        
        public Dictionary<string, Nurse> Nurse 
        { 
            get 
            { 
                return this.nurse; 
            } 
            set 
            { 
                this.nurse = value; 
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

        public Department()
        {
            this.DepartmentID = Guid.NewGuid().ToString();
            this.Name = "";
            this.HeadID = "";
            this.Doctors = new Dictionary<String, Doctor>();
            this.Nurse = new Dictionary<String, Nurse>();
            this.Patients = new Dictionary<String, Patient>();
        }

        public void addDoctor(Doctor doctor)
        {
            if (!Doctors.ContainsKey(doctor.PersonID))
                this.Doctors.Add(doctor.PersonID, doctor);
        }

        public void removeDoctor(String doctorID)
        {
            this.Doctors.Remove(doctorID);
        }

        public void addNurse(Nurse nurse)
        {
            if (!Nurse.ContainsKey(nurse.PersonID))
                this.Nurse.Add(nurse.PersonID, nurse);
        }

        public void removeNurse(String nurseID)
        {
            this.Nurse.Remove(nurseID);
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
    }
}
