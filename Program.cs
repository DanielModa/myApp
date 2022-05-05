using myApp.scr.Entities;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Knight arus = new Knight("Arus", 23, "Knight", 210, 21);
           Ninja wedge = new Ninja("Wedge", 23, "Ninja", 102, 20);
           Wizard jennica = new Wizard("Jennica", 23, "White Wizard", 100, 234);
           BlackWizard topapa = new BlackWizard("Topapa", 23, "Black Wizard", 120, 401);
        
           
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());

            Console.WriteLine("");

            Console.WriteLine(wedge);
            Console.WriteLine(wedge.Attack(1));
            Console.WriteLine(wedge.Attack(7));
            
            Console.WriteLine("");

            Console.WriteLine(jennica);
            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(jennica.Attack(7));

            Console.WriteLine("");

            Console.WriteLine(topapa);
            Console.WriteLine(topapa.Attack(1));
            Console.WriteLine(topapa.Attack(7));
        }
    }
}