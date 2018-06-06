using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            try
            {
                string readAppID = File.ReadAllText(directory + $@"\{Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().Location)}.txt");
                int.TryParse(readAppID, out int appID);
                ProcessStartInfo steamApp = new ProcessStartInfo
                {
                    FileName = @"C:\Program Files (x86)\Steam\Steam.exe",
                    Arguments = "-applaunch " + appID
                };
                Process.Start(steamApp);
            }
            catch (Exception e)
            {
                //Todo: Show some sort of window pop up or something. 
            }
        }
    }
}