using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0912
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(3);
            //arr.Add("hello");

            int sum = 0;
            foreach (int item in arr)
            {
                int number = (int)item;
                sum += number;
            }
            Console.WriteLine(sum);

            //List<>
            Secret<int> s = new Secret<int>(1);
            Console.WriteLine(s);
        }
    }
}
