using Core.Entities;
using Core.Repository;
using Core.Entities;

namespace DataAccess.Abstracts;

public interface ICategoryRepository : IAsyncRepository<Category>, IRepository<Category>
{
}

