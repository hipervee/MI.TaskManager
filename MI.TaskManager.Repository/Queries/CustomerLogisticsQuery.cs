using MI.TaskManager.Entities.Models;
using Repository.Pattern.Ef6;

namespace MI.TaskManager.Repository.Queries
{
    public class CustomerLogisticsQuery : QueryObject<Task>
    {
        public CustomerLogisticsQuery FromCountry(string country)
        {
            //And(x => x.Country == country);
            return null;
        }

        public CustomerLogisticsQuery LivesInCity(string city)
        {
            // And(x => x.City == city);
            return null;
        }
    }
}