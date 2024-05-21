using AuroraDelivery.Domain.Entities;
using AuroraDelivery.Domain.Interface;
using AuroraDelivery.Domain.Interface.Repository.AuroraDelivery.Domain.Interfaces.Repositories;
using AuroraDelivery.Infra.Data;
using AuroraDelivery.Infra.Data.Repository;
using AuroraDelivery.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner.
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IBaseService<Customer>, CustomerService>();

builder.Services.AddControllers();

// Adicionar Swagger para documentação da API, se necessário.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar o pipeline de solicitações HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();