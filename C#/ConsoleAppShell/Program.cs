using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppShell
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("chrome.exe", "https://script.google.com/macros/s/AKfycbyCfWSjQV15SzMt5DNcSVb5C4iMZ7bufOWsEc2o/exec");
            System.Threading.Thread.Sleep(5000); // приостановить выполнение программы на 5 секунд
        }
    }
}
