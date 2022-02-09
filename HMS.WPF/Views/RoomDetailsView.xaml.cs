using HMS.WPF.ViewModels;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;
using System.Windows.Input;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for RoomDetailsView.xaml
    /// </summary>
    public partial class RoomDetailsView : UserControl
    {
        public RoomDetailsView()
        {
            InitializeComponent();
        }

        private void RemoveNurseFromRoom(object sender, MouseButtonEventArgs e)
        {
            ((RoomDetailsViewModel)DataContext).RemoveNurse();
        }

        private void ClearEditRoom(object sender, DialogClosingEventArgs eventArgs)
        {
            ((RoomDetailsViewModel)DataContext).textValidation = "";
            RoomNumberTextBox.Text = "";
        }
    }
}
