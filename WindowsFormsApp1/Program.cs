using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            string connstr = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();

            var conn = new SqlConnection(connstr);

            services.AddScoped<ICustomerDal, DpCustomerDal>()
                    .AddScoped<ICustomerService, CustomerManager>()
                    .AddScoped<ISupplierService, SupplierManager>()
                    .AddScoped<ISupplierDal, DpSupplierDal>()
                    .AddScoped<IProductService, ProductManager>()
                    .AddScoped<IProductDal, DpProductDal>()
                    .AddScoped<IStockService, StockManager>()
                    .AddScoped<IStockDal,DpStockDal>()
                    .AddScoped<ISaleService,SaleManager>()
                    .AddScoped<ISaleDal,DpSaleDal>()
                    .AddScoped<IReturnService, ReturnManager>()
                    .AddScoped<IReturnDal,DpReturnDal>()
                    .AddTransient<IDbConnection>(db => conn)
                    .AddScoped<Form1>();


        }
    }
}
