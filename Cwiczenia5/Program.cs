using Cwiczenia5.Tests;

public class Program
{
    public static void Main(string[] args)
    {
        Data data = new Data();
        
        Console.WriteLine("\n//1 Pracownicy zarabiający wiecej niż X");
        foreach (var e in EmpDeptSalgradeTests.SalHigherThan(data.Emps, 2500))
            Console.WriteLine($"{e.Ename} - {e.Sal}");
        
        Console.WriteLine("\n//2 Pracownicy zarabiający mniej niż X");
        foreach (var e in EmpDeptSalgradeTests.SalLowerThan(data.Emps, 2500))
            Console.WriteLine($"{e.Ename} - {e.Sal}");
        
        Console.WriteLine("\n//3 Pracownicy by sal");
        foreach (var e in EmpDeptSalgradeTests.EmpBySal(data.Emps))
            Console.WriteLine($"{e.Ename} - {e.Sal}");
        
        Console.WriteLine("\n//4 Avg Salary");
        Console.WriteLine(EmpDeptSalgradeTests.AvgSalary(data.Emps));

        Console.WriteLine("\n//5 Unique jobs count");
        Console.WriteLine(EmpDeptSalgradeTests.UniqueJobs(data.Emps));
        
        Console.WriteLine("\n//6 Imiona pracownikow zaczyanjace sie na B");
        foreach (var e in EmpDeptSalgradeTests.NamesStartingWithB(data.Emps))
            Console.WriteLine(e.Ename);
        
        Console.WriteLine("\n//7 Praco Alfabetycznie");
        foreach (var e in EmpDeptSalgradeTests.EmpABC(data.Emps))
            Console.WriteLine(e);
        
        Console.WriteLine("\n//8 Pracownik + stanowisko");
        foreach (var pair in EmpDeptSalgradeTests.EmpAndJobs(data.Emps))
            Console.WriteLine($"{pair.Ename} - {pair.Job}");
        
        Console.WriteLine("\n//9 Pracownicy z managerem");
        foreach (var e in EmpDeptSalgradeTests.EmpWithMgr(data.Emps))
            Console.WriteLine(e.Ename);
        
        Console.WriteLine("\n//10 Liczba pracownikow");
        Console.WriteLine(EmpDeptSalgradeTests.EmpCount(data.Emps));
        
        Console.WriteLine("\n//11 Max pensa");
        Console.WriteLine(EmpDeptSalgradeTests.MaxSalary(data.Emps));
        
        Console.WriteLine("\n//12 Ilosc dzialow");
        Console.WriteLine(EmpDeptSalgradeTests.DeptCount(data.Depts));
        
        Console.WriteLine("\n//13 Empy na Dept");
        foreach (var (dept, count) in AdvancedEmpDeptTests.EmployeeCountPerDept(data.Emps, data.Depts))
            Console.WriteLine($"{dept}: {count} employees");
        
        Console.WriteLine("\n//14 Pracownicy z Dept name");
        foreach (var (ename, dname) in AdvancedEmpDeptTests.EmpWithDeptName(data.Emps, data.Depts))
            Console.WriteLine($"{ename} works in {dname}");
        
        Console.WriteLine("\n//15 Employees in Top Salary Grade ==");
        foreach (var emp in AdvancedEmpDeptTests.EmployeesInTopGrade(data.Emps, data.Salgrades))
            Console.WriteLine($"{emp.Ename} earns {emp.Sal}");
        
        Console.WriteLine("\n//16 Koledzy ziutka o nazwie SCOTT");
        foreach (var emp in AdvancedEmpDeptTests.ColleaguesOfy(data.Emps, "SCOTT"))
            Console.WriteLine($"{emp.Ename} (Dept: {emp.Deptno})");
        
        Console.WriteLine("\n//17 Sklad top zarabiajacego dept");
        foreach (var emp in AdvancedEmpDeptTests.EmpsFromTopAvgSalaryDept(data.Emps))
            Console.WriteLine($"{emp.Ename} from Dept {emp.Deptno}");
        
        Console.WriteLine("\n//18 Sklad najwiekszego dept");
        foreach (var emp in AdvancedEmpDeptTests.FromMostPopulatedDept(data.Emps))
            Console.WriteLine($"{emp.Ename} from Dept {emp.Deptno}");
        
        Console.WriteLine("\n//19 Mastery i slave'y");
        foreach (var (mgr, count) in AdvancedEmpDeptTests.ManagersWithSlaves(data.Emps))
            Console.WriteLine($"{mgr} has {count} minions");

        Console.WriteLine("\n//20. Departament bez pracownikow");
        foreach (var dept in AdvancedEmpDeptTests.DeptsWOemp(data.Depts, data.Emps))
            Console.WriteLine($"{dept.Dname} has no employees");
    }
    
}