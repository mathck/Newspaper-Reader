using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class NYTPage : Page
    {
        private NYTViewModel ViewModel
        {
            get { return DataContext as NYTViewModel; }
        }

        public NYTPage()
        {
            InitializeComponent();
        }
    }
}
