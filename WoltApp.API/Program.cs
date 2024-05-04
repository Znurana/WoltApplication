using Microsoft.EntityFrameworkCore;
using WoltApp.BLL.Mapping;
using WoltApp.BLL.Services;
using WoltApp.BLL.Services.Contracts;
using WoltApp.DAL.Data;
using WoltApp.DAL.Repository;
using WoltApp.DAL.Repository.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(CustomMap));

builder.Services.AddDbContext<WoltDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionString")));

//builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IFoodRepository, FoodRepo>();
builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

