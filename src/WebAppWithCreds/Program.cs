using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebAppWithCreds
{
    public class Program
    {
        // For detection capability demo only.
        private static string StorageAccountKey { get; set; } = "AccountName=credscanrsademo;AccountKey=abcdefghijklmnopqrstuvwxyz0123456789++ABCDEabcdefghijklmnopqrstuvwxyz0123456789++ABCDF==;EndpointSuffix=core.windows.net;";

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
