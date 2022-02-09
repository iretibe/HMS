using HMS.WPF.ViewModels;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for DepartmentsView.xaml
    /// </summary>
    public partial class DepartmentsView : UserControl
    {
        public DepartmentsViewModel ViewModel { get; set; }

        public DepartmentsView()
        {
            InitializeComponent();
        }

        private void ClearAddDepartment(object sender, DialogClosingEventArgs eventArgs)
        {
            DepartmentNameTextBox.Clear();
            validation.Text = "";
        }
    }
}
