using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13._6._1
{
    internal class FileSelection
    {
       public  static string fileSelection()
        {
            ColourPrint.ColourPrintBlue("\nУкажите полный путь до тестируемого текстового файла:");
            string file_path = Console.ReadLine();
            // string file_path = @"T:\204.3\Сотрудники\Матвеев\Загрузки\Text1.txt";
            if (File.Exists(file_path))
            {
                ColourPrint.ColourPrintGreen ("\nФайл найден и принят программой.");
                return file_path;
            }
            else
            {
                do
                {
                    ColourPrint.ColourPrintRed("\nФайл не найден или не существует.");
                    ColourPrint.ColourPrintBlue("\nУкажите полный путь до тестируемого текстового файла еще раз:");
                    file_path = Console.ReadLine();
                }
                while (!File.Exists(file_path));
                {
                    ColourPrint.ColourPrintGreen("Файл найден и принят программой.");
                    return file_path;
                }
            }
        }
    }
}
