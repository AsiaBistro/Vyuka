using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mojepoprve
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int X = 5;
            double Y = 1.3;
            string nazev = "magy je kokot na nE10 ";
            double vysledek = X + Y;
            if (X>5)
            {
                Console.WriteLine(nazev + vysledek);

            }
             else if (Y==1.2)
            {
                Console.WriteLine("hovno");

            }
            else 
            { 
                Console.WriteLine("Boxic je kokot "); 
            }
            for(int i=0; i<10; i++) 
            {  
                Console.WriteLine("*" +i); 
            }*/
            string znak = "";
            while (znak != "stop") 
            {
                Console.WriteLine("Ahoj kokote, pis co chces.Krom stop.");
                znak = Console.ReadLine();
                Console.WriteLine("ty kokote ted jsi to posral a napsal jsi :" + znak);

            }
            Console.WriteLine("uz jsem y toho venku");

            Console.ReadKey();




        }
    }
}
