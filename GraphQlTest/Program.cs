using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Mutation;
using GraphQlTest.Query;
using GraphQlTest.Schema;
using GraphQlTest.Services;
using GraphQlTest.Type;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IProduct, ProductService>();

builder.Services.AddSingleton<ProductType>();
builder.Services.AddSingleton<ProductQuery>();
builder.Services.AddSingleton<ProductMutation>();
builder.Services.AddSingleton<ISchema, ProductSchema>();

builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
