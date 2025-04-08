namespace Cwiczenia5.Tests;

public class AdvancedEmpDeptTests
{
    //1 Ile pracowników w każdym dziale
    public static IEnumerable<(string DeptName, int Count)> EmployeeCountPerDept(IEnumerable<Emp> emps, IEnumerable<Dept> depts) =>
        emps.GroupBy(e => e.Deptno)
            .Join(depts,
                g => g.Key,
                d => d.Deptno,
                (g, d) => (d.Dname, g.Count()));
    
    //2 Pracownicy ze swoim wydzialem
    public static IEnumerable<(string Ename, string DeptName)> EmpWithDeptName(IEnumerable<Emp> emps, IEnumerable<Dept> depts) =>
        emps.Join(depts, e => e.Deptno, d => d.Deptno, (e, d) => (e.Ename, d.Dname));
    
    //3 Pracownicy w najwyższej klasie płacowej
    public static IEnumerable<Emp> EmployeesInTopGrade(IEnumerable<Emp> emps, IEnumerable<Salgrade> grades)
    {
        var topGrade = grades.OrderByDescending(g => g.Grade).First();
        return emps.Where(e => e.Sal >= topGrade.Losal && e.Sal <= topGrade.Hisal);
    }
}