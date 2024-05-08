using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Messages._Sample
{
    public class MessengerSampleMessage : ValueChangedMessage<string>
    {
        public MessengerSampleMessage(string message) : base(message)
        {
        }
    }
}
