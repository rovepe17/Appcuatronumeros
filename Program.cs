using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcuatronumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, producto;
            Console.WriteLine("suma y producto de cuatro numeros");
            Console.WriteLine("digite numero1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite numero2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite numero3");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite numero4");
            num4 = int.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("la suma es:"+suma);
            producto = num3 * num4;
            Console.WriteLine("el producto es:"+producto);
            Console.ReadKey();


        }
    }
}
