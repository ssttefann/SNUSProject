using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Core
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DatabaseManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DatabaseManager.svc or DatabaseManager.svc.cs at the Solution Explorer and start debugging.
    public class DatabaseManager : Interfaces.IDatabaseManager
    {
        public static Dictionary<string, Tag> tags = new Dictionary<string, Tag>();
        public static Dictionary<string, Thread> threads = new Dictionary<string, Thread>();

        static DatabaseManager() {
            //ucitaj sve
            //XMLConfig.ReadData();
        }

        public bool addTag(Tag tag)
        {
            if(tags.ContainsKey(tag.id))
            {
                return false;
            }

            lock (tags)
            {
                tags.Add(tag.id, tag);
            }

            //Thread thread = new Thread(new ParameterizedThreadStart(TagProcessing.Read));
            Thread thread = new Thread(() => TagProcessing.Read(tag));
            lock (threads)
            {
                threads.Add(tag.id, thread);
                thread.Start();
            }

            
            XMLConfig.WriteData();
            return true;

        }


        public bool removeTag(string id)
        {
            
            if(!tags.ContainsKey(id))
            {
                return false;
            }

            lock(tags)
            {
                tags.Remove(id);
            }

            lock(threads)
            {
                threads[id].Abort();
                threads.Remove(id);
            }

            XMLConfig.WriteData();
            return true;

        }

        public bool changeScan(string id)
        {
            if (!tags.ContainsKey(id))
            {
                return false;
            }

            lock (tags)
            {
                tags[id].on = !tags[id].on;
            }

            XMLConfig.WriteData();
            return true;
        }

    }
}
