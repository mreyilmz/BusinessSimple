using Business.Tools.Exceptions;
using Core.Entities;

namespace Business.Validations;

public class OrderDetailValidations
{
    public async Task OrderDetailMustNotBeEmpty(OrderDetail? orderDetail)
    {
        if (orderDetail == null)
        {
            throw new ValidationException("Order detail must not be empty.", 500);
        }
        await Task.CompletedTask;
    }
}
