using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Trending.ServiceReference1;

namespace Trending
{
    public class TrendingCallback : ITrendingCallback
    {
        public void TagValueChanged(string name, double value)
        {
            Console.WriteLine($"Tag with id {name} value changed to {value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext ic = new InstanceContext(new TrendingCallback());
            TrendingClient proxy = new TrendingClient(ic);
            proxy.SubscriberInitialization();
            Console.WriteLine("Uspesno se subovao");
            Console.ReadLine();//Čekaju se poruke sa servisa do zatvaranja klijenta
        }
    }
}
