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
    internal class WriteToList
    {
       public static void writeToList(string file_path)
        {
            var collection_list = new List<string>();
            string[] lines = File.ReadAllLines(file_path);
            ColourPrint.ColourPrintBlue("\nВычисляю время, затраченное на вставку строк в коллекцию List<T>:");
            var timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < lines.Length; i++)
            {
                collection_list.Add(lines[i]);
            }
            timer.Stop();
            ColourPrint.ColourPrintYellow($" время вставки строк в коллекцию List<T> составило {timer.Elapsed}");
        }
    }
}
