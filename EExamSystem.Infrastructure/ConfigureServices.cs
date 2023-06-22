

using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Repositories;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EExamSystem.Infrastructure
{
    public static class ConfigureServices
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("Default")));
        }

        public static void InjectRepositories(this IServiceCollection services)
        {

            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();


        }


    }
}
