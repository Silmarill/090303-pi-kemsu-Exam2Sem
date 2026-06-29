using System;
// интерфейс визитора
interface IVisitor {
    void Visit(Book book);
}

// интерфейс должен реализовывать все элементы поэтому есть Accept
interface IElement {
    void Accept(IVisitor visitor);
}

// гет сет хранит название книги, а конструктор получает название и сейвит. Класс книги реализует интерфейс из за этого метод Accept реализуется
class Book : IElement {
    public string Name { get; set; }

    public Book(string name) {
        Name = name;
    }
    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}

// класс где посетитель реализует интерфейс
class PrintVisitor : IVisitor {
    public void Visit(Book book) {
        Console.WriteLine($"Книга: {book.Name}");
    }
}

// мэйн где создается книга и посетитель, там книга принимает визитора, который вызывает метод Визит и выводится книга
class Program {
    static void Main() {
        Book book = new Book("Book#1");
        PrintVisitor visitor = new PrintVisitor();
        book.Accept(visitor);
    }
}
