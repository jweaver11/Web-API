using Microsoft.AspNetCore.Mvc;
using Project1Library;

namespace Class_API.Controllers
{
    
    [Route("[controller]")]
    [ApiController]

    //route is .../d10/...

    public class D10 : Controller
    {

        [HttpPost("{NumOfRolls}")]

        public string D10Rolls(int NumOfRolls)
        {
            var D10 = new Die10();

            //double array to store the roll results
            double[] arr1 = new double[1000];
            string[] logArr = new string[1000];

            string NumRolls = NumOfRolls.ToString();

            //Does the correct number of rolls and prints them to console and logs them
            Logger.Log("Your 10 sided dice was rolled " + NumRolls + " times and the results were: ");
            for (int i = 0; i < NumOfRolls; i++)
            {
                //Calls the D6 method to roll a 6 sided Die, prints roll result to Console
                arr1[i] = D10.Roll();

                //Logs roll to Logging array
                logArr[i] = arr1[i].ToString();

                Logger.Log(logArr[i]);
            }

            //Returns that the dice was rolled successfully
            return "Your 10 sided dice was rolled " + NumRolls + " times!";
        }

        [HttpPost]

        public string ErrorMessage()
        {
            return "Please input the number of times you want to roll the 10 sided dice";
        }
        
    }
}
