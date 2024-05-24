using BusinessObjects.Model;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repositories.Respositories;
using System.Collections.Generic;
using System;
using Repositories.UnitOfWork;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
       // private ICategoryService _repository;
       private IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategory()
        {
            return _unitOfWork.CategoryRepository.GetCategories();
        }

        
    }
}
