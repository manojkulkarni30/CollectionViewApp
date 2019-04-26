using CollectionViewApp.Abstractions;
using CollectionViewApp.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollectionViewApp.Services
{
    public class MonkeyService
    {
        public async Task<List<Monkey>> GetAllMonkeysAsync()
        {
            var monkeyApi = RestService.For<IMonkeyApi>("http://montemagno.com");

            return await monkeyApi.GetAllMonkeys("monkeys.json");
        }
    }
}
