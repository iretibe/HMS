using HMS.WPF.Views.Components;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows.Input;

namespace HMS.WPF.ViewModels
{
    public class AppointmentCardViewModel : BaseViewModel
    {
        public string ID { get; set; }
        public String PatientName { get; set; }
        public String DoctorName { get; set; }
        public String AppointmentDate { get; set; }
        public String Duration { get; set; }
        public String appointmentBill { get; set; }

        public ICommand deleteAppointment { get; set; }

        public AppointmentCardViewModel()
        {
            deleteAppointment = new RelayCommand(DeleteAppointment);
        }

        public async void DeleteAppointment()
        {
            ((AppointmentsViewModel)Home.ViewModel.Content).FilteredAppointments.Clear();
            object result = await DialogHost.Show(new DeleteMessageBox(), "RootDialog");
            if (result.Equals(true))
            {
                ((AppointmentsViewModel)Home.ViewModel.Content).DeleteAppointment(ID);
            }
        }
    }
}
