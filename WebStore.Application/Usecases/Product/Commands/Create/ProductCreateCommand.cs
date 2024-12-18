using MediatR;

namespace WebStore.Application.Usecases.Product.Commands.Create;

public class ProductCreateCommand: IRequest
{
    public string? Name { get; set; }
}
