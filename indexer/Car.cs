using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string SpecificName { get; set; }

        public Car(int id, int year, string specificName)
        {
            Id = id;
            Year = year;
            SpecificName = specificName;
        }


        public override string ToString()
        {
            return $"{Id} {Year} {SpecificName}";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;
            Car c = obj as Car;
            if (ReferenceEquals(c,null))
                return false;
            return this.Id == c.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
