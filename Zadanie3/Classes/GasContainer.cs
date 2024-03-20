using Zadanie3.Interfaces;

namespace Zadanie3.Classes;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; } 

    public GasContainer(double weight, double height, double selfWeight, double deep, double maxWeight, double pressure)
        : base(weight, height, selfWeight, deep, maxWeight)
    {
        Pressure = pressure;
        Desc = "CON-G-" + Number;
    }
    public void InDanger()
    {
        Console.WriteLine("Dangerous "+ Desc);
    }

    public override void ReLoad()
    {
        Weight = 0.05 * Weight;
    }
}