using DataAccess.Context;
using DataAccess.Implementations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Service.Contracts;
using Service.Contracts.Inquiry;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Service.Contracts.Utility;
using Service.Contracts.Validation;
using Service.Implementations.Inquiry;
using Service.Implementations.Servises;
using Service.Implementations.Utility;
using Service.Implementations.Validation;
using System.Text;

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
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("veryverysceret....................")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero
    };
});
builder.Services.AddDbContext<GVDbContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("GV_DBConnection")));
builder.Services.AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();
builder.Services.AddTransient<IUserDeleteInquiry, UserDeleteInquiry>();
builder.Services.AddTransient<IUserValidator,UserValidator>();
builder.Services.AddTransient<IAddressService, AddressService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IEmailService,EmailService>();
builder.Services.AddTransient<ICollectionService, CollectionService>();

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
