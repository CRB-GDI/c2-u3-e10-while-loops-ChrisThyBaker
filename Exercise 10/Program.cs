namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int MenuOpp = 0;
            while (MenuOpp == 4)
            {
           
            //print menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine();


            //ask for user choise
            Console.WriteLine("Please Chosse a number from the menu:");
            MenuOpp = int.Parse(Console.ReadLine());
                //print choise

                //print 
                if (MenuOpp == 1)
                {
                    Console.WriteLine("please do 50 CAPTCHAs with 0 mistakes.");
                    Console.WriteLine("then enter you email connected to your steam acount so we can send you a form");
                    Console.WriteLine("next fill out the 500 qustion form to get a varation code");
                    Console.WriteLine("enter the varation code to reqest a new game and wait for one of our staff to conform (hope you have good internet");
                }
                else if (MenuOpp == 2)
                {
                    Console.WriteLine("Loading...............");
                }
                else if (MenuOpp == 3)
                {
                    Console.WriteLine("Options are coming soon!!!!");
                }
                else if (MenuOpp > 4 || MenuOpp < 1)
                {
                    Console.WriteLine("no");
                }

            }

        }
    }
}