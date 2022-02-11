using System;
using System.Collections.Generic;

namespace HMS.WPF.Data
{
    class AppointmentPatient : Patient
    {
        //Member variables
        private Dictionary<string, Appointment> appointments;
        
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

        //Constructors
        public AppointmentPatient() : base()
        {
            this.Appointments = new Dictionary<string, Appointment>();
        }

        public AppointmentPatient(string name, DateTime birthDate, string address, string diagnosis) : base(name, birthDate, address, diagnosis)
        {
            this.Appointments = new Dictionary<String, Appointment>();
        }

        //Member methods
        public void addAppointment(Appointment appointment)
        {
            if (!Appointments.ContainsKey(appointment.AppointmentID.ToString()))
            {
                this.Appointments.Add(appointment.AppointmentID.ToString(), appointment);
            }
        }

        public void removeAppointment(string id)
        {
            this.Appointments.Remove(id);
        }

        public override double getBill()
        {
            Double Bill = 0.0;

            foreach (Appointment appointment in Appointments.Values)
            {
                Bill += appointment.Bill;
            }

            return Bill;
        }
    }
}
