using System;
using System.Collections.Generic;
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
            // ja vizuālā studija nevar atrast klasi, tad uzspiežam uz klases nosaukuma un piespiežam Ctrl + .
            Console.WriteLine("Uzdevums pievienots:" + task);
            todoEntries.Add(task);
        }

        public void ShowAllTodos()
        {
            // iegūstam pirmo elementu no saraksta izmantojot indeksatoru
            //skaitītājs = skaitītājs + 1; ir tas pats kas skaitītājs += 1; ir tas pats, kas skāitītājs++
            // i ir saīsinājums no vārda indekss (latv.val. = skaitītājs)
            for(int i = 0; i < todoEntries.Count; i++)
            {
                Console.WriteLine("Tava piezīme: " + todoEntries[i]);
            }
            
        }
    }
}
