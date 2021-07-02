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
            List<Customers> customers = new List<Customers>();
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

        [HttpPost]
        public JsonResult InsertCustomers(DAL.Models.Customers customer)
        {
            Customers custObj = new Customers();
            bool status = false;
            string message;

            try
            {
                if (customer != null)
                {
                    custObj.FirstName = customer.FirstName;
                    custObj.LastName = customer.LastName;
                    custObj.EmailId = customer.EmailId;
                    custObj.SecondaryEmailId = customer.SecondaryEmailId;
                    custObj.CustomerPassword = customer.CustomerPassword;
                    custObj.Phone = customer.Phone;
                    custObj.SecondaryPhone = customer.SecondaryPhone;
                    custObj.Gender = customer.Gender;
                    custObj.DateOfBirth = customer.DateOfBirth;
                    custObj.Address = customer.Address;
                }
                else
                {
                    custObj = null;
                }

                status = repository.AddCustomers(custObj);

                if (status)
                {
                    message = "Successful addition operation";
                }
                else
                {
                    message = "Unsuccessful addition operation!";
                }
            }
            catch (Exception)
            {
                message = "Some error occured, please try again!";
            }
            return Json(message);
        }

    }
}