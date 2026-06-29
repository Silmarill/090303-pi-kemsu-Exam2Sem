public class FactoryB : Factory {
  public override Product FactoryMethod() {
    return new ProductB();
  }
}
