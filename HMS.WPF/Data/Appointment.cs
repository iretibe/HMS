using System;

namespace HMS.WPF.Data
{
    public class Appointment
    {
        private string appointmentId;
        private Doctor doctor;
        private AppointmentPatient patient;
        private DateTime date;
        private int duration;
        private double bill;

        //Foreign Key
        public Guid DoctorID { get; set; }
        public Guid PatientID { get; set; }

        //Navigation property
        public Guid AppointmentID
        {
            get
            {
                return this.AppointmentID;
            }
            set
            {
                this.AppointmentID = value;
            }
        }

        public Doctor Doctor 
        {
            get 
            {
                return this.Doctor;
            }
            set 
            {
                this.Doctor = value;
            } 
        }

        public AppointmentPatient Patient
        {
            get
            {
                return this.Patient;
            }
            set
            {
                this.Patient = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.Date;
            }
            set
            {
                this.Date = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.Duration;
            }
            set
            {
                this.Duration = value;
            }
        }

        public double Bill
        {
            get
            {
                return this.Bill;
            }
            set
            {
                this.Bill = value;
            }
        }
                
        //Constructors
        public Appointment()
        {
            this.AppointmentID = Guid.NewGuid();
            this.Doctor = new Doctor();
            this.Patient = new AppointmentPatient();
            this.Date = new DateTime();
            this.Duration = 0;
        }

        public Appointment(Doctor doctor, AppointmentPatient patient, DateTime date, int duration)
        {
            this.AppointmentID = Guid.NewGuid();
            this.Doctor = doctor;
            this.Patient = patient;
            this.Date = date;
            this.Duration = duration;
        }

        public void cancel()
        {
            this.Doctor.removeAppointment(this.AppointmentID.ToString());
            this.Patient.removeAppointment(this.AppointmentID.ToString());
        }
    }
}
