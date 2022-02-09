using System;

namespace HMS.WPF.Data
{
    public class Appointment
    {
        public Guid AppointmentID { get; set; }
        public DateTime Date { get; set; }        
        public int Duration { get; set; }
        public double Bill { get; set; }

        //Foreign Key
        public Guid DoctorID { get; set; }
        public Guid PatientID { get; set; }

        //Navigation property
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        //Getters & setters
        public String AppointmentIDll { get { return this.id; } set { this.id = value; } }
        public Doctor Doctor { get { return this.doctor; } set { this.doctor = value; } }
        public AppointmentPatient Patient { get { return this.patient; } set { this.patient = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public int Duration { get { return this.duration; } set { this.duration = value; } }
        public double Bill { get { return ((double)duration / 60) * Hospital.Config.AppointmentHourPrice; } set { this.bill = value; } }
        
        
        //Constructors
        public Appointment()
        {
            this.ID = Guid.NewGuid().ToString();
            this.Doctor = new Doctor();
            this.Patient = new AppointmentPatient();
            this.Date = new DateTime();
            this.Duration = 0;
        }

        public Appointment(Doctor doctor, AppointmentPatient patient, DateTime date, int duration)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Doctor = doctor;
            this.Patient = patient;
            this.Date = date;
            this.Duration = duration;
        }

        public void cancel()
        {
            this.Doctor.removeAppointment(this.ID);
            this.Patient.removeAppointment(this.ID);
        }
    }
}
