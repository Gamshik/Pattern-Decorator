using PatternDecorator.Bases;
using PatternDecorator.Decorators;
using PatternDecorator.Entities;

Coffee cappuccino = new Cappuccino();
Coffee latte = new Latte();

Console.WriteLine($"First cup - {cappuccino}");
Console.WriteLine($"Second cup - {latte}");

Console.WriteLine("==============================================================================================================");

cappuccino = new MilkDecorator(cappuccino);
latte = new MilkDecorator(latte);

Console.WriteLine($"First cup - {cappuccino}");
Console.WriteLine($"Second cup - {latte}");

Console.WriteLine("==============================================================================================================");

cappuccino = new CreamDecorator(cappuccino);

Console.WriteLine($"First cup - {cappuccino}");