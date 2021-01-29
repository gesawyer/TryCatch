using System;


namespace ClassmateArray
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] names = { "Grace", "Ramon", "Antonio", "Joshua", "Nick", "Jeremiah", "Wendi", "Juliana", "Nathaniel", "Tommy", "Jeffrey", "Josh", "Stephen" };
            string[] homeTown = { "Mesa,AZ", "Tigard, OR", "Beverly Hills, MI", "Novi, MI", "Canton, MI", "Crystal, MI", "Detroit, MI", "Denver, CO", "Berkley, MI", "Raleigh, NC", "Detroit, MI", "Baldwin, MI", "The Moon" };
            string[] food = { "sweet potato fries", "burgers", "focaccia barese", "nalesniki", "tacos", "burgers", "salami", "tacos", "steak", "chicken curry", "steak", "falafel", "mooncakes" };
            
           
            bool good = true;
            while (good)
            {
                Console.WriteLine("Hello! Enter a number between 1 and 13 inclusive to learn about our class.");
                
                try
                {
                    string input = GetAnswer();
                    int answer = int.Parse(input);
                    if (answer > 13 || answer < 1)
                    {
                        throw new Exception("A number between 1 and 13 please!");
                        good = false;
                    }
                    else
                    {
                    bool tryAgain = true;
                    do
                        {

                            Console.WriteLine("That student is " + (names[answer]));
                            Console.WriteLine("Would you like to learn about this student's hometown(1) or favorite food(2)? Please enter 1 or 2.");
                            string secChoice = Console.ReadLine();
                            int choice = int.Parse(secChoice);
                            if (choice == 1)
                            {
                                Console.WriteLine("This student is from " + (homeTown[answer]));
                                tryAgain = false;
                            }
                            
                            else if (choice == 2)
                            {
                                Console.WriteLine("This student's favorite food is " + (food[answer]));
                                tryAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("Try again with a 1 or a two please!");
                                tryAgain = true;
                            }
                        }
                        while (tryAgain);
                    }
                  
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Try once more.");
                }
                finally
                {
                    Console.WriteLine("Would you like to learn about another student? Y/N");
                    string c = Console.ReadLine();
                    string goAgain = c.ToLower();
                    if (goAgain == "y")
                    {
                        good = true;
                    }
                    else
                    {
                        good = false;
                    }
                }   
            }    
        }
        public static string GetAnswer()
        {
            string ans = Console.ReadLine();
            return ans;
        }
    }
}
