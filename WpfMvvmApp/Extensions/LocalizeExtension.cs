using System.Windows.Data;
using WpfMvvmApp.Sources;

namespace WpfMvvmApp.Extensions
{
    public class LocalizeExtension : Binding
    {
        public LocalizeExtension(string name) : base("[" + name + "]")
        {
            this.Mode = BindingMode.OneWay;
            this.Source = TranslationSource.Instance;
        }
    }
}
