using BusinessLayer.Service;
using BussinessLayer.Interface;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();
builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<LoginDTO>();
//builder.Services.AddScoped<RegisterDTO>();
//Addswagger to container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

//Configure the http request pipeline

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();