using MediatR;

namespace WebStore.Application.Usecases.Products.Commands.Create;

public record ProductCreateCommand(string? Name) : IRequest;
