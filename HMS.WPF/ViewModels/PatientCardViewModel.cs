using HMS.WPF.Models;
using System;
using System.Windows.Input;

namespace HMS.WPF.ViewModels
{
    //public class PatientCardViewModel : BaseViewModel
    //{
    //    public String ID { get; set; }
    //    public String Name { get; set; }
    //    public String Type { get; set; }
    //    public String ShortDiagnosis { get; set; }

    //    public ICommand NavigateToDetailsAction { get; set; }

    //    public PatientCardViewModel()
    //    {
    //        NavigateToDetailsAction = new RelayCommand(navigateToDetails);
    //    }

    //    public void navigateToDetails()
    //    {
    //        if (Hospital.Patients[ID].GetType() == typeof(ResidentPatient))
    //            Home.ViewModel.Content = new ResidentPatientDetailsViewModel(ID)
    //            {
    //                PatientName = Hospital.Patients[ID].Name,
    //                PatientAddress = Hospital.Patients[ID].Address,
    //                PatientBirthDate = Hospital.Patients[ID].BirthDate.ToShortDateString(),
    //                PatientBill = Hospital.Patients[ID].getBill().ToString(),
    //                PatientDiagnosis = Hospital.Patients[ID].Diagnosis,
    //                PatientRoomNumber = ((ResidentPatient)(Hospital.Patients[ID])).Room.RoomNumber.ToString(),
    //                PatientType = "Resident Patient",
    //            };
    //        else
    //        {
    //            Home.ViewModel.Content = new AppointmentPatientDetailsViewModel(ID)
    //            {
    //                PatientName = Hospital.Patients[ID].Name,
    //                PatientAddress = Hospital.Patients[ID].Address,
    //                PatientBirthDate = Hospital.Patients[ID].BirthDate.ToShortDateString(),
    //                PatientDiagnosis = Hospital.Patients[ID].Diagnosis,
    //                PatientType = "Appointment Patient",
    //            };
    //        }
    //    }
    //}
}
