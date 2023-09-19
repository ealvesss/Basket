namespace Orders.Application.Dtos.Responses
{
    public class ProductsResponseDto : BaseDto<ProductDto>
    {
        public ProductsResponseDto(int pageSize, int totalItens, int totalPages, IEnumerable<ProductDto> items, int page)
        {
            PageSize = pageSize;
            Page = page;
            TotalItens = totalItens;
            TotalPages = totalPages;
            Items = items;
        }
    }
}
