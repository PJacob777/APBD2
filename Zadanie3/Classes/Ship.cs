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
        if (ListOfContainers.Count+1>MaxLoad)
        {
            Console.WriteLine("Statek ma maksymalny zaladunek");
        }
        else
        {
            ListOfContainers.Add(c);
            Console.WriteLine("Dodano nowy kontener");

        }
    }

    public void AddListOfContainers(List<Container> list)
    {
        for (int i = ListOfContainers.Capacity; i < MaxLoad; i++)
        {
            ListOfContainers.Add(list[i]);
            list.Remove(list[i]);
        }
        if(ListOfContainers.Capacity+list.Capacity>MaxLoad)
            Console.WriteLine("Nie zostaly dodane wszystkie kontenery ze wzgledu na przeladowanie");
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
        int tmp = 0;
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
        b.ListOfContainers.Add(container);
    }

    public override string ToString()
    {
        string products = "";
        foreach (var container in ListOfContainers)
        {
            if(!products.Contains(container.Desc[5]))
                products = +container.Desc[5] + " ";
        }

        return "Ship " + products;
    }
}