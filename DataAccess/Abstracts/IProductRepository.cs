using Core.Repository;
using Core.Entities;


namespace DataAccess.Abstracts
{
    public interface IProductRepository: IAsyncRepository<Product>, IRepository<Product>
    {

    }
}
