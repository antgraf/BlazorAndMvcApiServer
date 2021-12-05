using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerApi.Api
{
    // api/Api
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        // GET: ApiController
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return Repo.Strings;
        }

        // GET: ApiController/5
        [HttpGet("{id}", Name = "Get")]
        public string Details(int id)
        {
            return Repo.Strings[id];
        }

        // POST: ApiController
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public int Create([FromBody] string str)
        {
            Repo.Strings.Add(str);
            return Repo.Strings.Count - 1;
        }

        // PUT: ApiController
        [HttpPut]
        //[ValidateAntiForgeryToken]
        public int Edit([FromBody] ApiDto obj)
        {
            Repo.Strings[obj.Id] = obj.Str;
            return obj.Id;
        }

        // DELETE: ApiController/5
        [HttpDelete("{id}")]
        //[ValidateAntiForgeryToken]
        public int Delete(int id)
        {
            Repo.Strings[id] = string.Empty;
            return id;
        }
    }
}
