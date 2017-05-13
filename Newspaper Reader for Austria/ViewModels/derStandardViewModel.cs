using System;

using GalaSoft.MvvmLight;

namespace Newspaper_Reader_for_Austria.ViewModels
{
    public class derStandardViewModel : ViewModelBase
    {
        private const string defaultUrl = "http://derstandard.at/";

        private Uri _source;
        public Uri Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        public derStandardViewModel()
        {
            Source = new Uri(defaultUrl);
        }
    }
}
