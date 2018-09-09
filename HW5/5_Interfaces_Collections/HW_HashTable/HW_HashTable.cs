using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.HW4.HW_HashTable
{
    class HW_HashTable
    {
        Hashtable hashTabe { get; set; }
        Dictionary<int, Person> dictionary { get; set; }


        public HW_HashTable(Hashtable hashTabe, Dictionary<int, Person> dictionary)
        {
            this.hashTabe = hashTabe;
            this.dictionary = dictionary;
        }

        public HW_HashTable()
        {
            hashTabe = new Hashtable();
            dictionary = new Dictionary<int, Person>();
        }

        public void FillHashTabe()
        {
            hashTabe.Add("Lviv", new Person("Maksym", new DateTime(1995, 12, 1)));
            hashTabe.Add("Kyiv", new Person("Olena", new DateTime(1997, 10, 11)));
            hashTabe.Add("Odessa",
                new List<Person> {
                    new Person("Oksana", new DateTime(1999, 8, 9)),
                    new Person("Igor", new DateTime(1993, 1, 8))
                });
            hashTabe.Add("Dnipro",
                new List<Person> {
                    new Person("Danylo", new DateTime(1994, 3, 6)),
                    new Person("Natalia", new DateTime(1998, 10, 9))
                 });
            hashTabe.Add("Uzhgorod", new Car());
            hashTabe.Add(1, new Car("BMW", "Black", 120000));



            dictionary.Add(1,new Person("Olena", new DateTime(1997, 10, 11)));
        }

        public void ShowDifference()
        {
            //hashTabe = new Hashtable();
            //dictionary = new Dictionary<int, string>();

            //            Dictionary <<<>>> Hashtable differences:
            //            Generic <<<>>> Non - Generic
            Person person1 = dictionary[1];
            Person person2 = hashTabe["Lviv"] as Person;

            //            Needs own thread synchronization <<<>>> Offers thread safe version through Synchronized() method
            //            Enumerated item: KeyValuePair <<<>>> Enumerated item: DictionaryEntry
            //            Newer(> .NET 2.0) <<<>>> Older(since.NET 1.0)
            //            is in System.Collections.Generic <<<>>> is in System.Collections
            //            Request to non-existing key throws exception <<<>>> Request to non-existing key returns null
            //            potentially a bit faster for value types <<<>>> bit slower(needs boxing / unboxing) for value types
        }

        public void ShowMethods()
        {
            Console.WriteLine("\n\t\tUsed function Values");
            ArrayList arrayList = new ArrayList(hashTabe.Values);
            foreach (var a in arrayList)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine("\n\t\tUsed function Keys");
            ICollection keyColl = hashTabe.Keys;
            foreach (var a in keyColl)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine("\n\t\tUsed function Remove, key Dnipro");
            hashTabe.Remove("Dnipro");
            Console.WriteLine(ToString());
            Console.WriteLine("\n\t\tUsed [] to get value");
            Console.WriteLine("hashTabe[1] => {0}\thashTabe[\"Lviv\"] = > {1}", hashTabe[1], hashTabe["Lviv"]);
           
        }

        public override string ToString()
        {
            string rez = string.Empty;
            string tmp = string.Empty;
            foreach (DictionaryEntry entry in hashTabe)
            {
                if (IsList(entry.Value))
                {
                    foreach (var e in (ICollection)entry.Value)
                    {
                        tmp += "\t" + e.ToString();
                    }
                    rez = "[Key]" + entry.Key.ToString() + "\t[Value] :"+ tmp + "\n" + rez;
                }
                else
                {
                    rez = "[Key]" + entry.Key.ToString() + "\t[Value] :" + "\t" + entry.Value.ToString() + "\n" + rez;
                }
                    tmp = string.Empty;
                }

                return rez;
        }

        public bool IsList(object o)
        {
            if (o == null) return false;
            return o is IList &&
                   o.GetType().IsGenericType &&
                   o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }

        public void IntrodctionHashTable()
        {
            HW_HashTable hW_HashTable = new HW_HashTable();
            hW_HashTable.FillHashTabe();
            Console.WriteLine(hW_HashTable);
            hW_HashTable.ShowMethods();
        }
    }
}
