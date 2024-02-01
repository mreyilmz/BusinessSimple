﻿using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(BusinessDbContext context) : base(context)
    {
    }
}
