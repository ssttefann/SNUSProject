using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Core
{
    public class TagProcessing
    {

        public static void Read(object obj)
        {

            Tag tag = (Tag) obj;

            while(true)
            {
                if(tag.on)
                {
                    switch(tag.address)
                    {
                        case ("cos"):
                            tag.Value = SimulationDriver.Cosine();
                            break;
                        case ("sin"):
                            tag.Value = SimulationDriver.Sine();
                            break;
                        default:
                            tag.Value = SimulationDriver.Ramp();
                            break;
                    }

                    // treba da se posalje info da je ocitan
                    Trending.sendNotification(tag.id, tag.Value);
                }

                Thread.Sleep(tag.scanTime);
            }
        }
    }
}