using System;

namespace MyApplication
{
  class Car
  {
    public string model;

    public Car() //construtor
    {
      model = "Mustang"; 
    }

    static void Main(string[] args)
    {
      Car Ford = new Car();  // cria um obj, isso chama o construtor
      Console.WriteLine(Ford.model);
    }
  }
}