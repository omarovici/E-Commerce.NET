namespace Store.Repository.Specification.ProductSpecs;

public class ProductSpecification
{
    public int? BrandId { get; set; }
    public int? TypeId { get; set; }
    public string? Sort { get; set; }
    public int PageIndex { get; set; } = 1;
    private const int MAXPAGESIZE = 50;
    private int _pageSize = 6;
    private string? _search { get; set; }
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > MAXPAGESIZE) ? int.MaxValue : value;
    }

    public string? Search
    {
        get => _search;
        set => _search = value.Trim().ToLower();
    }
}