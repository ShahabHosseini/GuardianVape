using DataAccess.Context;
using DataAccess.Implementations;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Service.Implementations.Servises;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(option => 
{
    option.AddPolicy("mypolicy", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
} );

builder.Services.AddDbContext<GVDbContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("GV_DBConnection")));
builder.Services.AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();
builder.Services.AddTransient<IAddressService, AddressService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //Or typeof(Program).Assembly Shahab
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.UseCors("mypolicy");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
