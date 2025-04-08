namespace Cwiczenia5.Tests;

public class EmpDeptSalgradeTests
{
    //1 Pracownicy zarabiający wiecej niż X
    public static IEnumerable<Emp> SalHigherThan(IEnumerable<Emp> emps, int x) =>
        emps.Where(e => e.Sal > x);
    
    public static bool SalLowerThan(IEnumerable<Emp> emps, int x) =>
        emps.Any(e => e.Sal < x);
    
    //2 Pracownicy by sal
    public static IEnumerable<Emp> OrderBySalDesc(IEnumerable<Emp> emps) =>
        emps.OrderByDescending(e => e.Sal);
    
    //3 Srednia pensja
    public static decimal AvgSalary(IEnumerable<Emp> emps) =>
        emps.Average(e => e.Sal);
    
    //4 liczba unikalnych stanowisk
    public static IEnumerable<string> UniqueJobs(IEnumerable<Emp> emps) =>
        emps.Select(e => e.Job).Distinct();
    
    //5 Pracownicy na B
    public static IEnumerable<Emp> NamesStartingWithM(IEnumerable<Emp> emps) =>
        emps.Where(e => e.Ename.StartsWith("B"));
    
    //6
    
    
    //7
}