using Core.Repository;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IOrderDetailRepository: IAsyncRepository<OrderDetail>, IRepository<OrderDetail>
{

}
