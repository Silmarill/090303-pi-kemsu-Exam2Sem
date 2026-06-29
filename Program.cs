using System;

namespace AbstractFactory {
  interface IButton {
    void Draw();
  }

  interface ITextBox {
    void Show();
  }

  class WindowsButton : IButton {
    public void Draw() {
      Console.WriteLine("Кнопка Windows");
    }
  }

  class WindowsTextBox : ITextBox {
    public void Show() {
      Console.WriteLine("Поле Windows");
    }
  }

  // Интерфейс фабрики
  interface IGUIFactory {
    IButton CreateButton();
    ITextBox CreateTextBox();
  }

  // Фабрика Windows
  class WindowsFactory : IGUIFactory {
    public IButton CreateButton() {
      return new WindowsButton();
    }

    public ITextBox CreateTextBox() {
      return new WindowsTextBox();
    }
  }

  class Program {
    static void Main(string[] args) {
      IGUIFactory factory = new WindowsFactory();

      IButton button = factory.CreateButton();
      ITextBox textBox = factory.CreateTextBox();

      button.Draw();
      textBox.Show();
    }
  }
}