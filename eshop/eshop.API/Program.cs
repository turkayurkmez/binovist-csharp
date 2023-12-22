using eshop.Application;
using Microsoft.EntityFrameworkCore;
using shop.Infrastructure.Data;
using shop.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddDbContext<EshopDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddCors(options => options.AddPolicy("allow", builder =>
{
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
    builder.AllowAnyOrigin();

    /*
     * http://binovist.com
     * https://binovist.com
     * 
     * https://www.binovist.com/ik/iletisim
     * https://www.binovist.com:1254
     * 
     * 
     */
}));

//Varsayın ki ürün koleksiyonuna farklı actionlarda ihtiyacınız var.
builder.Services.AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("allow");
app.UseAuthorization();



app.MapControllers();

app.Run();
