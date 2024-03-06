using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmApp.Interfaces;
using WpfMvvmApp.Controls.Popups;

namespace WpfMvvmApp.ViewModels.Sample
{
    public partial class PopupPageViewModel : ObservableRecipient
    {
        [RelayCommand]
        private void ShowPopup()
        {
            IPopupService popupService = Ioc.Default.GetRequiredService<IPopupService>();

            AlertOkPopupControl popup = new AlertOkPopupControl();
            popup.OkClicked += delegate (object s, EventArgs e) {
                popupService.Pop();
            };

            popupService.Push(popup);
        }
    }
}
