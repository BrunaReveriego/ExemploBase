using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBase
{
    public class BaseClass
    {
        int num;

        public BaseClass()
        {
            Console.WriteLine("Construtor BaseClass");
        }

        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("Construtor BaseClass(int i)" + num);
        }

        public int GetNum()
        {
            return num;
        }


    }
}
