abstract class Animal //Classe abstrata
{
  public abstract void animalSound(); // método abstrato (não possui corpo)
  
  public void sleep()  //método regular
  {
    Console.WriteLine("Zzz");
  }
}

class Pig : Animal // classe derivada de Animal
{
  public override void animalSound() //note o override
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); 
    myPig.animalSound();  
    myPig.sleep();
  }
}