﻿using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class ProductTransaction : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public virtual Product Product { get; set; }
}