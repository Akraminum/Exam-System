using EExamSystem.API.Mappers.Tests;
using EExamSystem.Core.Services;
using EExamSystem.Core.Services.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace EExamSystem.Core
{
    public static partial class ConfigureServices
    {

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(TestsProfile));
            //services.AddScoped<ITopicService, TopicService>();
            //services.AddScoped<ICateoryService, CateoryService>();
            services.AddScoped<IQuestionService, QuestionService>();
        }


    }

}
