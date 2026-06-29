using System;

internal class Program {
  private static void Main(string[] args) {
    FactoryA factoryA = new FactoryA();
    FactoryB factoryB = new FactoryB();

    Factory[] factories = { factoryA, factoryB };

    foreach (Factory factory in factories) {
    Product product = factory.FactoryMethod();
    Console.WriteLine($"Object: {product.GetName()}");
    }

    Console.ReadKey();
  }
}