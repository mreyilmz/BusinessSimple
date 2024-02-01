using Business.Abstracts;
using Business.Tools.Exceptions;
using DataAccess.Abstracts;
using Core.DTOs;
using Core.Entities;

namespace Business.Validations;

public class OrderValidations
{
    private readonly IProductTransactionService _productTransactionService;
    private readonly IProductTransactionRepository _productTransactionRepository;

    public OrderValidations(IProductTransactionService productTransactionService, IProductTransactionRepository productTransactionRepository)
    {
        _productTransactionService = productTransactionService;
        _productTransactionRepository = productTransactionRepository;
    }
    public async Task OrderMustNotBeEmpty(Order? order)
    {
        if (order == null)
        {
            throw new ValidationException("Order must not be empty.", 500);
        }
        await Task.CompletedTask;
    }

    public async Task CheckTransactionCount(AddOrderDto addOrderDto)
    {
        if (addOrderDto.ProductTransactions.Count() == 0)
        {
            throw new ValidationException("Product list not be empty.");
        }
        await Task.CompletedTask;
    }
    public async Task CheckProductListCount(AddOrderDto addOrderDto)
    {
        if (addOrderDto.ProductTransactions.Where(t => t.Quantity == 0).Any())
        {
            throw new ValidationException("Product count must not be zero. Please check product list.");
        }
        await Task.CompletedTask;
    }
    public void CheckStock(AddOrderDto addOrderDto)
    {
        var checkCounts = addOrderDto.ProductTransactions.Select(t =>
            _productTransactionRepository.GetAll(pt => pt.ProductId == t.ProductId).Sum(transaction => transaction.Quantity) - t.Quantity
        ).Where(q => q < 0).Any();
        if (checkCounts)
        {
            throw new ValidationException("We are has not any product stock. Please check stock count");
        }

    }
}