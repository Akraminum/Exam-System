using EExamSystem.Core.Interfaces.IRepositories.Topics;
using EExamSystem.Core.Repositories.Topics;
using EExamSystem.Infrastructure.DataBase;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core
{
    public static partial class ConfigureServices
    {
        public static void ConfigureAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigureServices));
        }


        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITopicRepository, TopicRepository>();
        }


        public static void InjectManagers(this IServiceCollection services)
        {

        }


    }

}
