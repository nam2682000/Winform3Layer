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
            services.AddSingleton<BaoCao>();
            services.AddSingleton<TaiSan>();
            services.AddSingleton<DbContexApplication>();
            services.AddScoped<ITaiSanRepository, TaiSanRepository>();
            services.AddScoped<ITaiSanService, TaiSanService>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services.BuildServiceProvider();
        }
    }
}
