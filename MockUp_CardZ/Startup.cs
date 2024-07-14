using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUp_CardZ
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Đăng ký các dịch vụ của bạn ở đây (ví dụ: database context, dependencies, ...).
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Cấu hình middleware của bạn ở đây (ví dụ: routing, logging, ...).
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Đăng ký các Controllers trong dự án của bạn.
            });

        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>()
        .UseUrls("http://localhost:9991");
    }
}
