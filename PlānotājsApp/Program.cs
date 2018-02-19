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
            list.LoadFromFile();
            while (true)
            {
                Console.WriteLine("Lūdzu izvēlieties darbību: ");
                Console.WriteLine("a - Pievienot pierakstu");
                Console.WriteLine("b - Parādīt ierakstus");
                Console.WriteLine("c - Dzēst ierakstu");
                Console.WriteLine("cv - Dzēst visus ierakstus");
                Console.WriteLine("s - Saglabāt");
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {
                    case "a":
                        // pievienot jaunu darāmo lietu
                        Console.WriteLine();
                        Console.WriteLine("Lūdzu ievadiet darāmo lietu:");
                        string todoTask = Console.ReadLine();
                        list.AddNewTodo(todoTask);
                        break;
                    case "b":
                        // izvadīt darāmās lietas uz ekrāna
                        list.ShowAllTodos();
                        break;
                    case "c":
                        // dzēst konkrētu lietu
                        Console.WriteLine();
                        Console.WriteLine("Ievadi ieraksta numuru, kuru gribi dzēst");
                        list.ShowAllTodos();
                        int index = int.Parse(Console.ReadLine());
                        list.DeleteToDo(index - 1);
                        break;
                    case "cv":
                        //lai ātri orientētos pa kodiem. Var uzspiest f12
                        list.DeleteAllTodos();
                        Console.WriteLine();
                        break;
                    case "s":
                        //saglabājam saturu failā
                        Console.WriteLine();
                        list.SaveToFile();
                        break;
                    //implementējam ielādi no faila izmantojot funkciju: File.ReadAllLines(path);
                    case "show":
                        list.LoadFromFile();
                        break;
                }
            }
        }
    }
}
