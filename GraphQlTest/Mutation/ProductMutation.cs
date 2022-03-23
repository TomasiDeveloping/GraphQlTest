﻿using GraphQL;
using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;
using GraphQlTest.Type;

namespace GraphQlTest.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProduct productService)
        {
            Field<ProductType>("createProduct", arguments: new QueryArguments(new QueryArgument<ProductInputType> {Name = "product"}),
                resolve: context =>
                {
                    return productService.AddProduct(context.GetArgument<Product>("product"));
                });

            Field<ProductType>("updateProduct", 
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "id" },
                    new QueryArgument<ProductInputType> { Name = "product"}
                    ),
                resolve: context =>
                {
                    var productObj = context.GetArgument<Product>("product");
                    var productId = context.GetArgument<int>("id");
                    return productService.UpdateProduct(productId, productObj);
                });

            Field<StringGraphType>("deleteProduct",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "id" }
                ),
                resolve: context =>
                {
                    var productId = context.GetArgument<int>("id");
                    productService.DeleteProduct(productId);
                    return $"The product against the id: {productId} has ben deleted";
                });
        }
    }
}
