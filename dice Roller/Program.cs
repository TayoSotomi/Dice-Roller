using System;
using System.Reflection;



// Create an application that simulates dice rolling.
Console.WriteLine("welcome to Tee Casino!");
int input;


bool RollAgain = true;

while(RollAgain == true)
{
    for(int i =1; i < 3; i++)
    {
        Console.WriteLine($"Roll {i} :");
        Console.WriteLine("How many sides should each die have?");

        while (int.TryParse(Console.ReadLine(), out input) == false)
        {
            Console.WriteLine("Invalid");

        }
        if (input <= 0 || input > 6)
        {
            Console.WriteLine("Not a valid number");
        }
        else
        {
            int Random1 = GetRandom2(input);
            int Random2 = GetRandom2(input);
            int Total = Random1 + Random2;

            Console.WriteLine($"You rolled a {Random1} and a {Random2}");
            Console.WriteLine(SixSided(Random1, Random2));
            Console.WriteLine(DiceOutput(Random1, Random2));
            Console.WriteLine(getTotals(Total));
        }

        Console.WriteLine("Roll Again? (y/n)");
        String nextRoll = Console.ReadLine().Trim().ToLower();

        if (nextRoll == "y")
        {
            RollAgain = true;

        }
        else if (nextRoll == "n")
        {
            RollAgain = false;
            Console.WriteLine("Thanks for playing");
        }
    }   
  
   
}








    /*
     Create a static method to generate the random numbers.
    Proper method header: 2 points
    Program generates random numbers validly within the user-specified range: 1 point
    Method returns meaningful value of proper type: 1 point
      */

   

static int GetRandom2(int max)
{
   
        Random r = new Random();
        return r.Next(1, max + 1);
 
}
Console.WriteLine(GetRandom2(6));






/*Create a static method for six-sided dice that takes two dice values as parameters, and returns a string for one of the valid combinations (e.g. Snake Eyes, etc.) or an empty string if the dice don’t match one of the combinations.
Dice combos
*/
static String SixSided(int x, int y)
{
    if (x == 1 && y == 1)
    {
        return "Snake Eyes!";
    }
    else if(x == 1 && y ==2 || x == 2 && y == 1)
    {
        return "Ace Deuce!";
    }
    else if(x==6 && y == 6)
    {
        return "Box Cars!";
    }
   
    else
    {
        return " ";
    }
}
Console.WriteLine(SixSided(2,1));


static string getTotals(int x)
{
  if (x  == 7 || x  == 11)
    {
        return "Win!";
    }
    else if (x  == 2 || x  == 3 || x  == 12)
    {
        return "Craps!";
    }
    else
    {
        return " ";
    }
}





/*Create a static method to implement output for different dice combinations
Dice totals
Proper method header: 2 points
Method recognizes all specified cases correctly: 1 point
Method displays properly to Console: 1 point
*/

static string DiceOutput(int x, int y)
{
    return $"({x + y} total)";
}
Console.WriteLine(DiceOutput(1,2));









