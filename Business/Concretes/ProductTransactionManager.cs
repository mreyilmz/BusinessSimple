﻿using Business.Abstracts;
using Business.Validations;
using DataAccess.Abstracts;
using Core.Entities;


namespace Business.Concretes;
public class ProductTransactionManager : IProductTransactionService
{
    private readonly IProductTransactionRepository _productTransactionRepository;
    private readonly ProductTransactionValidations _productTransactionValidations;

    public ProductTransactionManager(IProductTransactionRepository productTransactionRepository, ProductTransactionValidations productTransactionValidations)
    {
        _productTransactionRepository = productTransactionRepository;
        _productTransactionValidations = productTransactionValidations;
    }

    public ProductTransaction Add(ProductTransaction productTransaction)
    {
        return _productTransactionRepository.Add(productTransaction);
    }

    public async Task<ProductTransaction> AddAsync(ProductTransaction productTransaction)
    {
        return await _productTransactionRepository.AddAsync(productTransaction);
    }

    public void DeleteById(Guid id)
    {
        var productTransaction = _productTransactionRepository.Get(pt => pt.Id == id);
        _productTransactionValidations.ProductTransactionMustNotBeEmpty(productTransaction).Wait();
        _productTransactionRepository.Delete(productTransaction);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var productTransaction = _productTransactionRepository.Get(pt => pt.Id == id);
        await _productTransactionValidations.ProductTransactionMustNotBeEmpty(productTransaction);
        await _productTransactionRepository.DeleteAsync(productTransaction);
    }

    public IList<ProductTransaction> GetAll()
    {
        return _productTransactionRepository.GetAll().ToList();
    }

    public async Task<IList<ProductTransaction>> GetAllAsync()
    {
        var result = await _productTransactionRepository.GetAllAsync();
        return result.ToList();
    }

    public ProductTransaction? GetById(Guid id)
    {
        return _productTransactionRepository.Get(pr => pr.Id == id);
    }

    public async Task<ProductTransaction?> GetByIdAsync(Guid id)
    {
        return await _productTransactionRepository.GetAsync(pt => pt.Id == id);
    }

    public ProductTransaction Update(ProductTransaction productTransaction)
    {
        return _productTransactionRepository.Update(productTransaction);
    }

    public async Task<ProductTransaction> UpdateAsync(ProductTransaction productTransaction)
    {
        return await _productTransactionRepository.UpdateAsync(productTransaction);
    }
}
