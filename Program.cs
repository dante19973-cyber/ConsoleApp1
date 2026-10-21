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
        new Students().Print();
        a.Print();
        Students cop = new Students(a);
        cop.GetTest()[0] = 99;
        a.Print();
        cop.Print();
        Group en = new Group();
        en.Print();
        Group g1 = new Group(new Students[] { a, b, c }, "KN-21", "Computer", "2");
        g1.Print();
        Group g3 = new Group(g1);
        g1.AddStudent(d);
        g1.Print();
        g3.Print();
        g1.Print();
        a.SetName("Anna");
        g1.SetGname("KN-22");
        g1.SetType("Software");
        g1.SetGnumber("3");
        Console.WriteLine($"{g1.GetGname()} / {g1.GetType()} / {g1.GetGnumber()}");
        g1.SetGname("KN-21");
        g1.SetType("Computer");
        g1.SetGnumber("2");
        g1.AddStudent(e);
        g1.AddStudent(null);
        g1.Print(); 
        Group g2 = new Group(new Students[0], "KN-23", "Computer ", "1");
        Console.WriteLine(g1.TransStud(0, g2)); 
        Console.WriteLine(g1.TransStud(10, g2));
        Console.WriteLine(g1.TransStud(0, g1));
        g1.Print();                              
        g2.Print();                              
        Console.WriteLine(g1.RemFailStud());    
        g1.Print();   
        Console.WriteLine(g1.RemFailStud());
        Students? worst = g1.GetBedStud();
        Console.WriteLine($"Removed: {worst?.GetSurname()}");
        g1.Print();
        Console.WriteLine(en.GetBedStud() == null);
        Console.WriteLine(en.RemFailStud());
        g3.Print();
    }
}