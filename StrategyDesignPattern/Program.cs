// See https://aka.ms/new-console-template for more information
using StrategyDesignPattern;

Console.WriteLine("Hello, World!");

Strategy strategy = new Strategy(new ByBikeNavigation());
strategy.Navigate();
strategy = new Strategy(new ByVehicleNavigation());
strategy.Navigate();
