using HighparkingProject;
using Soild.core.Repositories;
using Soild.data;
using Soild.data.Repositories;
using Soild.srvice;
using Soild.core.Entities;
using Soild.core.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerepository, Customerrepositories>();
    builder.Services.AddScoped< IInrepostory,Invokinigrepository > ();
builder.Services.AddScoped<ICustumerservice, CustomerService>();
builder.Services.AddScoped<IInservice, InvokingService>();

builder.Services.AddDbContext<DataContext>();


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

