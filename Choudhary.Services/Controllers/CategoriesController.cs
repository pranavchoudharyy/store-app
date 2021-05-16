using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Choudhary.DAL;
using Choudhary.DAL.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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


        // GET: api/values
        [HttpGet]
        public JsonResult GetAllCategories()
        {
            List<Categories> products = new List<Categories>();
            try
            {
                products = repository.GetAllCategories();
            }
            catch (Exception)
            {
                products = null;
            }
            return Json(products);
        }




        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
