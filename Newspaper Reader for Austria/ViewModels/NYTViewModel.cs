using System;

using GalaSoft.MvvmLight;

namespace Newspaper_Reader_for_Austria.ViewModels
{
    public class NYTViewModel : ViewModelBase
    {
        // TODO UWPTemplates: Set your hyperlink default here
        private const string defaultUrl = "https://developer.microsoft.com/en-us/windows/apps";

        private Uri _source;
        public Uri Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        public NYTViewModel()
        {
            Source = new Uri(defaultUrl);
        }
    }
}