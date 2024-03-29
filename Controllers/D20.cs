using Microsoft.AspNetCore.Mvc;
using Project1Library;

namespace Class_API.Controllers
{

    [Route("[controller]")]
    [ApiController]

    //route is .../d20/...

    public class D20 : Controller
    {

        [HttpPost("{NumOfRolls}")]

        public string D20Rolls(int NumOfRolls)
        {
            var D20 = new Die20();

            //double array to store the roll results
            double[] arr1 = new double[1000];
            string[] logArr = new string[1000];

            string NumRolls = NumOfRolls.ToString();

            //Does the correct number of rolls and prints them to console and logs them
            Logger.Log("Your 20 sided dice was rolled " + NumRolls + " times and the results were: ");
            for (int i = 0; i < NumOfRolls; i++)
            {
                //Calls the D6 method to roll a 6 sided Die, prints roll result to Console
                arr1[i] = D20.Roll();

                //Logs roll to Logging array
                logArr[i] = arr1[i].ToString();

                Logger.Log(logArr[i]);
            }

            //Returns that the dice was rolled successfully
            return "Your 20 sided dice was rolled " + NumRolls + " times!";
        }

        [HttpPost]

        public string ErrorMessage()
        {
            return "Please input the number of times you want to roll the 20 sided dice";
        }

    }
}
