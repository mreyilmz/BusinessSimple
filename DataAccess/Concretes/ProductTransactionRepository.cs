﻿using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concretes;

public class ProductTransactionRepository : Repository<ProductTransaction>, IProductTransactionRepository
{
    public ProductTransactionRepository(BusinessDbContext context) : base(context)
    {
    }
}
