using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppNetFrameworkApi.Controllers
{
    public class FetchController : ApiController
    {
        // GET api/product
        public IEnumerable<Todo> Get()
        {
            return new List<Todo>
            {
                new Todo { Name = "Todo1" },
                new Todo { Name = "Todo2" },
                new Todo { Name = "Todo3" },
                new Todo { Name = "Todo4" },
                new Todo { Name = "Todo5" },
                new Todo { Name = "Todo6" },

            };
        }
    }


    public class Todo
    {
        public string Name { get; set; }
    }


}
