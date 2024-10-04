using System.Security.AccessControl;

namespace Topic_7_assignment_Casino_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Raine DeVries
            Random random = new Random();
            Boolean done = false;
            int heads = 1;
            int tails = 2;
            int flip;
            string  guess;
            int bet;
            
            //string corAnswer;
            //if (heads == answer ) corAnswer = "heads";
            //if (answer == tails) corAnswer = "tails";
            Console.WriteLine("Welcome to the Casino of DeVries");
            Console.WriteLine("How much do you want to bet?");
            int.TryParse(Console.ReadLine(), out bet);
            Console.WriteLine(" Don't lose it all! Good luck!");
            while (!done)
            {
                flip = random.Next(1, 3);
                Console.WriteLine("1. Heads?  2. tails? 3. quit?");
                guess = (Console.ReadLine());
                if (guess == "quit")
                {
                    Console.WriteLine("Thanks for playing");
                    Console.WriteLine("You have: "+bet.ToString("C"));
                    done = true;
                }

                if (guess == "heads" && flip == heads)
                {
                    Console.WriteLine("Good job! you guessed right!");
                    bet *= 2;
                    Console.WriteLine("Your at: "+bet.ToString("C"));
                }
                if (guess == "tails" && flip == tails)
                {
                    Console.WriteLine("Good job! you guessed right!");
                    bet *= 2;
                    Console.WriteLine("Your at: " + bet.ToString("C"));
                }
                else if (guess == "tails" && flip == heads)
                {
                    Console.WriteLine("Nope! it was Heads!");
                    bet /= 2;
                    Console.WriteLine("Your at: " + bet.ToString("C"));
                }
                else if (guess == "heads" && flip == tails)
                {
                    Console.WriteLine("Nope it was Tails");
                    bet /= 2;
                    Console.WriteLine("Your at: " + bet.ToString("C"));
                }
                if (bet == 100)
                {
                    Console.WriteLine("Damn 100$ is a lot of money!");
                }
        
                if (bet == 0)
                {
                    Console.WriteLine("Sorry you ran out of money!");
                    done = true;
                }
                
                
                
                        
                

                


            }


        }
    }

}
