using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1Library;

namespace Class_API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    //route is .../d6/...

    public class D6 : ControllerBase
    {
        [HttpPost("{NumOfRolls}")]

        public string D6Rolls(int NumOfRolls)
        {
            var D6 = new Die6();

            //double array to store the roll results
            double[] arr1 = new double[1000];
            string[] logArr = new string[1000];

            string NumRolls = NumOfRolls.ToString();

            //Does the correct number of rolls and prints them to console and logs them
            Logger.Log("Your 6 sided dice was rolled " + NumRolls + " times and the results were: ");
            for (int i = 0; i < NumOfRolls; i++)
            {
                //Calls the D6 method to roll a 6 sided Die, prints roll result to Console
                arr1[i] = D6.Roll();

                //Logs roll to Logging array
                logArr[i] = arr1[i].ToString();

                Logger.Log(logArr[i]);
            }

            D6.CalcAverages(arr1);
            
            //Returns that the dice was rolled successfully
            return "Your 6 sided dice was rolled " + NumRolls + " times!";
        }

        [HttpPost]

        public string ErrorMessage()
        {
            return "Please input the number of times you want to roll the 6 sided dice";
        }
    }
}
