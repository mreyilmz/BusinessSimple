using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Core.Entities;


namespace DataAccess.Concretes
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(BusinessDbContext context) : base(context)
        {
        }
    }
}
