using Microsoft.AspNetCore.Mvc;

namespace ForOC.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return new ContentResult
            {
                ContentType = "text/html",
                Content = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=\\, initial-scale=1.0\">\r\n" +
                "<title>Document</title>\r\n</head>\r\n<body>\r\n <ul>\r\n <li>\r\n<a href=\"api/products\">Показать товары</a>\r\n</li>\r\n" +
                "<li>\r\n<a href=\"/api/customers\">Показать клиентов</a>\r\n</li>\r\n <li>\r\n<a href=\"api/healthcheck\">Проверка состояния</a>\r\n</li>\r\n</ul>\r\n </body>\r\n</html>"
            };
        }
    }
}
