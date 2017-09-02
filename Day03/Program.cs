using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            float c = 3.5f;
            float d = 5.3f;

            Swap(a, b);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Swap(ref c, ref d);

            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        /// <summary>
        /// call by Value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(int a, int b)
        {
            int c = 0;

            c = a;
            a = b;
            b = c;
        }

        /// <summary>
        /// Call by reference
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref int a, ref int b)
        {
            int c = 0;

            c = a; //main->a
            a = b; //main->b
            b = c;
        }

        /// <summary>
        /// Call by Reference float Type
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref float a, ref float b)
        {
            float c = 0;

            c = a; //main->a
            a = b; //main->b
            b = c;
        }
    }
}
