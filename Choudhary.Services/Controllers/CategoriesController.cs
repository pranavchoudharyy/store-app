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
    public class CategoriesController : Controller
    {
        ChoudharyRepository repository;

        public CategoriesController()
        {
            repository = new ChoudharyRepository();
        }



        [HttpGet]
        public JsonResult GetAllCategories()
        {
            List<Categories> categories = new List<Categories>();
            try
            {
                categories = repository.GetAllCategories();
            }
            catch (Exception)
            {
                categories = null;
            }
            return Json(categories);
        }
    }
}
