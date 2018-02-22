using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //izsaucam savis izveidoto f-ciju
            SayHello();
            //izsaucam savu otro izveidoto f-ciju
            SayHelloToUser();
        }

        static void SayHelloToUser()
        {
            //palūdzam lietotājam ievadīt savu vārdu, izvadot to Konsolē
            Console.WriteLine("Lūdzu ievadi savu vārdu:");
            //izveidojam mainīgo, kur glabāt lietotāja ievadīto vērtību
            string usersName;
            usersName = Console.ReadLine();
            string age;
            Console.WriteLine("Lūdzu ievadi savu vecumu:");
            age = Console.ReadLine();
            //paprasam konsolei ievadīt tekstu, saglabājam rezultātu mainīgu
            Console.WriteLine("Labdien, " + usersName + "!" + " Tavs vecums ir " + age + "!"); //"Sveiks, Ernests"
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!");
            Console.ReadLine();
        }
    }
}
