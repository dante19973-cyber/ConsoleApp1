namespace ConsoleApp1;
public class Students(
    string? name,
    string? secondName,
    string? surname,
    DateTime? birthday,
    string? address,
    string? phone,
    uint[] test,
    uint[] exam,
    uint[] tern)
{
    private string? _name = name;
    private string? _secondName = secondName;
    private string? _surname = surname;
    private DateTime? _birthday = birthday;
    private string? _address = address;
    private string? _phone = phone;
    private uint[] _test = test;
    private uint[] _exam = exam;
    private uint[] _tern = tern;

     public Students(Students other) : this(other._name, other._secondName, other._surname, other._birthday, other._address, other._phone, other._test, other._exam, other._tern)
 {
 }

public Students() : this("John", "Ivanovich", "Doe", new DateTime(2001, 5, 19), "Home", "123456", [3, 4, 5], [5,4,3], [2,3,4 ])
{
}
public void SetName(string? name)
{
    this._name = name;
}
public void SetSecondName(string? secondName)
{
    this._secondName = secondName;
}
public void SetSurname(string? surname)
{
    this._surname = surname;
}
public void SetBirthday(DateTime? birthday)
{
    this._birthday = birthday;
}
public void SetAddress(string? address)
{
    this._address = address;
}
public void SetPhone(string? phone)
{
    this._phone = phone;
}
public void SetTest(uint[] test)
{
    this._test = test;
}

public void SetExam(uint[] exam)
{
    this._exam = exam;
}
public void SetTern(uint[] tern)
{
    this._tern = tern;
}
public string? GetName()
{
    return _name;
}
public string? GetSecondName()
{
    return _secondName;
}
public string? GetSurname()
{
    return _surname;
}
public DateTime? GetBirthday()
{
    return _birthday;
}

public string? GetAddress()
{
    return _address;
}
public string? GetPhone()
{
    return _phone;
}
public uint[] GetTest()
{
    return _test;
}

public uint[] GetExam()
{
    return _exam;
}
public uint[] GetTern()
{
    return _tern;
}

public void Print()
{
    Console.WriteLine(
        $"Name: {_name} \n SecondName: {secondName}\n Surname: {surname}\n Birthday: {birthday}\n Address: {address}\n Phone: {phone}\n Test: {string.Join(", ", test)}\n Exam: {string.Join(", ", exam)}\n Tern: {string.Join(", ", tern)}");
}
}