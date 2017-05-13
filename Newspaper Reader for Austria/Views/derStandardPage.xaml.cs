using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class derStandardPage : Page
    {
        private derStandardViewModel ViewModel
        {
            get { return DataContext as derStandardViewModel; }
        }

        public derStandardPage()
        {
            InitializeComponent();
        }
    }
}
