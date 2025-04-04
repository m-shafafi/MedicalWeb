﻿using GraphQL.Types;

namespace Products.Presentation.GQL.Types
{
    public class PaginationResType<TDto>:ObjectGraphType where TDto : IGraphType
    {
        public PaginationResType()
        {
            Name = "PaginationResType";
            Field<TDto>("Data");
            Field<IntGraphType>("PageSize");
            Field<IntGraphType>("PageIndex");
            Field<IntGraphType>("TotalCount");

        }

    }
}
