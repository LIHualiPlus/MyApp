using MyApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services.BookService
{
    public class BookService : ServiceBase
    {

        public List<MyApp_Book> GetBooks() {
            var res = new List<MyApp_Book>();
            MyAppEntities dbcontext = new MyAppEntities();
            res= dbcontext.MyApp_Book.AsNoTracking().ToList();

            return res;
        }

    }
}
