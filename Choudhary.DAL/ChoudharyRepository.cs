using System;
using System.Text;
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

        public List<Category> GetAllCategories()
        {
            List<Category> categoriesList = context.Categories.ToList();
            return categoriesList;

        }

        public List<Product> GetAllProducts()
        {
            List<Product> productsList = context.Products.ToList();
            return productsList;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customersList = context.Customers.ToList();
            return customersList;
        }

    }
}
