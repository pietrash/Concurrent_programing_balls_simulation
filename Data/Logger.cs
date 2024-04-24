using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Logger
    {
        public static void CheckFile()
        {
            string currentPath = $"{AppDomain.CurrentDomain.BaseDirectory}/Logs.json";
            if (File.Exists(currentPath))
            {
                File.Delete(currentPath);
            }
        }

        public static void WriteData(double radius, double posX, double posY, double velX, double velY, int id)
        {
            
            string dataString = "\n" +
            "ID: " + id + "\n" +
            "Radius: " + radius + "\n" +
            "Current xPos: " + posX.ToString("N2") + "\n" +
            "Current yPos: " + posY.ToString("N2") + "\n" +
            "Current speedX: " + velX.ToString("N2") + "\n" +
            "Current speedY: " + velY.ToString("N2") + "\n";

            try
            {
                using StreamWriter file = new ($"{AppDomain.CurrentDomain.BaseDirectory}/Logs.json", append: true);
                file.Write(dataString);
                file.Close();
            } catch (IOException) { }
        }
    }
}
