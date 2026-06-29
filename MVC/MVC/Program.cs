using System;

// Модель
class Model
{
    public string Text = "Hello";
}

// Представление
class View
{
    public void Show(string text)
    {
        Console.WriteLine(text);
    }
}

// Контроллер
class Controller
{
    private Model model = new Model();
    private View view = new View();

    // Получаем данные из модели
    // и передаем их в представление
    public void Display()
    {
        view.Show(model.Text);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем контроллер
        Controller controller = new Controller();

        // Отображаем данные
        controller.Display();
    }
}