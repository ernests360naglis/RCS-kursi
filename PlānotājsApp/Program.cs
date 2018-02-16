using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlānotājsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plānotājs1Fails list = new Plānotājs1Fails();
            while(true)
            {
                // pievienot jaunu darāmo lietu
                Console.WriteLine("Lūdzu ievadiet darāmo lietu:");
                string todoTask = Console.ReadLine();
                list.AddNewTodo(todoTask);
                // dzēst visas darāmās lietas
                // izvadīt darāmās lietas uz ekrāna
                list.ShowAllTodos();
            }
        }
    }
}
