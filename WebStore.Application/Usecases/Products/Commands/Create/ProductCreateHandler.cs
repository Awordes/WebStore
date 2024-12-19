using MediatR;
using WebStore.Domain.Entities;

namespace WebStore.Application.Usecases.Products.Commands.Create;

internal class ProductCreateHandler(AppDbContext dbContext) : IRequestHandler<ProductCreateCommand>
{
    public async Task Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Name = request.Name
        };

        dbContext.Add(product);
        
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}
