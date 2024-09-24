using Store.Service.Services.ProductService.Dtos;

namespace Store.Service.Services.ProductService;

public interface IProductService
{
    Task<ProductDetailsDto> GetProductByIdAsync(int? productId);
    Task<IReadOnlyList<ProductDetailsDto>> GetAllProductsAsync();
    Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllBrandsAsync();
    Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllTypesAsync();
}