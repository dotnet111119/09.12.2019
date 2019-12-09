using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0912_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            // l1.Add("a"); -- type safe!
            l1.Add(12); // no boxing!
            int x = l1[0]; // no unboxing!

            List<int> l2 = new List<int> { 1, 2, 3 };

            // option 1 to add {1,2,3}
            foreach(int item in l2)
            {
                l1.Add(item);
            }
            // option 2 -- shorter
            l1.AddRange(l2);

            l1.Remove(12);

            l1.RemoveAt(0);

            Console.WriteLine(l1.Count);

            l1.ForEach(l => Console.WriteLine(l));

            l1.Clear();


        }
    }
}
