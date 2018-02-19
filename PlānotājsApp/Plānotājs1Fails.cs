using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlānotājsApp
{
    class Plānotājs1Fails
    {
        //šis ir konstruktors, kurš tiek izsaukts, kad tiek izveidots objekts konstruktors nekad neko neatgriež un vienmēr saucas tāpat kā klase
        public Plānotājs1Fails()
        {
            todoEntries = new List<string>();
        }
        List<string> todoEntries;

        public void AddNewTodo(string task)
        {
            Console.WriteLine();
            // ja vizuālā studija nevar atrast klasi, tad uzspiežam uz klases nosaukuma un piespiežam Ctrl + .
            Console.WriteLine("Pievienotais uzevums:" + task);
            todoEntries.Add(task);
            Console.WriteLine();
        }

        public void ShowAllTodos()
        {
            // iegūstam pirmo elementu no saraksta izmantojot indeksatoru
            //skaitītājs = skaitītājs + 1; ir tas pats kas skaitītājs += 1; ir tas pats, kas skāitītājs++
            // i ir saīsinājums no vārda indekss (latv.val. = skaitītājs)
            for(int i = 0; i < todoEntries.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("#" + (i + 1) + " Piezīme: " + todoEntries[i]);
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

        public void DeleteAllTodos()
        {
            todoEntries.Clear();
        }

        public void SaveToFile()
        {
            //Ctrl + .
            for(int i = 0; i < todoEntries.Count; i++)
            {
                File.AppendAllText(@"C:\Users\ernes\Documents\RSC kursi\ToDoSaveSettings\saveToDoSettings.txt", todoEntries[i] + "\r\n");
            }
        }
        
        public void LoadFromFile()
        {
            string[] allLinesFromFile = File.ReadAllLines(@"C:\Users\ernes\Documents\RSC kursi\ToDoSaveSettings\saveToDoSettings.txt");
            foreach (string listEntry in allLinesFromFile)
            {
                todoEntries.Add(listEntry);
            }
        }
    }
}
