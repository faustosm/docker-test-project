using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication {
    [Route("/api")]
    public class ApiRootController : Controller {
        [HttpGet]
        public object Get() {
            return new {
                Users = "/api/users",
                Now = DateTime.Now.ToString()
            };
        }
    }
}
