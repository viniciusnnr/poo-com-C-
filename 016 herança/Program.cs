using System;

namespace MyApplication
{
  class Program
  { 
    static void Main(string[] args)
    {
     
      Car myCar = new Car();

      // chama o met buzina (da classe Vehicle) no objeto myCar
      myCar.buzina();

      // exibi a marca (da classe Vehicle) e o modelName da classe Car
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}