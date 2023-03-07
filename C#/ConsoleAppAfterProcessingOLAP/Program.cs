using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace ConsoleAppAfterProcessingOLAP
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1. Update Excel

            Application xlApp = new Application();
            Workbook xlBook = xlApp.Workbooks.Open(@"\\filebkk\BKK\управління операційною діяльністю\ежедневные отчеты\ЕжедневныеОтчеты.xlsb");

            xlApp.Visible = false;
            xlApp.Run("UpdPlanFact");

            System.Threading.Thread.Sleep(15000); // приостановить выполнение программы на 15 секунд

            xlBook.Close(false);
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

            System.Threading.Thread.Sleep(15000); // приостановить выполнение программы на 15 секунд

        // 2. Start Script
            Process.Start("chrome.exe", "https://script.google.com/macros/s/AKfycbzR5DOObvwDrD75EsWLUDTTzxjBY7gs4W4x7GCybpJBp_bYNTuax8UspM8-lb9YJbGnsA/exec");
            System.Threading.Thread.Sleep(30000); // приостановить выполнение программы на 30 секунд

        }
    }
}
