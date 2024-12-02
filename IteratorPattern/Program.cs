using IteratorPattern;
using System.Collections;

class Program
{
    static void Main()
    {
        Library library = new Library();
        IEnumerator librarian = library.GetEnumerator();

        library.AddBook(new Book("Пособие для сна", "Книга Матвей", 2023));
        library.AddBook(new Book("Гойда братья", "Карпенко Егор", 2024));
        library.AddBook(new Book("Design Patterns via C#", "Александр Шевчук, Дмитрий Охрименко, Андрей Касьянов", 2015));
        
        while (librarian.MoveNext())
            Console.WriteLine(((Book)librarian.Current).Title);
    }
}