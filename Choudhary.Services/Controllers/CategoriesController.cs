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
            List<Category> categories = new List<Category>();
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
