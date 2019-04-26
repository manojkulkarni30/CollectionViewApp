using CollectionViewApp.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollectionViewApp.Abstractions
{
    public interface IMonkeyApi
    {
        [Get("/{path}")]
        Task<List<Monkey>> GetAllMonkeys(string path);
    }
}
