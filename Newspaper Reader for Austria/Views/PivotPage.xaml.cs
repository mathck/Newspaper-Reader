using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class PivotPage : Page
    {
        private PivotViewModel ViewModel { get { return DataContext as PivotViewModel; } }

        public PivotPage()
        {
            InitializeComponent();
        }
    }
}
