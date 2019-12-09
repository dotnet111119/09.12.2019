using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    public class Garage
    {
        public List<Car> Cars { get; set; }

        public Garage(List<Car> cars)
        {
            Cars = cars;
        }

        public Car this[int carId]
        {
            get
            {
                foreach (var car in Cars)
                {
                    if (car.Id == carId)
                        return car;
                }
                return null;
            }

        }

        public Car this[string carName]
        {
            get
            {
                foreach (var car in Cars)
                {
                    if (car.SpecificName ==carName)
                        return car;
                }
                return null;
            }

        }

    }
}
