using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Core.Entities;


namespace DataAccess.Concretes;

public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(BusinessDbContext context) : base(context)
    {
    }
}
