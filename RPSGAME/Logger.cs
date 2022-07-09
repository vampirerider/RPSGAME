using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGAME
{
    public static class Logger
    {
        public static void writelog(string message)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string logPath = ConfigurationManager.AppSettings["logpath"];
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
            }
#pragma warning restore CS8604 // Possible null reference argument.
        }
    }
}
