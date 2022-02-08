//using System;
//using System.Collections.Generic;

//namespace HMS.WPF.Models
//{
//    class AppointmentPatient : Patient
//    {
//        //Member variables
//        private Dictionary<String, Appointment> appointments;
//        public Dictionary<String, Appointment> Appointments { get { return this.appointments; } set { this.appointments = value; } }
        
//        //Constructors
//        public AppointmentPatient() : base()
//        {
//            this.Appointments = new Dictionary<String, Appointment>();
//        }

//        public AppointmentPatient(String name, DateTime birthDate, String address, String diagnosis) : base( name, birthDate, address, diagnosis)
//        {
//            this.Appointments = new Dictionary<String, Appointment>();
//        }
        
//        //Member methods
//        public void addAppointment( Appointment appointment)
//        {
//            if (!Appointments.ContainsKey(appointment.ID)){
//                this.Appointments.Add(appointment.ID, appointment);
//            }
//        }

//        public void removeAppointment(String id)
//        {
//            this.Appointments.Remove(id);
//        }

//        public override double getBill()
//        {
//            Double Bill = 0.0;
//            foreach(Appointment appointment in Appointments.Values)
//            {
//                Bill += appointment.Bill;
//            }

//            return Bill;
//        }
//    }
//}