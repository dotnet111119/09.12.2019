using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0912
{
    public class Secret<T>
    {
        public T Data { get; set; }
        public Secret(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return $"{Data}";
        }

    }
}
