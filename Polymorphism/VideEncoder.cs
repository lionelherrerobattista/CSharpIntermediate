using System.Collections;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class VideEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            foreach (var channel in _notificationChannels) // identification at runtime
                channel.Send(new Message()); // polymorphic method
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel); // add diff notif channels to the list
        }
    }
}