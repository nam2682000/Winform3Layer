using BusinessLogic.Interface;
using BusinessLogic.Mapper;
using BusinessLogic.Service;
using DataAccess.DbContext;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class DependencyInjection
    {
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Đăng ký các dịch vụ
            services.AddSingleton<Login>();
            services.AddSingleton<Form1>();
            services.AddSingleton<DbContexApplication>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services.BuildServiceProvider();
        }
    }
}
