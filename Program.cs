using Microsoft.EntityFrameworkCore;
using Portfolio111.Models;
using Microsoft.Extensions.DependencyInjection;
using Portfolio111.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Portfolio111Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Portfolio111Context") ?? throw new InvalidOperationException("Connection string 'Portfolio111Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DbContext>(); // DataDbContext89



builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));  // ��� TodoContext 


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
