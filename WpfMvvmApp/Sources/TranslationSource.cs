using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace WpfMvvmApp.Sources
{
    public class TranslationSource : INotifyPropertyChanged
    {
        private static readonly TranslationSource _instance = new TranslationSource();

        public event PropertyChangedEventHandler PropertyChanged;

        public static TranslationSource Instance
        {
            get { return _instance; }
        }

        private readonly ResourceManager _resourceManager = new ResourceManager(typeof(Languages.Translation));
        private CultureInfo _currentCulture = null;

        public string this[string key]
        {
            get { return _resourceManager.GetString(key, _currentCulture); }
        }

        public CultureInfo CurrentCulture
        {
            get { return _currentCulture; }
            set
            {
                _currentCulture = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(string.Empty));
            }
        }
    }
}
