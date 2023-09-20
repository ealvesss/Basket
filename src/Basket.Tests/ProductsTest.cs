using AutoMapper;
using Basket.Application.Services;
using Basket.Application.Services.Interfaces;
using Basket.Domain.Entities.Products;
using Basket.Domain.Products.Interfaces;
using Basket.Domain.Service.ProductService;
using Basket.Domain.Util.Interfaces;
using Moq;

namespace Basket.Tests;

public class ProductsTest
{
    //Moq the interface IProductAppService
    private readonly Mock<IProductService> _productAppServiceMock = new Mock<IProductService>();
    private readonly Mock<IProductService> _productService = new Mock<IProductService>();
    private readonly Mock<IMapper> _mapper = new Mock<IMapper>();
    private readonly Mock<ISupportMethods> _suppMethods = new Mock<ISupportMethods>();
    
    [Fact]
    public async void ReturnsErrorIfThePageSizeIsGreaterThan1000()
    {
        //Arrange
        var appService = new ProductAppService(_productService.Object, _mapper.Object, _suppMethods.Object);
        
        //Act
        var result = await appService.GetPaginated(1, 10001);
        
        //Assert
        Assert.Contains(result.error.Message, "Page size should be lower than 1000");
    }
    
    [Fact]
    public async void ReturnsNotErrorIfThePageSizeIsLowerThan1000()
    {
        //Arrange
        var appService = new ProductAppService(_productService.Object, _mapper.Object, _suppMethods.Object);
        
        //Act
        var result = await appService.GetPaginated(1, 1000);
        
        //Assert
        Assert.True(string.IsNullOrEmpty(result.error.Message));
    }
}