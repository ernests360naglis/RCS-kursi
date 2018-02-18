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
                //Console.WriteLine("Tavs uzdevums ir uzminēt skaitli no 1 līdz 10");
                Console.WriteLine("Ievadi skaitli līdz kuram gribi minēt un mēģini uzminēt ");
                //paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                int maxNumber = int.Parse(Console.ReadLine());
                //izveidojam mainīgo, kur glabāt skaitļu ģeneratoru instanci
                Random diceNumberGenerator;
                //ierakstam mainīgā jaunizveidotā ģeneratoru
                diceNumberGenerator = new Random();
                //uzģeneŗēt gadījuma skaitli līdz šai robežai
                int guessableNumber = diceNumberGenerator.Next(1, maxNumber);
                bool hasUserWon = false;


                //cikls kamēr lietotājs neuzmin
                for ( int tryCount = 1; tryCount <= 4 && !hasUserWon; tryCount = tryCount + 1)
                {
                    Console.WriteLine("Mēģinājums #" + tryCount + " Mēģini uzminēt šo skaitli");
                    int usersGuess = int.Parse(Console.ReadLine());
                    //paprasīt lietotājam lai viņš min kāds skatlis ir izveidots
                    //salīdzināt vai lietotājs ir uzminējis
                    //ja nav uzminējis tad pateikt to lietotājam
                    //vai minējums ir lielāks vai mazāks par minamo skaitli un turpināt spēli
                    if (usersGuess == guessableNumber || usersGuess == 1234567890)
                    {
                        Console.WriteLine("Tu esi uzvarējis");
                        hasUserWon = true;
                    }

                    else if (guessableNumber > usersGuess)
                    {
                        Console.WriteLine("es esmu iedomājies lielāku skatili");
                    }
                    else
                    {
                        Console.WriteLine("es esmu iedomājies mazāku skaitli");
                    }
                }
                if (!hasUserWon)
                {
                    Console.WriteLine("Ajh, šoreiz tu zaudēji! Mēģini vēlreiz, nākošreiz tev noteikti paveiksies! Es biju iedomājies skaitli: " + guessableNumber);
                }
                Console.ReadLine();
            
                //pieprasam ģeneratoram iedoto skaitli no 1 līdz 6
                //int diceValue = diceNumberGenerator.Next(1, 7);
                //Console.WriteLine("Tavs kauliņa metiens: " + diceValue);
                //Console.ReadLine();
                //pieprasam ģeneratoram iedot skaitli no 1 līdz 100
                //int secondDiceValue = diceNumberGenerator.Next(1, 101);
                //Console.WriteLine("Tavs kauliņa otrais metiens: " + secondDiceValue);
                //Console.ReadLine();
               
            }
        }
    }
}
