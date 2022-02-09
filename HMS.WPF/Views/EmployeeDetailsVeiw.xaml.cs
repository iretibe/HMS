using HMS.WPF.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for EmployeeDetailsVeiw.xaml
    /// </summary>
    public partial class EmployeeDetailsVeiw : UserControl
    {
        public EmployeeDetailsViewModel ViewModel { get; set; }

        public EmployeeDetailsVeiw()
        {
            InitializeComponent();
        }

        private void RemovePatientFromDoctor(object sender, MouseButtonEventArgs e)
        {
            ((EmployeeDetailsViewModel)DataContext).RemovePatient();
        }

        private void RemoveRoomFromNurse(object sender, MouseButtonEventArgs e)
        {
            ((EmployeeDetailsViewModel)DataContext).RemoveRoom();
        }
    }
}
