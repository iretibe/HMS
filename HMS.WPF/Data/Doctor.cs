using System;
using System.Collections.Generic;
using System.Linq;

namespace HMS.WPF.Data
{
    public class Doctor : Employee
    {
        private bool isHead;
        private Dictionary<string, Patient> patients;
        private Dictionary<string, Appointment> appointments;

        public bool IsHead 
        { 
            get 
            { 
                return this.IsHead; 
            } 
            
            set 
            { 
                this.IsHead = value; 
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

        public Dictionary<string, Appointment> Appointments 
        { 
            get 
            { 
                return this.appointments; 
            } 
            
            set 
            { 
                this.appointments = value; 
            } 
        }

        public Doctor()
        {
            this.IsHead = false;
            this.Patients = new Dictionary<string, Patient>();
            this.Appointments = new Dictionary<string, Appointment>();
        }

        public Doctor(bool ishead, double salary, Department department) : base(salary, department)
        {
            this.IsHead = ishead;
            this.Patients = new Dictionary<string, Patient>();
            this.Appointments = new Dictionary<string, Appointment>();
        }

        public void addPatient(Patient patient)
        {
            if (!Patients.ContainsKey(patient.PersonID.ToString()))
                this.Patients.Add(patient.PersonID.ToString(), patient);
        }

        public void removePatient(String id)
        {
            this.Patients.Remove(id);
        }

        public void addAppointment(Appointment appointment)
        {
            if (!Appointments.ContainsKey(appointment.AppointmentID.ToString()))
                this.Appointments.Add(appointment.AppointmentID.ToString(), appointment);
        }

        public void removeAppointment(string id)
        {
            this.Appointments.Remove(id);
        }

        public bool isAvailable(Appointment newAppointment)
        {
            List<Appointment> apps = new List<Appointment>(Appointments.Values);
            apps.Add(newAppointment);

            DateTime curEnd = DateTime.MinValue;
            foreach (Appointment app in apps.OrderBy(app => app.Date))
            {
                if (app.Date < curEnd)
                    return false;

                curEnd = app.Date.AddMinutes(app.Duration);
            }

            return true;
        }
    }
}
