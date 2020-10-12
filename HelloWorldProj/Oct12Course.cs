using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HelloWorldProj
{
    class Oct12Course
    {
        public static string getUserPassword(string myUser) //Oct12_Dictionaries()
        {
            Dictionary<string, string> userDictionary = new Dictionary<string, string>();
            userDictionary.Add("adminUser", "parola123Q");
            userDictionary.Add("clientUser", "parola123R");
            userDictionary.Add("supportUser", "parola123TY");

            foreach (var user in userDictionary)
            {
                if (user.Key.Equals(myUser))
                {
                    // Console.WriteLine($"Parola este {user.Value}"); 
                    return user.Value;
                }
            }
            return null;
        }

        public static KeyValuePair<string, string> getUserCredentials(string myUser) //Oct12_Dictionaries()
        {
            Dictionary<string, string> userDictionary = new Dictionary<string, string>();
            userDictionary.Add("adminUser", "parola123Q");
            userDictionary.Add("clientUser", "parola123R");
            userDictionary.Add("supportUser", "parola123TY");

            foreach (var user in userDictionary)
            {
                if (user.Key.Equals(myUser))
                {
                    return user;
                }
            }
            return new KeyValuePair<string, string>();
        }

        public static Tuple<string, string> getUserCredentialsWithTuple(string myUser) //Oct12_Dictionaries()
        {
            Dictionary<string, string> userDictionary = new Dictionary<string, string>();
            userDictionary.Add("adminUser", "parola123Q");
            userDictionary.Add("clientUser", "parola123R");
            userDictionary.Add("supportUser", "parola123TY");

            foreach (var user in userDictionary)
            {
                if (user.Key.Equals(myUser))
                {
                    return Tuple.Create(user.Key, user.Value);
                }
            }
            return null;
        }

        public static void Oct12_SortedLists()
        {
            SortedList<int, string> orase = new SortedList<int, string>();
            orase.Add(1, "Brasov");
            orase.Add(2, "Iasi");
            orase.Add(3, "Cluj");
            orase.Add(4, "Bucuresti");

            foreach (var oras in orase)
            {
                if (oras.Key == 2)
                {
                    Console.WriteLine($"Orasul {oras.Value} are key {oras.Key}");
                }
                //Console.WriteLine($"Orasul {oras.Value} are key {oras.Key}");
            }
        }

        public static void Oct12_ArrayLists()
        {
            var arrayListExample = new ArrayList()
            {
                1, "Nume", true, 4.8, null
            };

            //foreach (var element in arrayListExample)
            //{
            //    Console.WriteLine(element);
            //}

            //var myElement = (int)arrayListExample[0];  //cast to int
            //Console.WriteLine(myElement);

            Console.WriteLine(arrayListExample.Contains("Nume"));
        }

        public static void Oct12_Lists()
        {
            //List<string> orase = new List<string>();
            //orase.Add("Brasov");
            //orase.Add("Bucuresti");
            //orase.Add("Iasi");
            //orase.Add("Cluj");

            //foreach (var oras in orase)
            //{
            //    Console.WriteLine(oras);
            //}

            string[] orase = new string[3] { "Brasov", "Iasi", "Bucuresti" };

            var listaMeaDeOrase = new List<string>();
            Console.WriteLine($"Lista mea de orase contine {listaMeaDeOrase.Count} orase");

            listaMeaDeOrase.AddRange(orase);

            //foreach (var oras in listaMeaDeOrase)
            //{
            //    Console.WriteLine(oras);
            //}
            //Console.WriteLine($"Lista mea de orase contine {listaMeaDeOrase.Count} orase");

            foreach (var oras in listaMeaDeOrase)
            {
                if (!oras.Equals("Brasov")) continue;
                Console.WriteLine(oras);
            }
        }
    }    
}
