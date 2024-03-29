using Microsoft.AspNetCore.Mvc;
using Project1Library;

namespace Class_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    //route is .../values/...
    public class ValuesController : ControllerBase
    {
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPut]
        public string Put()
        {
            return "Puted";
        }

        [HttpPatch]
        public string Patch()
        {
            return "Patched";
        }

        [HttpOptions]
        public string Options()
        {
            return "Optioned";
        }

        //URL Arguments get value of string .../value?val1=<int>&val2=<int>
        [HttpPost]
        public string Post(string val1)
        {
            return val1;
        }

        //Route embeded to get value of int .../value/<int> <int>
        [HttpPost("{value}")]
        public string GetAverages(string value)
        { 
            return "Your input was: " + value;
        }

        //URL Arguments get value of string Postman - body - input data here
        [HttpPost]
        public string PostFromBody([FromBody] string value)
        {
            string[] numbers = value.Split(' ');

            double[] doubles = Array.ConvertAll(numbers, Double.Parse);

            return "I got your numbers from da body";
        }


        
    }
    
}
