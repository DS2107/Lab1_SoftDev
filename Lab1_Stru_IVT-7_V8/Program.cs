using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Stru_IVT_7_V8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProcessor array = new ArrayProcessor();
            int[] numbers = { -1000, 34, 1001, 5000, 23 };
            Console.WriteLine( array.CreateNewArray(numbers));
            
        }
    }
}
