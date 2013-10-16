using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymStore.Domain.Entities;

namespace GymStore.Domain.Abstract
{
    
        public interface IProductRepository
        {
            IQueryable<Product> Products { get; }
        }
    
}
