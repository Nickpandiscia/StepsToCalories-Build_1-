using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepsToCalories
{
    public static class FileBuilder
    {
        public static string FilePath = @"D:\text documents\program_file_function.txt";
       
        public static void CalorieLog(string userLog)
        {
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.WriteLine($"{DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")} : {userLog}");
            }
            
        }
    }
}
