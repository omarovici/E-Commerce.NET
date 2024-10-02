using Microsoft.AspNetCore.Mvc;
using Store.Repository.Basket;
using Store.Repository.Interfaces;
using Store.Repository.Repositories;
using Store.Service.CacheService;
using Store.Service.HandleResponses;
using Store.Service.Services.BasketService;
using Store.Service.Services.BasketService.Dtos;
using Store.Service.Services.ProductService;
using Store.Service.Services.ProductService.Dtos;

namespace Store.Web.Extensions;

public static class ApplicationServiceExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICacheService , CacheService>();
        services.AddScoped<IBasketService , BasketService>();
        services.AddScoped<IBasketRepository , BasketRepository>();
        services.AddAutoMapper(typeof(ProductProfile));
        services.AddAutoMapper(typeof(BasketProfile));

        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.InvalidModelStateResponseFactory = actionContext =>
            {
                var errors = actionContext.ModelState
                    .Where(model => model.Value.Errors.Count > 0)
                    .SelectMany(model => model.Value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();

                var errorResponse = new ValidationErrorResponse
                {
                    Errors = errors
                };

                return new BadRequestObjectResult(errorResponse);
            };
        });
        return services;
    }
}