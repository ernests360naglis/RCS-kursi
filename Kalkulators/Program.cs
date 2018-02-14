using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulators
{
    class Program
    {
        static void Main(string[] args)
        {
            RadiusaAprēķināšana();
                                  // Ctrl + K D
                                    //Turot Ctrl spiež K, tad D
            DivuSkaitļuSaskaitīšana();
        }

        static void DivuSkaitļuSaskaitīšana()
        {
                               //izveidojam mainīgo, kur glabāt lietotāja ievadīto pirmo skaitli
            double cipars1;
                                 //izsaucam skaitļa iegūšanas f-ciju, rezultātu ierakstam mainīgajā
            cipars1 = GetNumberFromUser("lūdzu ievadiet pirmo skaitli");
                              //izveidojam mainīgo, kur glabāt lietotāja ievadīto otro skaitli
            double cipars2;
            cipars2 = GetNumberFromUser("lūdzu ievadiet otro skaitli");
                                //izveidojam mainīgo, kurā glabāt rezultātu
            double result;
                                    //aprēķinām rezultātu un ierakstam mainīgajā
            result = cipars1 + cipars2;
            Console.WriteLine("Rezultāts: " + result);
            Console.ReadLine();
            
        }

        static void RadiusaAprēķināšana()
        {
                                     //izveidojam mainīgo, kur glabāt R
            double radius;
                                             //izveidosim mainīgu, kur glabāt rezultātu
            double result;
                                         //pie''sķirsim radisusa mainīgajam vērtību
            radius = GetNumberFromUser("Lūdzu ievadiet rādiusu");
                                          //veicam aprēķināšanas operāciju
            result = radius * radius * 3.14;
                                      //parādam rezultātu lietotājam
            Console.WriteLine("Rezultāts: " + result);
            Console.ReadLine();
        }

        static double GetNumberFromUser(string msg)
        {
                               //izvadam f-cijai iedoto paziņojumu
            Console.WriteLine(msg);
                                  //nolasam lietotāja ievadi no ekrāna un ierakstam teksta mainīgo
            string ievadītaisTeksts = Console.ReadLine();
                                     //izveidojam mainīgo, kur glabāt apaļo skaitli
            double parsedNumber;
            //ievadīto tekstu pārveidojam par skaitli un ierakstam mainīgo
            bool parseWasSuccess = double.TryParse(ievadītaisTeksts, out parsedNumber);
            if (parseWasSuccess == false)
            {
                Console.WriteLine("slikti ievadīts skaitlis " + ievadītaisTeksts);
                Console.WriteLine("ievadi skaitli vēlreiz");
                parsedNumber = GetNumberFromUser(msg);
            }
            else
            {
                Console.WriteLine("Brīnišķīgi ievadīts skaitlis");
            }
            return parsedNumber;
        }



    }
}
