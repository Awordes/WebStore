using MediatR;

namespace WebStore.Application.Usecases.Product.Commands.Create;

internal class ProductCreateHandler : IRequestHandler<ProductCreateCommand>
{
    public Task Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
