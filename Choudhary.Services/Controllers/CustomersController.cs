using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Choudhary.DAL;
using Choudhary.DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Choudhary.Services.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        ChoudharyRepository repository;

        public CustomersController()
        {
            repository = new ChoudharyRepository();
        }


        [HttpGet]
        public JsonResult GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                customers = repository.GetAllCustomers();
            }
            catch (Exception)
            {
                customers = null;
            }
            return Json(customers);
        }

    }
}