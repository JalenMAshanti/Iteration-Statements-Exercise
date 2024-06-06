namespace IterationStatements
{
    public class Program
    {

        static void Main(string[] args)
        {
        
        
        
           // un-comment to run methods

                //CountDown();

                //Console.WriteLine("\nSecond method \n");

                //CountByThree();

                //Console.WriteLine(IsEqualorNot(6,6));

                //Console.WriteLine(EvenOrOdd(7));

                //Console.WriteLine(PosOrNeg(8));
    
                //Console.WriteLine(CanVote());

                //Console.WriteLine(ValueCheck());

                //TimesTables();        
        
        }




        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void CountDown() 
        { 
        
            for(int i = 1000; i >= -1000; i--) 
            { 
                Console.WriteLine(i);
            
            }
               
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void CountByThree() 
        {

            for (int i = 3; i <= 999; i+=3) 
            { 
                Console.WriteLine(i);
            
            }
        
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool IsEqualorNot(int num1, int num2) 
        {

            bool result = (num1 == num2) ? true : false;

            return result;
        
        }


        //Write a method to check whether a given number is even or odd

        public static string EvenOrOdd(int number) 
        {

            string result = (number % 2 == 0) ? "Even" : "Odd";
            return result;
        }

        //Write a method to check whether a given number is positive or negative

        public static string PosOrNeg(int number) 
        {
            string result = (number > 0) ? "Positive" : "Negative";
            return result;
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static string CanVote() 
        {

           
            string userInput = UserInput("Enter your age: ");
            int.TryParse(userInput, out int alt);

            string result = (alt >= 18) ? "Can Vote" : "Cannot Vote";
            return result;
        
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static string ValueCheck() 
        {

            
            string userInput = UserInput("Enter a number: ");
            int.TryParse(userInput, out int alt);

            string result = (alt > -10 && alt < 10) ? $"{alt} is in the range of -10 - 10" : $"{alt} is not in the range of -10 - 10";
            return result;
                     
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void TimesTables() 
        {
            string userInput = UserInput("Enter a number to get times tables: ");
            int.TryParse(userInput, out int alt);


            for (int i = 1; i <= 12; i++) 
            {
                Console.WriteLine($"{alt} X {i} = {alt * i}");
                
            }


        }


        // HELPER METHODS - JALEN
        public static string UserInput(string message) 
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }




    }
}
