using MinimalTest.Web.Domain.CartAggregate;
using MinimalTest.Web.Domain.GuestUserAggregate;
using MinimalTest.Web.Domain.OrderAggregate;
using MinimalTest.Web.Domain.ProductAggregate;
using Vogen;

namespace MinimalTest.Web.Infrastructure.Data.Config;

[EfCoreConverter<ProductId>]
[EfCoreConverter<CartId>]
[EfCoreConverter<CartItemId>]
[EfCoreConverter<GuestUserId>]
[EfCoreConverter<OrderId>]
[EfCoreConverter<OrderItemId>]
[EfCoreConverter<Quantity>]
[EfCoreConverter<Price>]
internal partial class VogenEfCoreConverters;
