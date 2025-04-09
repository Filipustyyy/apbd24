namespace Cwiczenia5.Tests;

public class EmpDeptSalgradeTests
{
    //1 Pracownicy zarabiający wiecej niż X
    public static IEnumerable<Emp> SalHigherThan(List<Emp> emps, int x) =>
        emps.Where(e => e.Sal > x);
    
    //2 Pracownicy zarabiający mniej niż X
    public static IEnumerable<Emp> SalLowerThan(List<Emp> emps, int x) =>
        emps.Where(e => e.Sal < x);
    
    //3 Pracownicy by sal
    public static IEnumerable<Emp> EmpBySal(List<Emp> emps) =>
        emps.OrderByDescending(e => e.Sal);
    
    //4 Srednia pensja
    public static decimal AvgSalary(List<Emp> emps) =>
        emps.Average(e => e.Sal);
    
    //5 liczba unikalnych stanowisk
    public static int UniqueJobs(List<Emp> emps) =>
        emps.Select(e => e.Job).Distinct().Count();
    
    //6 Pracownicy na B
    public static IEnumerable<Emp> NamesStartingWithB(List<Emp> emps) =>
        emps.Where(e => e.Ename.StartsWith("B"));
    
    //7 Praco Alfabetycznie
    public static IEnumerable<string> EmpABC(List<Emp> emps)
    {
        return emps.OrderBy(e => e.Ename).Select(e => e.Ename);
    }
    
    //8 Pracownik + stanowisko
    public static IEnumerable<(string Ename, string Job)> EmpAndJobs(List<Emp> emps)
    {
        return emps.Select(e => (e.Ename, e.Job));
    }
    
    //9 Pracownicy z managerem
    public static IEnumerable<Emp> EmpWithMgr(List<Emp> emps)
    {
        return emps.Where(e => e.Mgr.HasValue);
    }
    
    //10 Liczba pracownikow
    public static int EmpCount(List<Emp> emps)
    {
        return emps.Count();
    }
    
    //11 Max pensja
    public static decimal MaxSalary(List<Emp> emps)
    {
        return emps.Max(e => e.Sal);
    }
    
    //12 Ilosc dzialow
    public static int DeptCount(List<Dept> depts)
    {
        return depts.Count();
    }
    
    
}