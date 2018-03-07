using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
       class student
        {
            public double x;
            public double y;
            public double z;
            public int w;

            public student(double po, double mems, double meg, int index)
            {
                x = po;
                y = mems;
                z = meg;
                w = index;
            }
            public double avg()
            {
                Console.WriteLine("Srednia:");
                return ((x + y + z) / 3);
            }
        }
        static void Main(string[] args)
        {

            
            Console.WriteLine("Nr indeksu");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("PO");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("MEMS");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("MEG");
            double a = double.Parse(Console.ReadLine());
            student s1 = new student (a, b, c, d);
            Console.WriteLine(s1.avg());
            Console.ReadLine();
        }
    }
}
