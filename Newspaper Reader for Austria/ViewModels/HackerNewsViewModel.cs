using System;

using GalaSoft.MvvmLight;

namespace Newspaper_Reader_for_Austria.ViewModels
{
    public class HackerNewsViewModel : ViewModelBase
    {
        private const string defaultUrl = "https://news.ycombinator.com/";

        private Uri _source;
        public Uri Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        public HackerNewsViewModel()
        {
            Source = new Uri(defaultUrl);
        }
    }
}
