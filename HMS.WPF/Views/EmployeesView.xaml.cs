using HMS.WPF.ViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl
    {
        public EmployeesViewModel ViewModel { get; set; }

        public EmployeesView()
        {
            ViewModel = new EmployeesViewModel();
            DataContext = ViewModel;
            InitializeComponent();
            EmployeeDepartmentComboBox.DisplayMemberPath = "Value";
            EmployeeDepartmentComboBox.SelectedValuePath = "Key";
            EmployeeDepartmentComboBox.ItemsSource = ViewModel.ComboBoxItems;
        }

        public void addEmployee(object sender, RoutedEventArgs e)
        {
            if (ViewModel.ValidateName())
            {
                ViewModel.addEmployee();
                EmployeeNameTextBox.Clear();
                EmployeeAddressTextBox.Clear();
                EmployeeBirthDatePicker.SelectedDate = DateTime.Today;
                EmployeeSalaryTextBox.Clear();
                EmployeeDepartmentComboBox.SelectedItem = null;
                EmpoloyeeRoleComboBox.SelectedItem = null;
                Home.ViewModel.CloseRootDialog();
            }
        }

        private void ClearAddEmployee(object sender, DialogClosingEventArgs eventArgs)
        {
            EmployeeNameTextBox.Clear();
            EmployeeAddressTextBox.Clear();
            EmployeeBirthDatePicker.SelectedDate = DateTime.Today;
            EmployeeSalaryTextBox.Clear();
            EmployeeDepartmentComboBox.SelectedItem = null;
            EmpoloyeeRoleComboBox.SelectedItem = null;
            validation.Text = "";
        }
    }
}
