using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlTest.Data;
using GraphQlTest.Interfaces;
using GraphQlTest.Mutation;
using GraphQlTest.Query;
using GraphQlTest.Schema;
using GraphQlTest.Services;
using GraphQlTest.Type;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IProduct, ProductService>();

builder.Services.AddDbContext<GraphQlDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddTransient<ProductType>();
builder.Services.AddTransient<ProductQuery>();
builder.Services.AddTransient<ProductMutation>();
builder.Services.AddTransient<ISchema, ProductSchema>();

builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<GraphQlDbContext>();
    context.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
