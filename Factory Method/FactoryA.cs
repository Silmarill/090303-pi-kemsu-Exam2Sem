public class FactoryA : Factory {
  public override Product FactoryMethod() {
    return new ProductA();
  }
}