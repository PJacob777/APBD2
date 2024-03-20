namespace Zadanie3.Classes;

public class Ship
{
    public List<Container> ListOfContainers { get; }
    public double Speed { get; }
    public int MaxLoad { get; }
    public double MaxWeightOfLoad { get; }

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
        if (ListOfContainers.Find(c))
        {
            ListOfContainers.Remove(c);   
        }
    }
}