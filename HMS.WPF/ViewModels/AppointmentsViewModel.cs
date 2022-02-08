using HMS.WPF.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace HMS.WPF.ViewModels
{
    public class AppointmentsViewModel : BaseViewModel
    {
        public String SearchQuery { get; set; }

        public Models.ComboBoxPairs PatientNameComboBox { get; set; }
        public Models.ComboBoxPairs DoctorNameComboBox { get; set; }
        public String AppointmentDuration { get; set; }
        public DateTime AppointmentDatePicker { get; set; }
        public DateTime AppointmentTimePicker { get; set; }
        public String datePickerString { get; set; }
        public String timePickerString { get; set; }
        public String textValidation { get; set; }
        public List<Models.ComboBoxPairs> patientsComboBoxItems;
        public List<Models.ComboBoxPairs> doctorsComboBoxItems;

        public ICommand SearchAction { get; set; }

        public static ObservableCollection<AppointmentCardViewModel> FilteredAppointments { get; set; }
        public static ObservableCollection<AppointmentCardViewModel> Appointments { get; set; }

        public bool Validate()
        {
            AppointmentDuration = (AppointmentDuration != null) ? AppointmentDuration.Trim() : "";

            if (AppointmentDuration == "")
            {
                textValidation = "Can't Have empty Values";
                return false;
            }

            if (PatientNameComboBox == null)
            {
                textValidation = "Can't Have empty Values";

                return false;
            }

            if (DoctorNameComboBox == null)
            {
                textValidation = "Can't Have empty Values";

                return false;
            }

            for (int i = 0; i < AppointmentDuration.Length; i++)
            {
                if (AppointmentDuration[i] >= 'a' && AppointmentDuration[i] <= 'z')
                {
                    textValidation = "Can't Have empty Values";
                    return false;
                }
            }

            bool foundPatient = false, foundDoctor = false;

            foreach (var patient in Models.Hospital.Patients.Values)
            {
                if (patient.GetType() == typeof(AppointmentPatient) && PatientNameComboBox.Value == patient.Name)
                {
                    foundPatient = true;
                }
            }

            foreach (var employee in Models.Hospital.Employees.Values)
            {
                if (employee.GetType() == typeof(Doctor) && DoctorNameComboBox.Value == employee.Name)
                {
                    foundDoctor = true;
                }
            }

            if (!foundPatient || !foundDoctor)
            {
                return false;
            }

            return true;
        }

        public AppointmentsViewModel()
        {
            AppointmentDatePicker = DateTime.Today;

            patientsComboBoxItems = new List<Models.ComboBoxPairs>();
            doctorsComboBoxItems = new List<Models.ComboBoxPairs>();

            SearchAction = new RelayCommand(Search);

            foreach (var patient in Models.Hospital.Patients.Values)
            {
                if (patient.GetType() == typeof(AppointmentPatient))
                {
                    patientsComboBoxItems.Add(new Models.ComboBoxPairs(patient.ID, patient.Name));
                }
            }

            foreach (var employee in Models.Hospital.Employees.Values)
            {
                if (employee.GetType() == typeof(Doctor))
                {
                    doctorsComboBoxItems.Add(new Models.ComboBoxPairs(employee.ID, employee.Name));
                }
            }

            Appointments = new ObservableCollection<AppointmentCardViewModel>();

            foreach (var appointment in Models.Hospital.Appointments.Values)
            {
                Appointments.Add(
                    new AppointmentCardViewModel
                    {
                        ID = appointment.AppointmentID.ToString(),
                        PatientName = appointment.Patient.Name,
                        DoctorName = appointment.Doctor.Name,
                        Duration = appointment.Duration.ToString() + " mins",
                        AppointmentDate = appointment.Date.ToString(),
                        appointmentBill = appointment.Bill.ToString("#0.00") + '$'
                    }
                );
            }

            FilteredAppointments = new ObservableCollection<AppointmentCardViewModel>(Appointments);
        }

        public void DeleteAppointment(String ID)
        {
            Models.Hospital.Appointments[ID].Doctor.removePatient(Models.Hospital.Appointments[ID].Patient.ID);
            Models.Hospital.DeleteAppointment(ID);
            
            for (int i = 0; i < FilteredAppointments.Count; ++i)
            {
                if (FilteredAppointments[i].ID == ID)
                {
                    FilteredAppointments.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < Appointments.Count; ++i)
            {
                if (Appointments[i].ID == ID)
                {
                    Appointments.RemoveAt(i);
                    break;
                }
            }

            Services.HospitalDB.DeleteAppointment(ID);
        }

        public void Search()
        {
            if (String.IsNullOrEmpty(SearchQuery))
            {
                FilteredAppointments = new ObservableCollection<AppointmentCardViewModel>(Appointments);
                return;
            }

            FilteredAppointments = new ObservableCollection<AppointmentCardViewModel>(
                Appointments.Where(Appointment => Appointment.AppointmentDate.ToString().Contains(SearchQuery))
            );
        }

        public void addAppointment()
        {
            datePickerString = AppointmentDatePicker.ToShortDateString();
            datePickerString += " ";
            datePickerString += AppointmentTimePicker.ToShortTimeString();
            
            Appointment newAppointment = new Appointment
            {
                Patient = (AppointmentPatient)Models.Hospital.Patients[PatientNameComboBox.Key],
                Doctor = (Doctor)Models.Hospital.Employees[DoctorNameComboBox.Key],
                Duration = Int32.Parse(AppointmentDuration),
                Date = DateTime.Parse(datePickerString),
                Bill = ((double.Parse(AppointmentDuration) / 60.0)) * Models.Hospital.Config.AppointmentHourPrice
            };

            if (!(((Doctor)Models.Hospital.Employees[DoctorNameComboBox.Key]).isAvailable(newAppointment)))
            {
                textValidation = "Doctor is not available at this time";
                return;
            }

            Appointments.Add(
                new AppointmentCardViewModel
                {
                    ID = newAppointment.AppointmentID.ToString(),
                    PatientName = newAppointment.Patient.Name,
                    DoctorName = newAppointment.Doctor.Name,
                    Duration = newAppointment.Duration.ToString(),
                    AppointmentDate = newAppointment.Date.ToString(),
                    appointmentBill = newAppointment.Bill.ToString("0.00") + '$'
                });

            FilteredAppointments.Add(
                new AppointmentCardViewModel
                {
                    ID = newAppointment.AppointmentID.ToString(),
                    PatientName = newAppointment.Patient.Name,
                    DoctorName = newAppointment.Doctor.Name,
                    Duration = newAppointment.Duration.ToString(),
                    AppointmentDate = newAppointment.Date.ToString(),
                    appointmentBill = newAppointment.Bill.ToString("0.00") + '$'
                });

            Models.Hospital.Appointments.Add(newAppointment.AppointmentID.ToString(), newAppointment);
            Models.Hospital.Appointments[newAppointment.AppointmentID.ToString()].Patient.addAppointment(newAppointment);
            Models.Hospital.Appointments[newAppointment.AppointmentID.ToString()].Doctor.addAppointment(newAppointment);
            Models.Hospital.Appointments[newAppointment.AppointmentID.ToString()].Doctor.addPatient(newAppointment.Patient);
            HospitalDB.InsertAppointment(newAppointment);
            Home.ViewModel.CloseRootDialog();
        }
    }
}
