using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace app
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>()
        .UseUrls("http://localhost:3300")
        .Build();
  }
}