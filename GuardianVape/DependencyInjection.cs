//using DataAccess.Contracts;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace DataAccess;

//public static class DependencyInjection
//{
//    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
//    {
//        AddDbContext(services, configuration);
//        services.AddScoped<IFileAttachmentService, BlobFileAttachmentService>();
//        return services;
//    }

//    public static void AddDbContext(IServiceCollection services, IConfiguration configuration)
//    {

//        services.AddDbContext<DbContext>(options =>
//            options.UseSqlServer(configuration.GetConnectionString("SqlDatabase"),
//                builder => builder.MigrationsAssembly(typeof(DbContext).Assembly.FullName)));

//        services.AddScoped<IDbContext, DbContext>();
//    }
//}