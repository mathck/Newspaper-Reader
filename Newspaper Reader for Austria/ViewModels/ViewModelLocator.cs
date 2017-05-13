using GalaSoft.MvvmLight.Ioc;

using Microsoft.Practices.ServiceLocation;

using Newspaper_Reader_for_Austria.Services;
using Newspaper_Reader_for_Austria.Views;

namespace Newspaper_Reader_for_Austria.ViewModels
{
    public class ViewModelLocator
    {
        NavigationServiceEx _navigationService = new NavigationServiceEx();

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => _navigationService);
            Register<PivotViewModel, PivotPage>();
            Register<NYTViewModel, NYTPage>();
            Register<derStandardViewModel, derStandardPage>();
            Register<PresseViewModel, PressePage>();
            Register<HackerNewsViewModel, HackerNewsPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public HackerNewsViewModel HackerNewsViewModel => ServiceLocator.Current.GetInstance<HackerNewsViewModel>();

        public PresseViewModel PresseViewModel => ServiceLocator.Current.GetInstance<PresseViewModel>();

        public derStandardViewModel derStandardViewModel => ServiceLocator.Current.GetInstance<derStandardViewModel>();

        public NYTViewModel NYTViewModel => ServiceLocator.Current.GetInstance<NYTViewModel>();

        public PivotViewModel PivotViewModel => ServiceLocator.Current.GetInstance<PivotViewModel>();

        public void Register<VM, V>() where VM : class
        {
            SimpleIoc.Default.Register<VM>();
            _navigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
