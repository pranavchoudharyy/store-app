using System;
using System.Text;
using Choudhary.DAL.Models;
using System.Linq;
using System.Collections.Generic;

namespace Choudhary.DAL
{
    public class ChoudharyRepository
    {
        ChoudharyDBContext context;
        public ChoudharyRepository()
        {
            context = new ChoudharyDBContext();

        }
        public List<Categories> GetAllCategories()
        {
            List<Categories> categoriesList = context.Categories.ToList();
            return categoriesList;

        }


    }
}
