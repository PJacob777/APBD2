using Zadanie3.Exceptions;

namespace Zadanie3.Classes;

public abstract class Container(double weight,double height,double selfWeight, double deep,double maxWeight)
{
 public double Weight { get; protected set; } = weight;
 public double Height { get; } = height;
 public double SelfWeight { get; } =selfWeight;
 public double Deep  {get;}= deep;
 public string Desc { get; protected set; }="KON-C-"+Number++;
 public double MaxWeight { get; }=maxWeight;
 public static int Number { get; protected set; }=0;

 public virtual void Load(double load)
 {
  if (Weight + load > MaxWeight)
   throw new OverfillException();
  Weight += load;
 }

 public virtual void ReLoad()
 {
  Weight = 0;
 }

 public override string ToString()
 {
  return "Container " + Desc;
 }

 public override bool Equals(object? obj)
 {
  return base.Equals(obj);
 }
}