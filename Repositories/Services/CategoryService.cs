using BusinessObjects.Model;
using DataAccess.DAOs;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Respositories
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories() => CategoryDAO.GetCategories();
    }
}
