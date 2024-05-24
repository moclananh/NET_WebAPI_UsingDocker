using BusinessObjects;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
      //  private readonly ApplicationDBContext _dbContext;
        private readonly IProductService _productRepository;
        private readonly ICategoryService _categoryRepository;

        public UnitOfWork(//ApplicationDBContext dbContext,
            IProductService productRepository,
            ICategoryService categoryRepository)
        {
           // _dbContext = dbContext;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }
        public IProductService ProductRepository => _productRepository;

        public ICategoryService CategoryRepository => _categoryRepository;

       /* public async Task<int> SaveChangeAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }*/
    }
}
