using HMS.WPF.ViewModels;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    public partial class AppointmentPatientDetailsView : UserControl
    {
        public AppointmentPatientDetailsViewModel ViewModel { get; set; }

        public AppointmentPatientDetailsView()
        {
            InitializeComponent();
        }
    }
}
