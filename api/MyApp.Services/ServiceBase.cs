using MyApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class ServiceBase
    {
        private MyAppEntities _dbContext;

        public virtual MyAppEntities DBContext
        {
            get
            {
                _dbContext = new MyAppEntities();
                return _dbContext;
            }
        }
    }
}
