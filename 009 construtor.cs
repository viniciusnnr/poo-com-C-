class Car
{
  public string model;  //field

  public Car() //class constructor
  {
    model = "Mustang"; // Set the initial value for model
  }

  static void Main(string[] args)
  {
    Car Ford = new Car();  //(this will call the constructor)
    Console.WriteLine(Ford.model);
  }
}