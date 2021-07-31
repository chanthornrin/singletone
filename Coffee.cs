using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    class Coffee
    {
        private Coffee() { }

        private static Coffee Instance = null;
        public static Coffee GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Coffee();
                }
                return Instance;
            }

        }

        public void Quotes(String qaulity, String price, String reqirment)
        {
            Console.WriteLine("Quality:" + qaulity + "\n Prices:" + price +

   "\nRequirments:" + reqirment);
        }

    }
}
