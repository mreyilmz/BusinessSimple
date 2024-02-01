using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Core.Entities;


namespace DataAccess.Concretes
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BusinessDbContext context) : base(context)
        {
        }
    }
}
