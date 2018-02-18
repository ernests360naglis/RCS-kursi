using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MĀJASDARBS:
// 2) izveidot FizzBuzz* (patstāvīgi)

// (+) FizzBuzz:
//Lietotne skaita no 1 līdz 100
//Ja skaitlis dalās ar 3, lietotne izvada uz ekrāna "Fizz"
//Ja skaitlis dalās ar 5, lietotne izvada uz ekrāna "Buzz"
//Ja skaitlis dalās ar gan ar 3, gan ar 5, lietotne izvada uz ekrāna "FizzBuzz"
//Ja skaitlis nedalās ne ar 3, ne ar 5, lieotne izvada uz ekrāna pašu skaitli

//Bonuspunkti:
//1. (+) Bonuspunkts: 
//Lietotne ļauj lietotājam ievadīt augšējo robežu(līdz cik skaitļiem jāizvada)
//2. Bonuspunkts:
// (+) Lietotne nenocrasho, ja lietotājs pieprasa izvadīt FizzBuzz līdz vienam kvadriljonam(1 000 000 000 000 000)
//nezināmais [long] satur skaiļus no –9,223,372,036,854,775,808 līdz 9,223,372,036,854,775,807)

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
            long maxNum;
            maxNum = long.Parse(Console.ReadLine());
            //ciklam atkārtoties tik ilgi kamēr šis skaitlis būs ne lielāks par 100
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
}//for ( int tryCount = 1; tryCount <= 4 && !hasUserWon; tryCount = tryCount + 1)
//int maxNumber = int.Parse(Console.ReadLine());

