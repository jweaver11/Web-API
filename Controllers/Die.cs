using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1Library;

namespace Class_API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    //route is .../die/...

    public class Die : ControllerBase
    {
        [HttpPost("{value}")]
        public string DiceRoll(string value)
        {
            string[] numbers = value.Split(' ');

            double[]? doubles = Array.ConvertAll(numbers, Double.Parse);

            var temp = new Project1Library.Die(numbers.Length);

            temp.allRolls = Array.ConvertAll(numbers, Double.Parse);

            temp.CalcAverages(doubles);

            Logger.Log(value);

            return "Posted from Die endpoint!";
        }

    }
}
