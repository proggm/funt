using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] fir = new int[10];
            for(int i = 0; i < fir.Length; i++)
            {
                fir[i]=random.Next(-15,15);
            }
            foreach(int item in fir)
            {
                Console.WriteLine(item+"\t");
            }
            Console.WriteLine($"Минимальный элемент: {Zero(fir)}");
            Console.ReadKey();
        }
        static int Zero(int[] fir)
        {
            int first = fir[0];
            for(int i = 0; i < fir.Length/2; i++)
            {
                if (first > fir[i])
                {
                    first = fir[i];
                }
            }
            return first;
        }
    }
}
