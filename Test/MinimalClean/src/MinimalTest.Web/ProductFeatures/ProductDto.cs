using MinimalTest.Web.Domain.ProductAggregate;

namespace MinimalTest.Web.ProductFeatures;
public record ProductDto(ProductId Id, string Name, decimal UnitPrice);
