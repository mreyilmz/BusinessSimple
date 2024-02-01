using Core.Repository;
using Core.Entities;


namespace DataAccess.Abstracts;

public interface IOrderRepository: IAsyncRepository<Order>, IRepository<Order>
{
}
