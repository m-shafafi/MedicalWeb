﻿using GraphQL;
using GraphQL.Types;
using MediatR;
using Products.Application.Products.Queries.Product.GetProductsList;
using Products.Presentation.GQL.Types;
using Products.Presentation.GQL.Types.Products;

namespace Products.Presentation.GQL.Queries
{
    public static class ProductsQueries
    {
        public static void ProductQueries(this ObjectGraphType schema, IMediator mediator)
        {
            schema.Field<ListGraphType<ProductResType>>(
                "getProducts",
                description: "return list of prdoucts",
                resolve: context => mediator.Send(new GetProductsListQuery())

            );
            schema.FieldAsync<PaginationResType<ListGraphType<ProductResType>>>(
                "getProductsByFilter",
                description: "return list of filtered prdoucts",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductFilterType>> { Name = "filter" }),


                resolve: async context =>
                {
                    var filterParams = context.GetArgument<GetProductsListQuery>("filter");
                    var res = await mediator.Send(filterParams);

                    return res;
                });
        }
    }
}
