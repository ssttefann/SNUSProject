using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.Interfaces;

namespace Core
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Trending" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Trending.svc or Trending.svc.cs at the Solution Explorer and start debugging.
    public class Trending : Interfaces.ITrending
    {
        static ITrendingCallback proxy = null;
        delegate void NotificationDelegate(string name, double value);
        static event NotificationDelegate notificationSent = null;

        public static void sendNotification(string name, double value)
        {
            if (notificationSent != null)
                notificationSent(name, value);
        }

        public void SubscriberInitialization()
        {
            proxy = OperationContext.Current.GetCallbackChannel<ITrendingCallback>();
            notificationSent += proxy.TagValueChanged;
        }
    }
}
