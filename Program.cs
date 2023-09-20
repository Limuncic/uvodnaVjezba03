using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace uvodnaVježba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Unesi stranicu x u pravokutnom trokutu: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Unesi stranicu y u pravokutnom trokutu: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Unesi stranicu z u pravokutnom trokutu: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x > y && x > z)
            {
                double suma = Math.Pow(y, 2) + Math.Pow(z, 2);

                if (Math.Pow(x, 2) == suma)
                {
                    Console.WriteLine("Dimenzije trokuta su ispravne.");
                }
                else
                {
                    Console.WriteLine("Dimenzije trokuta su pogrešno unesene.");
                }
                
            }
            else if (y > z)
            {
                double suma = Math.Pow(x, 2) + Math.Pow(z, 2);

                if (Math.Pow(y, 2) == suma)
                {
                    Console.WriteLine("Dimenzije trokuta su ispravne.");
                }
                else
                {
                    Console.WriteLine("Dimenzije trokuta su pogrešno unesene.");
                }
            }
            else
            {
                double suma = Math.Pow(y, 2) + Math.Pow(x, 2);

                if (Math.Pow(z, 2) == suma)
                {
                    Console.WriteLine("Dimenzije trokuta su ispravne.");
                }
                else
                {
                    Console.WriteLine("Dimenzije trokuta su pogrešno unesene.");
                }
            }





            Console.ReadKey();
        }
    }
}
