using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//5) Izveidojam loģiku, kas parāda tikai neizdarītos uzdevumus
namespace PlānotājsApp
{
    class Plānotājs1Fails
    {
        //šis ir konstruktors, kurš tiek izsaukts, kad tiek izveidots objekts konstruktors nekad neko neatgriež un vienmēr saucas tāpat kā klase
        public Plānotājs1Fails()
        {
            todoEntries = new List<TodoListEntry>();
        }
        List<TodoListEntry> todoEntries;
        string pathTodoFile = @"C:\Users\ernes\Documents\Programmēšana\ToDoSaveSettings.txt";

        public void AddNewTodo(string task)
        {
            Console.WriteLine();
            // ja vizuālā studija nevar atrast klasi, tad uzspiežam uz klases nosaukuma un piespiežam Ctrl + .
            Console.WriteLine("Pievienotais uzevums:" + task);
            // izveido jaunu uzdevumu
            TodoListEntry usersTodo = new TodoListEntry();
            usersTodo.name = task;
            todoEntries.Add(usersTodo);
            Console.WriteLine();
        }

        public void ShowAllTodos()
        {
            // iegūstam pirmo elementu no saraksta izmantojot indeksatoru
            //skaitītājs = skaitītājs + 1; ir tas pats kas skaitītājs += 1; ir tas pats, kas skāitītājs++
            // i ir saīsinājums no vārda indekss (latv.val. = skaitītājs)

            for(int i = 0; i < todoEntries.Count; i++)
            {
                //izvadam kārtas numuru un uzdevuma nosaukumu (bet bez enter galā)
                Console.WriteLine();
                //ja uzdevums nav pabeigts, tad to parādīt, ja tas ir izdarīts, tad nerādīt.
                if (!todoEntries[i].isCompleted)
                {
                    Console.Write("#" + (i + 1) + " Piezīme: " + todoEntries[i].name);
                }
                
                //nospiežam enter
                Console.WriteLine();
            }
            
        }

        public void DeleteToDo(int indexOfTodo)
        {
            if (indexOfTodo >= this.todoEntries.Count)
            {
                Console.WriteLine();
                //ja sarakstā ir 3 ieraksti, tad pēdējais indekss ir 2
                Console.WriteLine("Tev nav šāda ieraksta!");
                Console.WriteLine();
            }
            else
            {
                todoEntries.RemoveAt(indexOfTodo);
            }
        }

        public void MarkTodoAsDone(int doneTodoIndex)
        {
            todoEntries[doneTodoIndex].isCompleted = true;
        }

        public void DeleteAllTodos()
        {
            todoEntries.Clear();
        }

        public void SaveToFile()
        {
            File.Delete(pathTodoFile);
            //Ctrl + .
            for(int i = 0; i < todoEntries.Count; i++)
            {
                string nameOfTodo = todoEntries[i].name;
                File.AppendAllText(pathTodoFile, nameOfTodo + "\r\n");
                bool izCompleted = todoEntries[i].isCompleted;
                File.AppendAllText(pathTodoFile, izCompleted + "\r\n");
            }
        }
        
        public void LoadFromFile()
        {
            if(!File.Exists(pathTodoFile))
            {
                return;
            }
            string[] allLinesFromFile = File.ReadAllLines(pathTodoFile);

            //pirms saraksta ielādes no faila, to iztīram no vecā satura
            todoEntries.Clear();

            //dodamies cauri sarakstam ar teksta rindām, kas ir ielādēta no faila
            for (var index = 0; index < allLinesFromFile.Length; index += 2)
            {
                string listEntry = allLinesFromFile[index];
                //izvedojam jaunu uzdevumu
                TodoListEntry fileTodo = new TodoListEntry();
                fileTodo.name = listEntry;
                //uzdevumam uzdodam par izpildes stāvokli vērtību, kas nolasīta no
                fileTodo.isCompleted = bool.Parse(allLinesFromFile[index + 1]);
                //jaunizveidoto uzdevumu pievienojam kopējo uzdevumu sarakstam
                todoEntries.Add(fileTodo);
            }
        }
    }
}
