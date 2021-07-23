using Microsoft.AspNetCore.Mvc;
using demo.core;

namespace demo.host.Controllers
{
    public class HomeController : ControllerBase
    {

        private IStore _store;

        public HomeController(IStore store)
        {
            _store = store;
        }

        [Route("index/{key}/{value}")]
        public IActionResult Index(string key, string value)
        {
            _store.StoreWrite(key, value);
            return null;
        }

    }
}
