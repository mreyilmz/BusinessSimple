﻿using Core.DTOs;
using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IOrderService
{
    Order? GetById(Guid id);
    Task<Order?> GetByIdAsync(Guid id);
    IList<Order> GetAll();
    Task<IList<Order>> GetAllAsync();
    IList<Order> GetAllWithDetails();
    Task<IList<Order>> GetAllWithDetailsAsync();
    Order Add(AddOrderDto addOrderDto);
    Order Update(Order order);
    void DeleteById(Guid id);
    Task<Order> AddAsync(Order order);
    Task<Order> UpdateAsync(Order order);
    Task DeleteByIdAsync(Guid id);
}
