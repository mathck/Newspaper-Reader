using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class SettingsPage : Page
    {
        private SettingsViewModel ViewModel
        {
            get { return DataContext as SettingsViewModel; }
        }

        // TODO UWPTemplates: Setup your privacy web in your Resource File, currently set to https://YourPrivacyUrlGoesHere

        public SettingsPage()
        {
            InitializeComponent();
            ViewModel.Initialize();
        }
    }
}
