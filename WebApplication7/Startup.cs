using WebApplication7.Services.Customers;
using WebApplication7.Services.Orders;
using WebApplication7.Services.Products;

namespace WebApplication7
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICustomerService, CustomerService>();

            //Порівняно з AddSingleton, який створює один глобальний
            //екземпляр сервісу для всього додатка, AddScoped забезпечує
            //кращу ефективність ресурсів, оскільки екземпляри сервісу
            //живуть тільки протягом одного HTTP-запиту.

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
