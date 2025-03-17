using GraphQL.Types;
using Products.Presentation.GQL.Mutations;
using Products.Presentation.GQL.Queries;

namespace Products.Presentation.GQL
{
    public class AppSchema : Schema
    {
        public AppSchema(AppQueries appQueries, AppMutations appMutations)
        {
            this.Query = appQueries;
            this.Mutation = appMutations;
        }
    }
}
