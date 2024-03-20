namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int MenuOpp = 0;
            int OptionsOpp = 0;
            int loading = 100;
            int loading_precent = 0;
            Random rnd = new Random();
            while (MenuOpp != 4)
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
                    if (loading <= 0)
                    {
                        loading = 100;
                        loading_precent = 0;
                    }
                    Console.WriteLine("Loading...............");
                    while (loading > 0)
                    {
                        
                        int tick1 = rnd.Next(1, 21);
                      
                        if (tick1 < 10)
                        {
                            int tick2 = rnd.Next(1, 11);
                            if (tick2 >= 7)
                            {
                                loading--;
                                loading_precent++;
                                Console.WriteLine(loading_precent + "%");
                            }

                        }
                        else if (tick1 == 20)
                        {
                            loading -= 5;
                            loading_precent += 5;
                            Console.WriteLine(loading_precent + "%");
                        }


                    }
                }
                else if (MenuOpp == 3)
                {
                    while(OptionsOpp != 4)
                    {
                        //print Options
                        Console.WriteLine("**************");
                        Console.WriteLine("Options:");
                        Console.WriteLine("1 - Coming soon");
                        Console.WriteLine("2 - Coming soon");
                        Console.WriteLine("3 - Coming soon?");
                        Console.WriteLine("4 - back");
                        Console.WriteLine("**************");
                        Console.WriteLine();
                        Console.WriteLine("Please Chosse a number from the options:");
                        OptionsOpp = int.Parse(Console.ReadLine());
                        if (OptionsOpp == 1 || OptionsOpp == 2 || OptionsOpp == 3)
                        {
                            Console.WriteLine("Coming soon......");
                            MenuOpp = 0;
                        }
               
                    }
                if (OptionsOpp == 4)
                    {
                        OptionsOpp = 0;
                    }

                }
                else if (MenuOpp > 4 || MenuOpp < 1)
                {
                    Console.WriteLine("no");
                }
            
            }

        }
    }
}