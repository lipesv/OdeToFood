using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration Configuration){
            _configuration = Configuration;
        }
        
        string IGreeter.GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}