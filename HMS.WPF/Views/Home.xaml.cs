using HMS.WPF.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public static HomeViewModel ViewModel { get; set; }

        public Home()
        {
            ViewModel = new HomeViewModel();
            DataContext = ViewModel;
            ViewModel.InitializeHospital();
            InitializeComponent();
        }

        private void navigateToDepartments(object sender, MouseButtonEventArgs e)
        {
            ViewModel.Content = new DepartmentsViewModel();
        }

        private void navigateToEmployees(object sender, MouseButtonEventArgs e)
        {
            ViewModel.Content = new EmployeesViewModel();
        }

        private void navigateToPatients(object sender, RoutedEventArgs e)
        {
            ViewModel.Content = new PatientsViewModel();
        }

        private void navigateToAppointments(object sender, RoutedEventArgs e)
        {
            ViewModel.Content = new AppointmentsViewModel();
        }

        private void navigateToRooms(object sender, RoutedEventArgs e)
        {
            ViewModel.Content = new RoomsViewModel();
        }

        private void navigateToSettings(object sender, RoutedEventArgs e)
        {
            ViewModel.Content = new SettingsViewModel();
        }
    }
}
