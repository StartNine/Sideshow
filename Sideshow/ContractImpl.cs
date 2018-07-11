﻿using Sideshow.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Sideshow
{
    public class ReceiverEntry : IReceiverEntry
    {
        public ReceiverEntry(String name)
        {
            FriendlyName = name;
        }

        public void SendMessage(IMessage message) => Application.Current.Dispatcher.BeginInvoke((Action)(() => MessageReceived(message, new MessageReceivedEventArgsImpl(message))), DispatcherPriority.Send, null);
        public String FriendlyName { get; }
        public Type Type { get; }

        public event EventHandler<MessageReceivedEventArgs> MessageReceived;
    }

    public class MessageReceivedEventArgsImpl : MessageReceivedEventArgs
    {
        public MessageReceivedEventArgsImpl(IMessage m)
        {
            Message = m;
        }
        public override IMessage Message { get; }
    }

    public class Message : IMessage
    {
        public Message(Object o, IMessageEntry entry)
        {
            Object = o;
            MessageEntry = entry;
        }

        public Object Object { get; }
        public IMessageEntry MessageEntry { get; }
    }

    public class ConfigurationEntry : IConfigurationEntry
    {
        public ConfigurationEntry(Object obj, String name)
        {
            Object = obj;
            FriendlyName = name;
        }

        public Object Object { get; }

        public String FriendlyName { get; }
    }
}
