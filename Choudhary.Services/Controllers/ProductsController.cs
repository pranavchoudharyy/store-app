using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Choudhary.DAL;
using Choudhary.DAL.Models;
using Microsoft.AspNetCore.Mvc;


namespace Choudhary.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
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
            List<Products> products = new List<Products>();
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
