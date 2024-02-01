﻿using Core.Entities;

namespace Core.DTOs;

public class AddOrderDto
{
    public Guid UserId { get; set; }
    public IList<ProductTransaction> ProductTransactions { get; set; }
    public AddOrderDto()
    {
        ProductTransactions = new List<ProductTransaction>();
    }
}
