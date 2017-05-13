using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
