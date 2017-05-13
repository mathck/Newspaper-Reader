using System;

using GalaSoft.MvvmLight;

namespace Newspaper_Reader_for_Austria.ViewModels
{
    public class NYTViewModel : ViewModelBase
    {
        private const string defaultUrl = "http://app.nytimes.com/";

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
