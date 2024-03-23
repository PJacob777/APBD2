// See https://aka.ms/new-console-template for more information

using Zadanie3.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        LiquidContainer container = new LiquidContainer(20, 20, 10, 20,20,true);
        LiquidContainer container1 = new LiquidContainer(20, 20, 10, 20,20,true);
        Console.WriteLine(container.Desc);
        Console.WriteLine(container1.Desc);
        List<Container> list = new List<Container>();
        list.Add(container1);
        list.Add(container);
        Ship ship = new Ship(list, 20, 300, 300);
        Console.WriteLine(ship);
    }
}