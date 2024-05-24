using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IProductService ProductRepository { get; }

        public ICategoryService CategoryRepository { get; }

       // public Task<int> SaveChangeAsync();
    }
}
