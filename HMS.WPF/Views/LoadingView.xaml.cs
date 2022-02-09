using HMS.WPF.ViewModels;
using System.Windows.Controls;

namespace HMS.WPF.Views
{
    /// <summary>
    /// Interaction logic for LoadingView.xaml
    /// </summary>
    public partial class LoadingView : UserControl
    {
        public LoadingView()
        {
            DataContext = new LoadingViewModel();
            InitializeComponent();
        }
    }
}
