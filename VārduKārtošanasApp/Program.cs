using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// (+) palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
// ielādējam visus vārdus no vārdnīcas faila
// izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
// izveidojam mainīgo, kurā piefiksēsim to, vai vārdā ir kādi nevajadzīgi burti 
// izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
// pārbaudam, vai burts atrodas vārdnīcas vārdā
// ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
// izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
// pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
// ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
// kad vārdu apstrāde pa burtiem beigusies,
// pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
// ja nav, tad izvadām vārdu uz ekrāna

namespace VārduKārtošanasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi burtus no kuriem vēlies veidot vārdu");
            string lietotājaIevadītieBurti = Console.ReadLine();
            //ielādējam visus vārdus no vārdnīcas
            string vārduIelādeNoVārdnīcas = @"C:\Users\ernes\Documents\GitHub\RCS-kursi\VārduKārtošanasApp\words.txt";
            string[] allLinesFromFile = File.ReadAllLines(vārduIelādeNoVārdnīcas);
            //izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
            foreach (var vārdiNoVārd in allLinesFromFile)
            {
                //izveidojam x kurā piefiksējam to, vai vārdā ir kādi nevajadzīgi burti
                bool vaiVārdāIrNevajadzīgiBurti = false;
                //izmantojot ciklu. apstrādājam katru burtu lietotāja ievadītajā vārdā
                foreach(char currentSymbol in lietotājaIevadītieBurti)
                {
                    //pārbaudam vai burts atrodas vārdnīcas vārdā
                    if (vārdiNoVārd.Contains(currentSymbol) == false)
                    {
                        //ja neatrodas, tad piefiksējam, ka liekie burti ir atrasti
                        vaiVārdāIrNevajadzīgiBurti = true;
                    }
                }
                // izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
                foreach(char symbol in vārdiNoVārd)
                {
                    // pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
                    if(lietotājaIevadītieBurti.Contains(symbol) == false)
                    {
                        //ja neatrodam, tad piefiksējam, ka lieks burts ir atrasts
                        vaiVārdāIrNevajadzīgiBurti = true;
                    }
                }
                // kad vārdu apstrāde pa burtiem beigusies,
                // pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
                if (vaiVārdāIrNevajadzīgiBurti == false)
                {
                    //ja nav tad izvadam vārdu uz ekrāna
                    Console.WriteLine(vārdiNoVārd);
                }

                // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                
            }
            Console.ReadLine();



        }
    }
}
