using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppNetFrameworkApi.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/product
        public IEnumerable<Product> Get()
        {
            return new List<Product>
            {
                new Product { Name = "Producto1" },
                new Product { Name = "Producto2" },
                new Product { Name = "Producto2" },
                new Product { Name = "Producto2" },
                new Product { Name = "Producto2" },
                new Product { Name = "Producto2" },

            };
        }
    }


        public class Product
        {
            public string Name { get; set; }
        }


    }
