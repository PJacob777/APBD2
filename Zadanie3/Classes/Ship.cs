using Zadanie3.Exceptions;

namespace Zadanie3.Classes;

public class Ship
{
    public List<Container> ListOfContainers { get; }
    public double Speed { get; }
    public int MaxLoad { get; }
    public double MaxWeightOfLoad { get; }
    public string KindOfProducts { get; }

    public Ship(List<Container> listOfContainers, double speed, int maxLoad, double maxWeightOfLoad)
    {
        ListOfContainers = listOfContainers;
        Speed = speed;
        MaxLoad = maxLoad;
        MaxWeightOfLoad = maxWeightOfLoad;
    }

    public void AddContainer(Container c)
    {
        if (c.SelfWeight+c.Weight+GetWeightOfAllContainers(ListOfContainers)>MaxWeightOfLoad || 1+ListOfContainers.Capacity>MaxLoad)
        {
            Console.WriteLine("Statek ma maksymalny zaladunek");
            throw new OverfillException();
        }
        else
        {
            ListOfContainers.Add(c);
            Console.WriteLine("Dodano nowy kontener");

        }
    }

    public void AddListOfContainers(List<Container> list)
    {
        if (GetWeightOfAllContainers(ListOfContainers) + GetWeightOfAllContainers(list) > MaxLoad)
            throw new OverfillException();
        
        for (int i = ListOfContainers.Capacity; i < MaxLoad; i++)
        {
            ListOfContainers.Add(list[i]);
            list.Remove(list[i]);
        }
        if(ListOfContainers.Capacity+list.Capacity>MaxLoad)
        {
            Console.WriteLine("Nie zostaly dodane wszystkie kontenery ze wzgledu na przeladowanie");
            throw new OverfillException();
        }
        Console.WriteLine("Dodano kontenery");
    }

    public void RemoveContainer(Container c)
    {
        int index=ListOfContainers.IndexOf(c);
        if (index!=-1)
            ListOfContainers.RemoveAt(index);
            
    }

    public Container ReturnContainer(Container c)
    {
        int i = ListOfContainers.IndexOf(c);
        if(i!=-1)   
            return ListOfContainers[i];
        return null;
    }

    public void ChangeContainer(string desc, Container dest)
    {
        for (int i = 0; i < ListOfContainers.Capacity; i++)
        {
            if (ListOfContainers[i].Desc.Equals(desc))
                ListOfContainers[i] = dest;

        }
    }

    public static void MoveContainer(Ship a, Ship b, Container container)
    {
        int i = a.ListOfContainers.IndexOf(container);
        a.ListOfContainers.RemoveAt(i);
        b.AddContainer(container);
    }

    public override string ToString()
    {
        string products = "";
        foreach (var container in ListOfContainers)
        {
            if(!products.Contains(container.Desc[4]))
                products += container.Desc[4] + " ";
        }

        return "Ship " + products;
    }

    private double GetWeightOfAllContainers(List<Container> list)
    {
        double weight = 0;
        foreach (var i in list)
        {
            weight += i.Weight + i.SelfWeight;
        }

        return weight;
    }
}