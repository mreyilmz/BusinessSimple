using Business.Abstracts;
using Business.Validations;
using DataAccess.Abstracts;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class ProductManager : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly ProductValidations _productValidations;

    public ProductManager(IProductRepository productRepository, ProductValidations productValidations)
    {
        _productRepository = productRepository;
        _productValidations = productValidations;
    }

    public Product Add(Product product)
    {
        return _productRepository.Add(product);
    }

    public async Task<Product> AddAsync(Product product)
    {
        return await _productRepository.AddAsync(product);
    }

    public void DeleteById(Guid id)
    {
        var product = _productRepository.Get(p => p.Id == id);
        _productValidations.ProductMustNotBeEmpty(product).Wait();
        _productRepository.Delete(product);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var product = _productRepository.Get(p => p.Id == id);
        await _productValidations.ProductMustNotBeEmpty(product);
        await _productRepository.DeleteAsync(product);
    }

    public IList<Product> GetAll()
    {
        return _productRepository.GetAll().ToList();
    }

    public async Task<IList<Product>> GetAllAsync()
    {
        var result = await _productRepository.GetAllAsync();
        return result.ToList();
    }

    public IList<Product> GetAllWithCategory()
    {
        return _productRepository.GetAll(include: p => p.Include(product => product.Category)).ToList();
    }

    public async Task<IList<Product>> GetAllWithCategoryAsync()
    {
        var result = await _productRepository.GetAllAsync(include: p => p.Include(product => product.Category));
        return result.ToList();
    }

    public Product? GetById(Guid id)
    {
        return _productRepository.Get(p => p.Id == id);
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        return await _productRepository.GetAsync(p => p.Id == id);
    }

    public Product Update(Product product)
    {
        return _productRepository.Update(product);
    }

    public async Task<Product> UpdateAsync(Product product)
    {
        return await _productRepository.UpdateAsync(product);
    }
}
