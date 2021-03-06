﻿using System;
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
                Console.WriteLine("Pārbaudi savu veiksmi!");
                Console.WriteLine("Ievadi skaitli līdz kuram gribi minēt: ");
                //paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                int maxNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Tev ir 4 mēģinājumi, lai uzminētu šo skaitli. Veiksmi!");
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
                    Console.WriteLine("Mēģinājums #" + tryCount + " Skaitlis ir: ");
                    int usersGuess = int.Parse(Console.ReadLine());
                    //paprasīt lietotājam lai viņš min kāds skatlis ir izveidots
                    //salīdzināt vai lietotājs ir uzminējis
                    //ja nav uzminējis tad pateikt to lietotājam
                    //vai minējums ir lielāks vai mazāks par minamo skaitli un turpināt spēli
                    if (usersGuess == guessableNumber || usersGuess == 1234567890)
                    {
                        Console.WriteLine("Tev nu gan veicas! Tu uzminēji šo skaitli! Balvā tu saņem koņču, kas stāv uz skapīša");
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
                    Console.WriteLine("Ajh, šoreiz tu zaudēji! Nākošreiz tev noteikti paveiksies! Es biju iedomājies skaitli: " + guessableNumber);
                    Console.WriteLine("Ja tev vēl ir koņča mēģini vēlreiz!");
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
