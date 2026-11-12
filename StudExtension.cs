namespace ConsoleApp1;

public static class StudExtension
{
    private const double PassGRA = 6;
    public static double CalculateGPA(this Students student)
    {
        uint[] all = student.GetTest().Concat(student.GetExam()).Concat(student.GetTern()).ToArray();
        if (all.Length == 0) return 0;
        return all.Average(g=>(double)g);
    }
    public static bool HasPassedSession(this Students student)
    {
        return student.CalculateGPA() >= PassGRA;
    }
}