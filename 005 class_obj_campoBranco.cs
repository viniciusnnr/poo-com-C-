//campo; campo em branco; método; modificar campo em branco; acessando campo.



class MyClass
{
  // Membros da Classe
  string color = "red";    // campo
  int veloMax;             // campo em branco 
  public void acelerar()   // método
  {
    Console.WriteLine("carro mais rápido");
  }
  
  static void Main (string[] args)
  {
    Car myObj = new Car();
    myObj.veloMax = 200; //modificando campo em branco

    Console.WriteLine(myObj.color); //acessando campo com not. de ponto 
    Console.WriteLine(myObj.veloMax); //acessando campo com not. de ponto 
  }
}