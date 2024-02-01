using Business.Tools.Exceptions;
using Core.Entities;


namespace Business.Validations;

public class ProductTransactionValidations
{
    public async Task ProductTransactionMustNotBeEmpty(ProductTransaction? productTransaction)
    {
        if (productTransaction == null)
        {
            throw new ValidationException("Product transaction must not be empty.", 500);
        }
        await Task.CompletedTask;
    }
}