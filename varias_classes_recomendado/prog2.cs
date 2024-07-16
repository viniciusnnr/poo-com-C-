using System;

namespace MyApplication
{
  class Car
  {
    public string model;
    public string color;
    public int year;
    public void fullThrottle()
    {
      Console.WriteLine("The car is going as fast as it can!"); 
    }
  }
}
//A publicpalavra-chave é chamada de modificador de acesso , que especifica que os campos de Carsão acessíveis também para outras classes, como Program