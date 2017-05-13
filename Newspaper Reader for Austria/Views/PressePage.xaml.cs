using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class PressePage : Page
    {
        private PresseViewModel ViewModel
        {
            get { return DataContext as PresseViewModel; }
        }

        public PressePage()
        {
            InitializeComponent();
        }
    }
}
