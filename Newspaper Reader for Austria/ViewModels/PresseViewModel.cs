using System;

using GalaSoft.MvvmLight;

namespace Newspaper_Reader_for_Austria.ViewModels
{
    public class PresseViewModel : ViewModelBase
    {
        private const string defaultUrl = "http://diepresse.com/";

        private Uri _source;
        public Uri Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        public PresseViewModel()
        {
            Source = new Uri(defaultUrl);
        }
    }
}
