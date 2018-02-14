﻿using System;
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
            //palūdzam lietotājam ievadīt savu vārdu
            //uzrakstot lūgumu ekrānā
            Console.WriteLine("Lūdzu ievadi savu vārdu:");
            //izveidojam mainīgo, kur glabāt lietotāja ievadīto vērtību
            string usersName;
            //paprasam konsolei ievadīt tekstu, saglabājam rezultātu mainīgu
            usersName = Console.ReadLine();
            Console.WriteLine("Sveiks, " + usersName + "!"); //"Sveiks, Ernests"
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!");
            Console.ReadLine();
        }
    }
}