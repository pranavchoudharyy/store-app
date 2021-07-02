using System;
using System.Text;
using Choudhary.DAL;
using Choudhary.DAL.Models;
using System.Linq;
using System.Collections.Generic;

namespace Choudhary.DAL
{
    public class ChoudharyRepository
    {
        ChoudharyContext context;

        public ChoudharyRepository()
        {
            context = new ChoudharyContext();

        }

        public List<Categories> GetAllCategories()
        {
            List<Categories> categoriesList = context.Categories.ToList();
            return categoriesList;

        }

        public List<Products> GetAllProducts()
        {
            List<Products> productsList = context.Products.ToList();
            return productsList;
        }

        public List<Customers> GetAllCustomers()
        {
            List<Customers> customersList = context.Customers.ToList();
            return customersList;
        }

        public bool AddCustomers(Customers cust)
        {
            bool status;
            try
            {
                context.Customers.Add(cust);
                context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        

    }
}
