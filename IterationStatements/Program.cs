namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void ReverseThousandCount()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void ThreeCount()
        {
            for (int i = 1; i*3 <= 999; i++)
            {
                Console.WriteLine($"{i*3}");
            }
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not
        static bool AreEqual(int checkFirst, int checkSecond)
        {
            return checkFirst == checkSecond;
        }
        //Write a method to check whether a given number is even or odd
        static bool IsEven(int numEven)
        {
            return numEven % 2 == 0;
        }
        //Write a method to check whether a given number is positive or negative
        static string IsPositive(int numPositivity)
        {
            return numPositivity > 0 ? "Positive" : (numPositivity == 0 ? "Zero" : "Negative");
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        static bool LegalVoteCheck()
        {
            int attemptCount = 0;
            do
            {
                Console.WriteLine("What is your current Age?");
                var userAge = Console.ReadLine();
                int trueAge;
                bool parsedTrue = int.TryParse(userAge, out trueAge);
                if (parsedTrue)
                {
                    if (trueAge >= 18)
                    {
                        return true;
                    }
                    
                    Console.WriteLine("You are not of legal voting age.");
                    return false;
                    
                }

                Console.WriteLine("Invalid Input. Try again.");
                attemptCount++;
                
            } while (attemptCount < 3);
            
            Console.WriteLine("Too many invalid inputs. Exiting.");
            
            return false;
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static bool RangeCheck(int userNum)
        {
            return userNum is <= 10 and >= -10;
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void DisplayMultiTable(int multiple)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{multiple} x {i} = {multiple * i}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Thousand Count 
            ReverseThousandCount();
            
            //Three count to 999
            ThreeCount();
            
            //Equality check
            Console.WriteLine("What are your two numbers to check for equality?");
            var userNum1 = int.Parse(Console.ReadLine());
            var userNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine(AreEqual(userNum1, userNum2) ? "They are equal!" : "They're not equal I'm afraid.");
            
            //Even number check
            Console.WriteLine("We'll see if your first number was even:");
            
            Console.WriteLine(IsEven(userNum1) ? "It is even!" : "Its not even...");
            
            //Positive vs Negative vs Zero check
            Console.WriteLine("But if we subtract the first from the second, would it be positive?");
            
            switch (IsPositive(userNum2 - userNum1))
            {
                case "Positive":
                    Console.WriteLine($"{userNum2} - {userNum1} is positive!");
                    break;
                case "Zero":
                    Console.WriteLine($"{userNum2} - {userNum1} is actually zero, huh.");
                    break;
                case "Negative":
                    Console.WriteLine($"{userNum2} - {userNum1} is actually negative...");
                    break;
                default:
                    Console.WriteLine("There's an error somewhere...");
                    break;
            }
            
            //Legal Voting Check
            if (LegalVoteCheck())
            {
                Console.WriteLine("You are of legal voting age!");
            }
            
            //Range Check
            Console.WriteLine("What number would you like to check if it is in the range -10 to 10?");

            var userRangeNum = int.Parse(Console.ReadLine());

            Console.WriteLine(RangeCheck(userRangeNum)
                ? "It is in range -10 to 10!"
                : $"{userRangeNum} is not in range -10 to 10...");

            //Multiplication table
            Console.WriteLine("What number would you like a multiplication table of?");
            
            var userMultiple = int.Parse(Console.ReadLine());
            
            DisplayMultiTable(userMultiple);
        }
    }
}
