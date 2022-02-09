using HMS.WPF.ViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for PatientsView.xaml
    /// </summary>
    public partial class PatientsView : UserControl
    {
        public PatientsViewModel ViewModel { get; set; }

        public PatientsView()
        {
            InitializeComponent();
        }

        private void Sample2_DialogHost_OnDialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {
            PatientAddressTextBox.Clear();
            PatientNameTextBox.Clear();
            PatientTypeComboBox.SelectedIndex = -1;
            PatientDepartmentCombobox.SelectedIndex = -1;
            RoomNumberComboBox.SelectedIndex = -1;
            PatientBirthDatetDatePicker.SelectedDate = DateTime.Today;
            validation.Text = "";
        }
    }
}
