using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmApp.Models;
using WpfMvvmApp.Services;

namespace WpfMvvmApp.ViewModels
{
    public partial class CryptographyPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<SampleDataJsonModel> _samples;

        public CryptographyPageViewModel()
        {
            _samples = new ObservableCollection<SampleDataJsonModel>();
            _samples.Add(new SampleDataJsonModel { Title = "a", Data = "A" });
            _samples.Add(new SampleDataJsonModel { Title = "b", Data = "B" });
            _samples.Add(new SampleDataJsonModel { Title = "c", Data = "C" });
            _samples.Add(new SampleDataJsonModel { Title = "d", Data = "D" });
        }

        [RelayCommand]
        private void Save()
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".enc";
            dialog.Filter = "Encrypted documents (.enc)|*.enc";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string json = JsonConvert.SerializeObject(this.Samples);

                ICryptographyService cryptographyService = Ioc.Default.GetRequiredService<ICryptographyService>();
                File.WriteAllBytes(dialog.FileName, cryptographyService.EncryptByAES128(json));
            }
        }

        [RelayCommand]
        private void Load()
        {
            var dialog = new OpenFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".enc";
            dialog.Filter = "Encrypted documents (.enc)|*.enc";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                byte[] json = File.ReadAllBytes(dialog.FileName);

                ICryptographyService cryptographyService = Ioc.Default.GetRequiredService<ICryptographyService>();
                this.Samples = JsonConvert.DeserializeObject<ObservableCollection<SampleDataJsonModel>>(cryptographyService.DecryptByAES128(json));
            }
        }
    }
}
