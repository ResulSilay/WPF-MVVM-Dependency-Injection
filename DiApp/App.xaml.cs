using DiApp.Business.Service;
using DiApp.Data.Abstract;
using DiApp.Data.Repository;
using DiApp.UI.Product;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DiApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder();

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<ProductWindow>();
            mainWindow.Show();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IProductRepository, EfProductRepository>();
            //services.AddScoped<IProductRepository, NhProductRepository>();

            services.AddScoped<IProductViewModel, ProductViewModel>();

            services.AddTransient(typeof(ProductWindow));
        }
    }
}