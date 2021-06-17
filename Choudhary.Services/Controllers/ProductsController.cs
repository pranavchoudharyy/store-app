using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Choudhary.DAL;
using Choudhary.DAL.Models;
using Microsoft.AspNetCore.Mvc;


namespace Choudhary.Services.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        ChoudharyRepository repository;

        public ProductsController()
        {
            repository = new ChoudharyRepository();
        }

        [HttpGet]
        public JsonResult GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = repository.GetAllProducts();
            }
            catch (Exception)
            {
                products = null;
            }
            return Json(products);
        }
    }
}
