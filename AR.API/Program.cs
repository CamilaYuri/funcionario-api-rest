using AR.Domain.Interfaces.Repositories;
using AR.Domain.Interfaces.Services;
using AR.Domain.Mappings;
using AR.Domain.Services;
using AR.Infrastructure.Data;
using AR.Infrastructure.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MainContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("EmployeeConnectionString")));

builder.Services.AddScoped<IEmployeeCLTRepository, EmployeeCLTRepository>();
builder.Services.AddScoped<IEmployeePJRepository, EmployeePJRepository>();

builder.Services.AddScoped<IEmployeeCLTService, EmployeeCLTService>();
builder.Services.AddScoped<IEmployeePJService, EmployeePJService>();

var mapperConfig = new MapperConfiguration(config =>
{
    config.AddProfile(new EntityToDTOMappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
