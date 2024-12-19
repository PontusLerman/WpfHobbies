using System.Windows;
using WpfHobbies.ViewModels;

namespace WpfHobbies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HobbiesViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new HobbiesViewModel();
            DataContext = viewModel;
            Loaded += HobbiesView_Loaded;
        }

        private async void HobbiesView_Loaded(object sender, RoutedEventArgs e)
        {
            await viewModel.LoadAsync();
        }
    }
}