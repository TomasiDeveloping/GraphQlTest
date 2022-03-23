using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlTest.Data;
using GraphQlTest.Interfaces;
using GraphQlTest.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IMenu, MenuService>();
builder.Services.AddTransient<ISubMenu, SubMenuService>();
builder.Services.AddTransient<IReservation, ReservationService>();

builder.Services.AddDbContext<GraphQlDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});



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
