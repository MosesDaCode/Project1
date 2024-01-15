using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public class DisplayMenus
    {
        #region MainMenu
        public static string DisplayMainMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Vilket program vill du använda?");
            Console.WriteLine("..................................");
            Console.WriteLine("1. Shapes (Spel)");
            Console.WriteLine("2. Calculator (Miniräknare)");
            Console.WriteLine("3. Sten Sax Påse (Spel)");
            Console.WriteLine("0. Avsluta program!");
            Console.WriteLine("==================================");
            Console.Write("Val: ");

            var mainChoice = Console.ReadLine();
            return mainChoice;
        }
        #endregion
        #region ShapesMenu
        public static string DisplayShapesMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Välj en form att räkna!");
            Console.WriteLine("..................................");
            Console.WriteLine("1. Rektangel");
            Console.WriteLine("2. Parallellogram");
            Console.WriteLine("3. Triangel");
            Console.WriteLine("4. Romb");
            Console.WriteLine("0. Gå tillbaka");
            Console.WriteLine("==================================");
            Console.Write("Val: ");

            var shapesChoice = Console.ReadLine();
            return shapesChoice;
        }
        public static string DisplayShapesCrud()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Välkommen till Shapes!");
            Console.WriteLine("..................................");
            Console.WriteLine("1. Starta Spelet");
            Console.WriteLine("2. Se Resultat");
            Console.WriteLine("3. Ändra resultat");
            Console.WriteLine("4. Ta bort resultat");
            Console.WriteLine("0. Gå tillbaka");
            Console.WriteLine("==================================");
            Console.Write("Val: ");

            var shapesCrudChoice = Console.ReadLine();
            return shapesCrudChoice;
        }
        public static string DisplayReadShapes()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Vilka resultat vill du se?");
            Console.WriteLine("..................................");
            Console.WriteLine("1. Se alla resultat");
            Console.WriteLine("2. Se Rektangel resultat");
            Console.WriteLine("3. se Parallellogram resultat");
            Console.WriteLine("4. Se Triangel resultat");
            Console.WriteLine("5. Se Romb resultat");
            Console.WriteLine("0. Gå tillbaka");
            Console.WriteLine("==================================");
            Console.Write("Val: ");

            var readShapesChoice = Console.ReadLine();
            return readShapesChoice;
        }
        public static string DisplayUpdateShapes()
        {

            Console.WriteLine("==================================");
            Console.WriteLine("Vad vill du ändra på?");
            Console.WriteLine("..................................");
            Console.WriteLine("1. Ändra på Rektangel");
            Console.WriteLine("2. Ändra på Parallellogram");
            Console.WriteLine("3. Ändra på Triangel");
            Console.WriteLine("4. Ändra på Romb");
            Console.WriteLine("0. Gå tillbaka");
            Console.WriteLine("==================================");
            Console.Write("Val: ");

            var updateShapesChoice = Console.ReadLine();
            return updateShapesChoice;
        }
        #endregion
        #region CalcMenu
        public static string DisplayCalcMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Välkommen till Calculator!");
            Console.WriteLine("..................................");
            Console.WriteLine("1. Börja räkna");
            Console.WriteLine("2. Se Resultat");
            Console.WriteLine("3. Ändra resultat");
            Console.WriteLine("4. Ta bort resultat");
            Console.WriteLine("0. Gå tillbaka");
            Console.WriteLine("==================================");
            Console.Write("Val: ");

            var calcCrudChoice = Console.ReadLine();
            return calcCrudChoice;
        }

        #endregion
    }
}
