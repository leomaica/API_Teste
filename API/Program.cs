using Application.Interfaces;
using Application;
using Autofac;
using Autofac.Core;
using DomainCore.Interfaces.Repositorys;
using DomainCore.Interfaces.Services;
using Infra.CrossCutting.IOC;
using Infra.CrossCutting.Mapper;
using Infra.Data;
using Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SqlContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

ContainerBuilder containerBuilder = new ContainerBuilder();
containerBuilder.RegisterModule(new ModuloIOC());

builder.Services.AddControllers();
builder.Services.AddScoped<IAppicationServiceProduto, ApplicationServiceProduto>();
builder.Services.AddScoped<IServicoProduto, ServiceProduto>();
builder.Services.AddScoped<IRepositoryProduto, RepositoryProduto>();
builder.Services.AddScoped<IMapperProduto, MapperProduto>();



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

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



