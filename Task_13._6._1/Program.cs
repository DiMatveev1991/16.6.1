using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;


namespace Task_13._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_path = FileSelection.fileSelection();
            WriteToLinkedList.writeToLinkedList(file_path);
            WriteToList.writeToList(file_path);
        }

    }
        
       
}
