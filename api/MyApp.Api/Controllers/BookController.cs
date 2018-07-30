using MyApp.Data;
using MyApp.Services.BookService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyApp.Api.Controllers
{
    public class BookController : ApiController
    {
        private readonly BookService _bookService;
        // GET: Order
        public BookController()
        {
            _bookService = new BookService();
            
        }

        [System.Web.Http.ActionName("GetBooks")]
        [System.Web.Http.HttpGet]
        public List<MyApp_Book> GetBooks() {
            return _bookService.GetBooks();
        }

        [System.Web.Http.ActionName("GetHeroes")]
        [System.Web.Http.HttpGet]
        [AllowAnonymous]
        public hero[] GetHeroes()
        {
            System.Web.HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            var a = new hero[1];
            a[0]=new hero()
            {
                id = "11",
                name = "ssss"

            };
            return a;
        }

        public class hero {
            public string id { get; set; }
            public string name { get; set; }
        }
    }
}