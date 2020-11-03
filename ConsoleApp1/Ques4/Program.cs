using System;
using System.IO;

namespace Ques4
{
    class Program
    {
        static StreamWriter log;

        static void CreateLog(string EmpId)
        {
            if (!File.Exists("file.txt"))
            {
                File.Create("file.text");
            }
            else
            {
                Console.WriteLine("Log file already exist");
            }
        }
        static void MarkAttendence(string EmpId)
        {
            log = new StreamWriter("sw");
            log.Write($"{EmpId} has marked present on {DateTime.Now}");
        }
        static void Main(string[] args)
        {
            Action<string> one = CreateLog;
            one("E2314");
            Action<string> two = MarkAttendence;
            two("E2314");
        }
    }
}
