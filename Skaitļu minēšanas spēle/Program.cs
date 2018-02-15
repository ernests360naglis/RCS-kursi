using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaitļu_minēšanas_spēle
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Tavs uzdevums ir uzminēt skaitli no 1 līdz 10");
                Console.WriteLine("Ievadi skaitli un ceri uz veiksmi ");
                //paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                int maxNumber = int.Parse(Console.ReadLine());
                //izveidojam mainīgo, kur glabāt skaitļu ģeneratoru instanci
                Random diceNumberGenerator;
                //ierakstam mainīgā jaunizveidotā ģeneratoru
                diceNumberGenerator = new Random();
                //uzģeneŗēt gadījuma skaitli līdz šai robežai
                int guessableNumber = diceNumberGenerator.Next(1, maxNumber);

                //cikls kamēr lietotājs neuzmin
                while(true)
                {
                    //paprasīt lietotājam lai viņš min kāds skatlis ir izveidots
                    //salīdzināt vai lietotājs ir uzminējis
                    //ja nav uzminējis tad pateikt to lietotājam
                    //vai minējums ir lielāks vai mazāks par minamo skaitli un turpināt spēli
                    if ()
                    {
                        break;
                    }
                }
                //pieprasam ģeneratoram iedoto skaitli no 1 līdz 6
                int diceValue = diceNumberGenerator.Next(1, 7);
                Console.WriteLine("Tavs kauliņa metiens: " + diceValue);
                //Console.ReadLine();
                //pieprasam ģeneratoram iedot skaitli no 1 līdz 100
                //int secondDiceValue = diceNumberGenerator.Next(1, 101);
                //Console.WriteLine("Tavs kauliņa otrais metiens: " + secondDiceValue);
                Console.ReadLine();
                if (diceValue == guessableNumber)
                {
                    Console.WriteLine("Tev nu gan veicas!");
                }
                if (diceValue != guessableNumber)
                {
                    Console.WriteLine("Neuzminēji! Mēģini vēlreiz!");
                }







                if (diceValue > guessableNumber)
                {
                    Console.WriteLine("minamais skaitlis ir mazāks");
                }
                else if (diceValue < guessableNumber)
                {
                    Console.WriteLine("minamais skaitlis ir lielāks");
                }
            }
        }
    }
}
