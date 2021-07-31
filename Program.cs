using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee cus1 = Coffee.GetInstance;

            cus1.Quotes("good","good","good");

            Coffee cus2 = Coffee.GetInstance;
            cus2.Quotes("good", "good", "good"); 
            Console.Read();
        }
    }
}
