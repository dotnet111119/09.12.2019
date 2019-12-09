using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car(1234, 2020, "Honda Civic 1");
            Car mazda = new Car(2123, 2021, "Mazda CX 5 2");
            Car subaru = new Car(89, 2022, "Subaru X 3");
            List<Car> cars = new List<Car>() { honda, mazda, subaru };
            Garage gar = new Garage(cars);
            Console.WriteLine(gar[1234]);
            Console.WriteLine(gar["Subaru X 3"]);

        }
    }
}
