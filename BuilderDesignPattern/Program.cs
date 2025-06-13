// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern.Implementations;
using BuilderDesignPattern.Interfaces;

Console.WriteLine("Hello, World!");

IConfiguration configuration = new ConfigurationBuilder()
    .SetConnectionString("Server=myServer;Database=myDB;User Id=myUser;Password=myPass;")
    .SetUrlPath("/api/v1/resource")
    .Build();
