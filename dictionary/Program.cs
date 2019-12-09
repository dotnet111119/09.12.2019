using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0912_
{
    class Program
    {
        class A <TKey, TVAlue>
        {

        }
        static void Main(string[] args)
        {
            Dictionary<int, Person> mapIdToPerson = new Dictionary<int, Person>();

            Person danny = new Person(338, "danny");

            Person dan = new Person(338, "dan");

            mapIdToPerson.Add(danny.Id, danny);

            // mapIdToPerson.Add(dan.Id, dan); -- Error
            mapIdToPerson[dan.Id] = dan; // will overwrite

            Person person = mapIdToPerson[dan.Id];

            Console.WriteLine(person);


            // Person person2 = mapIdToPerson[777];  -- Error
            if (mapIdToPerson.TryGetValue(777, out Person result))
            {
                // found
                Console.WriteLine(result);
            }

            List<Person> persons = new List<Person>(); /// ....
            persons.Add(new Person(1123123, "moshe"));
            persons.Add(new Person(19384, "tzipi"));
            persons.Add(new Person(2948, "roni"));
            persons.Add(new Person(75724, "vlad"));

            // Add
            Dictionary<string, Person> mapNameToPerson = new Dictionary<string, Person>();
            foreach (var item in persons)
            {
                mapNameToPerson.Add(item.Name, item);
            }

            // Readline person name - look for this person in dictoinary
            //if find --> print the person, otherwise print "not found"
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            if (mapNameToPerson.TryGetValue(name, out Person finder))
            {
                Console.WriteLine(finder);
            }
            else
            {
                Console.WriteLine("Not found...");
            }

            Dictionary<Person, int> mapPersonToId = new Dictionary<Person, int>();
            mapPersonToId.Add(dan, 12);
            mapPersonToId.Add(danny, 32);

            if (mapPersonToId.TryGetValue(dan, out int lockerid))
            {
                Console.WriteLine($"here's your locker key {lockerid}");
            }
            else
            {
                Console.WriteLine("I don't know you ... security!!");
            }


        }
    }
}
