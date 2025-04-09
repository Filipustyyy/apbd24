namespace Cwiczenia5.Tests;

public class AdvancedEmpDeptTests
{
    //13 Ile pracowników w każdym dziale
    public static IEnumerable<(string DeptName, int Count)> EmployeeCountPerDept(List<Emp> emps,
        List<Dept> depts)
    {
        return emps.GroupBy(e => e.Deptno)
            .Join(depts,
                g => g.Key,
                d => d.Deptno,
                (g, d) => (d.Dname, g.Count()));
    }
    
    //14 Pracownicy ze swoim wydzialem
    public static IEnumerable<(string Ename, string DeptName)> EmpWithDeptName(List<Emp> emps,
        IEnumerable<Dept> depts)
    {
        return emps.Join(depts, e => e.Deptno, d => d.Deptno, (e, d) => (e.Ename, d.Dname));
    }
    
    //15 Pracownicy w najwyższej klasie płacowej
    public static IEnumerable<Emp> EmployeesInTopGrade(List<Emp> emps, List<Salgrade> grades)
    {
        var topGrade = grades.OrderByDescending(g => g.Grade).First();
        return emps.Where(e => e.Sal >= topGrade.Losal && e.Sal <= topGrade.Hisal);
    }
    
    //16 Wspolpracownicy pana/pani Y
    public static IEnumerable<Emp> ColleaguesOfy(List<Emp> emps, String name)
    {
        var deptOfJones = emps.FirstOrDefault(e => e.Ename == name)?.Deptno;
        return emps.Where(e => e.Deptno == deptOfJones && e.Ename != name);
    }
    
    //17 Pracownicy z dzialu o top sredniej pensji
    public static IEnumerable<Emp> EmpsFromTopAvgSalaryDept(List<Emp> emps)
    {
        var deptWithMaxAvg = emps.GroupBy(e => e.Deptno)
            .OrderByDescending(g => g.Average(e => e.Sal))
            .First().Key;
        return emps.Where(e => e.Deptno == deptWithMaxAvg);
    }
    
    //18 Pracownicy z dzialu najwiecej pracownikow
    public static IEnumerable<Emp> FromMostPopulatedDept(List<Emp> emps)
    {
        var mostPopulatedDept = emps.GroupBy(e => e.Deptno)
            .OrderByDescending(g => g.Count())
            .First().Key;
        return emps.Where(e => e.Deptno == mostPopulatedDept);
    }
    
    //19 Managerowie i podwladni
    public static IEnumerable<(string ManagerName, int SubordinateCount)> ManagersWithSlaves(List<Emp> emps)
    {
        return emps.Where(m => emps.Any(e => e.Mgr == m.Empno))
            .Select(m => (m.Ename, emps.Count(e => e.Mgr == m.Empno)));
    }
    
    //20 Puste dzialy
    public static IEnumerable<Dept> DeptsWOemp(List<Dept> depts, List<Emp> emps)
    {
        var deptnosWithEmps = emps.Select(e => e.Deptno).Distinct();
        return depts.Where(d => !deptnosWithEmps.Contains(d.Deptno));
    }
}