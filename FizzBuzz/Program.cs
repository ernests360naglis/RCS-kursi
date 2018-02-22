using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MĀJASDARBS:
//FizzBuzz

//Ja skaitlis dalās gan ar 3, gan ar 5, lietotne izvada uz ekrāna "FizzBuzz"
//Ja skaitlis dalās ar 3, lietotne izvada uz ekrāna "Fizz"
//Ja skaitlis dalās ar 5, lietotne izvada uz ekrāna "Buzz"
//Ja skaitlis nedalās ne ar 3, ne ar 5, lieotne izvada uz ekrāna pašu skaitli
//Lietotne ļauj lietotājam ievadīt augšējo robežu(līdz cik skaitļiem jāizvada)
//Lietotne nenocrasho, ja lietotājs pieprasa izvadīt FizzBuzz līdz vienam kvadriljonam(1 000 000 000 000 000)
//nezināmais [long]

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz aplikācija");
            Numbers1To100();
            Console.WriteLine("Tututututututututu. Gatavs pīrāgs! Beigas! :-)");
            Console.ReadLine();

        }

       public static void Numbers1To100()
        {
            Console.WriteLine("Izvēlies skaitli līdz kuram FizzBazzot");
            //izveidojo mainīgo kurā pieglabāt ievadīto skaitli. (Skaitlis līdz kuram FizzBazzot)
            long maxNum;
            maxNum = long.Parse(Console.ReadLine());
            //ciklam atkārtoties tik ilgi kamēr šis skaitlis būs ne lielāks par ievadīto skaitli līdz kuram FizzBazzot
            for (long num = 1; num <= maxNum; num = num + 1)
            {
                //ja šim skaitlis daloties ar 3 un 5 veidojas modilis 0, tad uzrakstīt "FizzBuzz"
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //ja šim skaitlim daloties ar 3 veidojas modulis 0, tad uzrakstīt "Fizz"
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //ja šim skaitlim daloties ar 5 veidojas modilis 0, tad uzraksīt "Buzz"
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //ja neviens no iepriekšējiem neizpildās, tad parādīt pašu skaitli
                else
                {
                    Console.WriteLine(num);
                }
                Console.ReadLine();
            }
        }
    }
}