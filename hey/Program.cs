using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hey
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Witam w kalkulatorze");
            Console.WriteLine("Wybierz liczbe a");
            
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz liczbę b");
            int b = int.Parse(Console.ReadLine());
         

  
            String znak;
            Console.WriteLine("Wybierz rodzaj działania arytmetycznego: +,-,*,/");
            znak = Console.ReadLine();
            Console.WriteLine(znak);

            switch (znak)
            {
                case "+" :
                    Console.WriteLine("twoj znak to: "+ znak);
                    Console.WriteLine("Wynik dodawania a+b="+(a+b));
                    break;
                case "-":
                    Console.WriteLine("twoj znak to:" + znak );
                    Console.Write("Wynik odejmowania a-b=" + (a - b));
                    break;
                case "*":
                    Console.WriteLine("twoj  znak to:"+znak );
                    Console.WriteLine("Wynik mnożenia a*b="+a*b);
                    break;
                case "/":
                    Console.WriteLine("twoj znak to:"+znak);
                    Console.WriteLine("Wynik dzielenia a/b="+a/b);
                    break;
            }
            Console.ReadLine();
        }   
    }
}
