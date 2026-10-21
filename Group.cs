namespace ConsoleApp1;

public class Group
{
    private Students[] _students;
    private string? gname;
    private string? type;
    private string gnumber;

    public Group(Students[]? students, string? gname, string? type, string gnumber)
    {
        _students = CloneArray(students);
        this.gname = gname;
        this.type = type;
        this.gnumber = gnumber; 
    }

    public Group()
    {
        _students = new Students[0];
        gname = null;
        type = null;
        gnumber = "0";
    }
    public Group(Students[] students)
    {
        this._students = CloneArray(students);
        this.gname = null;
        this.type = null;
        this.gnumber = "0"; 
    }
    private Students[] CloneArray(Students[]? array)
    {
        if (array == null) return new Students[0];
        Students[] res = new Students[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            res[i] = new Students(array[i]);
        }
        return res;
    }

    public Group(Group other)
    {
        _students = CloneArray(other._students);
        gname = other.gname;
        type = other.type;
        gnumber = other.gnumber;
    }
    public Students[] GetStudents()
    {
        return CloneArray(_students);
    }
    public string? GetGname()
    {
        return gname;
    }
    public string? GetType()
    {
        return type;
    }
    public string GetGnumber()
    {
        return gnumber;
    }
    public void SetStudents(Students[] students)
    {
        _students = CloneArray(students);
    }
    public void SetGname(string? gname)
    {
        this.gname = gname;
    }
    public void SetType(string? type)
    {
        this.type = type;
    }
    public void SetGnumber(string gnumber)
    {
        this.gnumber = gnumber;
    }

    public void Print()
    {
        Console.WriteLine($"Group name: {gname}\n Type: {type}\n");
        Students[] sort = (Students[])_students.Clone();
        Array.Sort(sort, (a, b) =>{
            int res = string.Compare(a.GetSurname(), b.GetSurname());
        if (res != 0) return res;
        return string.Compare(a.GetName(), b.GetName());
    });
        for (int i = 0; i < sort.Length; i++)
        {
            Console.WriteLine($"{i+1} {sort[i].GetSurname()} {sort[i].GetName()} {sort[i].GetSecondName()}");
        }
    }
    public void AddStudent(Students? student)
    {
        if (student == null) return;
        Array.Resize(ref _students, _students.Length + 1);
        _students[_students.Length - 1] = student;   
    }
    public bool RemoveStudent(Students student)
    {
        int index=Array.IndexOf(_students, student);
        return RemoveStudent(index);
    }
    public bool RemoveStudent(int index)
    {
        if (index < 0 || index >= _students.Length) return false;
        for (int i = index; i < _students.Length - 1; i++)
        {
            _students[i] = _students[i + 1];
        }
        Array.Resize(ref _students, _students.Length - 1);
        return true;
    }
    
    public bool TransStud(int index, Group targ)
    {
        if (targ == null || targ == this) return false;
        if (index < 0 || index >= _students.Length) return false;
        Students student = _students[index];
        RemoveStudent(index);
        targ.AddStudent(student);
        return true;
    }
    public bool IsFail(Students student)
    {
        return student.GetTest().Any(x => x < 2)
            || student.GetExam().Any(x => x < 2)
            || student.GetTern().Any(x => x < 2);
    }

    public int RemFailStud()
    {
        int befor=_students.Length;
        _students = Array.FindAll(_students,s => !IsFail(s));
        return befor - _students.Length;
    }
    private double GetAverage(Students student)
    {
        uint[] all = student.GetTest().Concat(student.GetExam()).Concat(student.GetTern()).ToArray();
        if (all.Length == 0) return 0;
        return all.Average(g=>(double)g);
    }
    public Students? GetBedStud()
    {
        if (_students.Length == 0) return null;
        int wor = 0;
        for (int i = 1; i < _students.Length; i++)
        {
            if (GetAverage(_students[i]) < GetAverage(_students[wor]))
                wor = i;
        }
        Students rem=_students[wor];
        RemoveStudent(wor);
        return rem;
    }
}