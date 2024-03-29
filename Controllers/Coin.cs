using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1Library;

namespace Class_API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    //route is .../coin/...

    public class Coin : ControllerBase
    {

        [HttpPost]
        public string CoinFlip()
        {
            return Logger.Log("Your coin was flipped and landed on: " + Project1Library.Coin.Flip());
        }

    }
}
