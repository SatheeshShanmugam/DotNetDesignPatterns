// See https://aka.ms/new-console-template for more information
using TemplateDesignPattern;

Console.WriteLine("Hello, World!");

ReportGenerator reportGenerator = new SalesReport();
reportGenerator.GenerateReport();
