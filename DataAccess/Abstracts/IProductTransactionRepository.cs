using Core.Repository;
using Core.Entities;


namespace DataAccess.Abstracts;

public interface IProductTransactionRepository: IAsyncRepository<ProductTransaction>, IRepository<ProductTransaction>
{
}
