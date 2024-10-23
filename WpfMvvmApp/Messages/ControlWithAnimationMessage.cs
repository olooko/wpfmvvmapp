﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmApp.Messages
{
    public class ControlWithAnimationMessage : ValueChangedMessage<string>
    {
        public ControlWithAnimationMessage(string message) : base(message)
        {
        }
    }
}