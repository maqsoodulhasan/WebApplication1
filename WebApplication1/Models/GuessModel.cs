using Microsoft.AspNetCore.Http;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    public class GuessModel
    {
        public static int AttemptCounter = 0;
        public static string CheckGuess(int guess, int randomNumber)
        {

            AttemptCounter++;
            int randomvalue = randomNumber;
            string result = "";


            if (guess < randomvalue)
                result = "Guess value " + guess + " is less than actual value ";
            else if (guess > randomvalue)
                result = "Guess value " + guess + " is greater than actual value ";
            else if (guess == randomvalue)
            {

                result = ("Guess value " + guess + " is equal the actual value. You have won the game you have guessed in " + AttemptCounter + " attemps");

            }


            else
                result = "Unknown result";
            return result;


        }
    }
}
