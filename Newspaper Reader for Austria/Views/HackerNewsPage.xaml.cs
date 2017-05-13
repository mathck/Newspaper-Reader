using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class HackerNewsPage : Page
    {
        private HackerNewsViewModel ViewModel
        {
            get { return DataContext as HackerNewsViewModel; }
        }

        public HackerNewsPage()
        {
            InitializeComponent();
        }
    }
}
