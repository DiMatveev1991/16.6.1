using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Task_13._6._1
{
    internal class WriteToLinkedList
    {
       public static void writeToLinkedList(string file_path)
        {
            var collection_linked_list = new LinkedList<string>();
            string[] lines = File.ReadAllLines(file_path);
            ColourPrint.ColourPrintBlue("\nВычисляю время, затраченное на вставку строк в коллекцию LinkedList<T>:");
            var timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < lines.Length; i++)
            {
                collection_linked_list.AddLast(lines[i]);
            }
            timer.Stop();
            ColourPrint.ColourPrintYellow ($" время вставки строк в коллекцию LinkedList<T> составило {timer.Elapsed}");
        }
    }
}
