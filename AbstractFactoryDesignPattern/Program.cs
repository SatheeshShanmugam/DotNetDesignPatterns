// See https://aka.ms/new-console-template for more information

using AbstractFactoryDesignPattern;
using AbstractFactoryDesignPattern.Implementation;
using AbstractFactoryDesignPattern.Interfaces;

Renderer renderer = new Renderer(new DarkThemeFactory());
renderer.render();
Console.WriteLine("Hello, World!");

