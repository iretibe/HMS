using HMS.WPF.ViewModels;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for DepartmentDetailsView.xaml
    /// </summary>
    public partial class DepartmentDetailsView : UserControl
    {
        public DepartmentDetailsView()
        {
            InitializeComponent();
        }

        private void ClearEditDepartment(object sender, DialogClosingEventArgs eventArgs)
        {
            ((DepartmentDetailsViewModel)DataContext).textValidation = "";
            DepartmentNameTextBox = null;
        }
    }
}
