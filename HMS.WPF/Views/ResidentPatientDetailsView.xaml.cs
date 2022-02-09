using HMS.WPF.ViewModels;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for ResidentPatientDetailsView.xaml
    /// </summary>
    public partial class ResidentPatientDetailsView : UserControl
    {
        public ResidentPatientDetailsViewModel ViewModel { get; set; }

        public ResidentPatientDetailsView()
        {
            InitializeComponent();

        }

        private void RemoveDoctorFromPatient(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((ResidentPatientDetailsViewModel)DataContext).RemoveDr();

        }

        private void RemoveMedicineFromPatient(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ((ResidentPatientDetailsViewModel)DataContext).RemoveMedicine();

        }

        private void ClearEditResident(object sender, DialogClosingEventArgs eventArgs)
        {
            ((ResidentPatientDetailsViewModel)DataContext).textValidation = "";

        }
    }
}
