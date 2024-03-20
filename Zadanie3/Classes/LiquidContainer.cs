using System.Runtime.CompilerServices;
using Zadanie3.Exceptions;
using Zadanie3.Interfaces;

namespace Zadanie3.Classes;

public class LiquidContainer: Container,IHazardNotifier
{
    public bool IsDangerous { get; } 

    public LiquidContainer(double weight, double height, double selfWeight, double deep, double maxWeight, bool isDangerous) : base(weight, height, selfWeight, deep, maxWeight)
    {
        IsDangerous = isDangerous;
        Desc = "CON-L-" + Number;

    }

    public override void Load(double load)
    {
        if ((IsDangerous && ((Weight + load)>(0.5*MaxWeight)))||(!IsDangerous)&&((Weight+load)>(MaxWeight*0.9)))
        {
            InDanger();
            throw new OverfillException();
        }
        base.Load(load);
    }

    public void InDanger()
    {
        Console.WriteLine(Desc);
    }
}