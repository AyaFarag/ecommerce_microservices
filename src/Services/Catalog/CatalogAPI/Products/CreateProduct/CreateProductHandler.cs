using BuildingBlocks.CQRS;
using CatalogAPI.Models;

namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<String> Category, string Description, string Image, double Price) 
        : ICommand<CreateProductResult>;

    public record CreateProductResult(Guid id);
    public class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // create product from command object
            // save to database
            // return result

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.Image,
                Price = command.Price,
                // need category list

            };

            return new CreateProductResult(Guid.NewGuid());
            
            
        }
    }
}
