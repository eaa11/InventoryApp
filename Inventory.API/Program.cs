using Inventory.DAL.ConcreteRepositories;
using Inventory.DAL.Context;
using Inventory.Domain.Abstractions;
using Inventory.Models.Domain;
using Inventory.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddDbContext<InventoryDbContext>(option =>
            option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

//app.MapGet("/customer", async(ICustomerService custService) => 
//    await custService.GetCustomersAsync());

//app.MapPost("/customer", async (ICustomerService custService, Customer customer) =>
//{
//    await custService.AddCustomer(customer);

//    return Results.Ok(await custService.GetCustomersAsync());
//});


app.Run();
