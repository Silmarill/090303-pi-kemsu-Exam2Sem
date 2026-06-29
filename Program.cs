using System;

namespace AbstractFactory {
  interface IButton {
    void Draw();
  }

  interface ITextBox {
    void Show();
  }

  interface IText {
    void PrintText();
  }

  interface IField {
    void ShowField();
  }

  class Text : IText {
    public void PrintText(){
      Console.WriteLine("Какой-то текст");
    }
  
  class DropDownField : IField {
    public void ShowField() {
      Console.WriteLine("Выпадающее поле");
    }

  class WindowsButton : IButton {
    public void Draw() {
      Console.WriteLine("Кнопка Windows");
    }
  }

  class LinuxButton : IButton {
    public void Draw() {
      Console.WriteLine("Кнопка Linux");
    }
  }

  class WindowsTextBox : ITextBox {
    public void Show() {
      Console.WriteLine("Поле Windows");
    }
  }

  interface MyGUIFactory {
    IText CreateNewText();
    IField CreateField();
    IButton CreateButton();
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

  class LinuxFactory : MyGUIFactory {
    public IText CreateNewText() {
      return new Text();
    }

    public IField CreateField() {
      return new DropDownField();
    }

    public IButton CreateButton() {
      return new LinuxButton();
    }
      
  }

  class Program {
    static void Main(string[] args) {
      IGUIFactory factory = new WindowsFactory();
      MyGUIFactory factory1 = new LinuxFactory();

      IButton button = factory.CreateButton();
      ITextBox textBox = factory.CreateTextBox();

      //Task
      IText text = factory1.CreateNewText();
      IField field = factory1.CreateField();

      text.PrintText();
      field.ShowField();

      button.Draw();
      textBox.Show();
    }
  }
}
