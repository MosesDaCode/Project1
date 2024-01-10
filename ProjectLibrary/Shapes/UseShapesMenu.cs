using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectLibrary.Shapes
{
    public class UseShapesMenu
    {
        public static void ShowShapesMenu()
        {
            Console.WriteLine("Regler för Shapes");
            Console.WriteLine("====================================");
            Console.WriteLine("Du väljer en av fyra former som kommer visas inom kort." +
                "\nSedan ska du ange ett antal faktorer som ska hjälpa dig att" +
                "\nräkna ut Omkrets och Area på den valda formen.");
            while (true)
            {
                switch (DisplayMenus.DisplayShapesMenu())
                {

                }
            }
        }
    }
}
