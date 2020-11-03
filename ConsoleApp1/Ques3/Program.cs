using System;
using System.IO;

namespace Ques3
{
    class Program
    {
        public delegate void AttendanceLogHandler(string EmpId);

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

            AttendanceLogHandler del = new AttendanceLogHandler(CreateLog);
            del("E2314");
            del += new AttendanceLogHandler(MarkAttendence);
            del("E2314");
        }
    }
}
