using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Messages
{
    public class ToastMessage : ValueChangedMessage<string>
    {
        public ToastMessage(string message) : base(message)
        {
        }
    }
}
