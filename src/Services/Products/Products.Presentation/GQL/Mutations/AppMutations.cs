using GraphQL.Types;
using MediatR;

namespace Products.Presentation.GQL.Mutations
{
    public class AppMutations:ObjectGraphType
    {
        public AppMutations(IMediator mediator)
        {
            this.ProductMutations(mediator);
        }
    }
}
