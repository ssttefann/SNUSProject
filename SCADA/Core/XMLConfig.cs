using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Web;

namespace Core
{
    public class XMLConfig
    {
        public static string PATH = System.AppDomain.CurrentDomain.BaseDirectory + "\\Configuration.xml";
        public static DataContractSerializer s = new DataContractSerializer(typeof(Dictionary<string, Tag>));

        public static void ReadData()
        {
            try
            {
                using (FileStream fs = File.Open(PATH, FileMode.Open))
                {
                    object s2 = s.ReadObject(fs);
                    if (s2 == null)
                        return;

                    DatabaseManager.tags = (Dictionary<string, Tag>)s2;
                }

            }
            catch(Exception e)
            {
                return;
            }


            foreach (Tag tag in DatabaseManager.tags.Values)
            {
                //Thread thread= new Thread(new ParameterizedThreadStart(TagProcessing.Read));
                Thread thread = new Thread( () => TagProcessing.Read(tag));
                lock (DatabaseManager.threads)
                {
                    DatabaseManager.threads.Add(tag.id, thread);
                    thread.Start();
                }
            }
        }


        public static void WriteData()
        {
            using (FileStream fs = File.Open(PATH, FileMode.Create))
            {
                Console.WriteLine("Testing for type: {0}", typeof(Dictionary<string, Tag>));
                s.WriteObject(fs, DatabaseManager.tags);
            }
        }
    }
}