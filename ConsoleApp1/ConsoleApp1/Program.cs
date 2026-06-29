using System;
interface IVisitor {
    void Visit(Book book);
}

interface IElement {
    void Accept(IVisitor visitor);
}

class Book : IElement {
    public string Name { get; set; }

    public Book(string name) {
        Name = name;
    }
    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}

class PrintVisitor : IVisitor {
    public void Visit(Book book) {
        Console.WriteLine($"Книга: {book.Name}");
    }
}

class Program {
    static void Main() {
        Book book = new Book("Book#1");
        PrintVisitor visitor = new PrintVisitor();
        book.Accept(visitor);
    }
}
