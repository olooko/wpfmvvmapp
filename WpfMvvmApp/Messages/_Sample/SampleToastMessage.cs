using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Messages._Sample
{
    public class SampleToastMessage : ValueChangedMessage<string>
    {
        public SampleToastMessage(string message) : base(message)
        {
        }
    }
}
