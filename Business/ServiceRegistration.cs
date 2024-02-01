using System;
using Business.Abstracts;
using Business.Concretes;
using Business.Validations;
using Core.Utilities.Security.JWT;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class ServiceRegistration
{
	public static void RegisterBusinessServices(this IServiceCollection services)
	{
		services.AddDbContext<BusinessDbContext>();
		services.AddSingleton<ITokenHelper, JWTTokenHelper>();
		services.AddScoped<IClaimRepository, ClaimRepository>();
		services.AddScoped<ClaimValidations>();
		services.AddScoped<IClaimService, ClaimManager>();
		services.AddScoped<IUserClaimRepository, UserClaimRepository>();
		services.AddScoped<UserValidations>();
		services.AddScoped<IUserRepository, UserRepository>();
		services.AddScoped<IUserService, UserManager>();
		services.AddScoped<AuthValidations>();
		services.AddScoped<IAuthService, AuthManager>();
		services.AddScoped<CategoryValidations>();
		services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ProductValidations>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<ProductTransactionValidations>();
        services.AddScoped<IProductTransactionService, ProductTransactionManager>();
        services.AddScoped<OrderDetailValidations>();
        services.AddScoped<IOrderDetailService, OrderDetailManager>();
        services.AddScoped<OrderValidations>();
        services.AddScoped<IOrderService, OrderManager>();
    }
}

