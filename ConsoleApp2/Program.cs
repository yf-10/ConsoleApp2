using System;
using System.Configuration;


namespace ConsoleApp2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            test();

            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile(path: "appsettings.json");
            //var configuration = builder.Build();

            //string? str = configuration["LOG:LOGDIR_PATH"];
            //Console.WriteLine(str);

            var app = ConfigurationManager.AppSettings["test"];
            Console.WriteLine(app);

        }

        private static void test()
        {
            Console.WriteLine("TEST");
        }
    }
}