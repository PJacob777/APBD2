namespace Zadanie3.Classes;

public class CoolantContainer :Container
{
    public double Temp { get; }
    public static Dictionary<string, double> table { get; }
    public string Product { get; }

    static CoolantContainer()
    {
        table = new Dictionary<string, double>();
        table["Banana"] = 13.3;
        table["Chocolate"] = 18;
        table["Fish"] = 2;
        table["Meat"] = -15;
        table["Ice Cream"] = -18;
        table["Frozen pizza"] = -30;
        table["Cheese"] = 7.2;
        table["Sausages"] = 5;
        table["Butter"] = 20.5;
        table["Eggs"] = 19;
    }

    public CoolantContainer(double weight, double height, double selfWeight, double deep, double maxWeight, double temp, string product)
        : base(weight, height, selfWeight, deep, maxWeight)
    {
        Temp = temp;
        Desc = "CON-C_" + Number;
        Product = product;
    }
    
}