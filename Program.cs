namespace ConsoleApp1;

class Program
{
    static void Section(string title)
    {
        Console.WriteLine();
        Console.WriteLine($"===== {title} =====");
    }

    static void Main()
    {
        Students a = new Students("Anna", "Petrivna", "Bondar", new DateTime(2004, 7, 2),
            "Lviv, Mira St 5", "+380501111111", [10, 11], [12, 9], [10]);
        Students b = new Students("Iryna", "Olehivna", "Melnyk", new DateTime(2003, 11, 9),
            "Odesa, Pushkin St 12", "+380502222222", [9, 9], [8, 10], [9]);
        Students c = new Students("Oleg", "Ivanovych", "Petrenko", new DateTime(2003, 3, 14),
            "Kyiv, Peace St 7", "+380503333333", [11, 12], [12, 12], [11]);
        Students d = new Students("Taras", "Mykolayovych", "Kovalenko", new DateTime(2004, 1, 25),
            "Kharkiv, Central St 3", "+380504444444", [1, 8], [7, 6], [5]);
        Students e = new Students("Ivan", "Stepanovych", "Shevchenko", new DateTime(2002, 9, 30),
            "Dnipro, Garden St 9", "+380505555555", [5, 6], [4, 5], [5]);
        Console.WriteLine($"student {a.GetName() +" "+ a.GetSurname()} GPA: {a.CalculateGPA()}");
        Console.WriteLine($"student {a.GetName() +" "+ a.GetSurname()} passed: {a.HasPassedSession()}");
        Console.WriteLine($"student {d.GetName() +" "+ d.GetSurname()} GPA: {d.CalculateGPA()}");
        Console.WriteLine($"student {d.GetName() +" "+ d.GetSurname()} passed: {d.HasPassedSession()}");
        Group group = new Group(new Students[] { a, b, c, d, e }, "CPR-511", "Software Developer", "2");
        Console.WriteLine("\nBefore");
        group.Print();
        Console.WriteLine("\nFailed");
        Console.WriteLine($"Expelled:{group.ExpelFailStudent()}");
        group.Print();
        Console.WriteLine("\nWorst");
        Students? worst = group.ExpelWorsStudents();
        Console.WriteLine($"Expelled:{worst.GetName()+" "+worst.GetSurname()}");
        group.Print();
    }
}