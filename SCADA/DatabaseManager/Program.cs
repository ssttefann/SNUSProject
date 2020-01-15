using DatabaseManager.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    class Program
    {
        static DatabaseManagerClient proxy;

        static void Main(string[] args)
        {
            proxy = new DatabaseManagerClient();

            userInput();

            Console.ReadKey();
        }

        static void userInput()
        {
            while (true)
            {

                Console.WriteLine("\n1. Dodavanje novog taga\n2. Brisanje taga\n3. Menjanje stanja taga\n4. Izlaz");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                    addTag();
                else if (input == 2)
                    removeTag();
                else if (input == 3)
                    changeTag();
                else if (input == 4)
                    return;
            }
        }

        private static void addTag()
        {
            Console.WriteLine("Analogni ili digitalni (a/d)");
            string input = Console.ReadLine();
            Tag tag = null;

            if (input == "a")
            {
                tag = new AnalogTag
                { id = "2",
                   address = "cos",
                   lowLimit = 0,
                   highLimit = 100,
                   on = true,
                   scanTime = 3000,
                   Value = 0
                };
            }
            else
            {
                 tag = new DigitalTag
                {
                    id = "3",
                    address = "cos",
                    on = true,
                    scanTime = 3000,
                    Value = 0
                };

            
            }

            if(proxy.addTag(tag))
            {
                Console.WriteLine($"Tag sa id {tag.id} uspesno dodat");
            }else
            {
                Console.WriteLine($"Vec postoji tag sa id {tag.id} ");
            }
        }


        private static void removeTag()
        {
            throw new NotImplementedException();
        }

        private static void changeTag()
        {
            throw new NotImplementedException();
        }


    }
}
