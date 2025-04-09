
public class Data
{
    public List<Emp> Emps = new List<Emp>{};
    
    public List<Dept> Depts = new List<Dept>{};

    public List<Salgrade> Salgrades = new List<Salgrade>{};

    public Data()
    {
        Emps.Add(new Emp { Empno = 7839, Ename = "KING", Job = "PRESIDENT", Mgr = null, Sal = 5000, Deptno = 10 });
        Emps.Add(new Emp { Empno = 7566, Ename = "JONES", Job = "MANAGER", Mgr = 7839, Sal = 2975, Deptno = 20 });
        Emps.Add(new Emp { Empno = 7902, Ename = "FORD", Job = "ANALYST", Mgr = 7566, Sal = 3000, Deptno = 20 });
        Emps.Add(new Emp { Empno = 7698, Ename = "BLAKE", Job = "MANAGER", Mgr = 7839, Sal = 2850, Deptno = 10});
        Emps.Add(new Emp { Empno = 7934, Ename = "MILLER", Job = "CLERK", Mgr = 7698, Sal = 1800, Deptno = 10 });
        Emps.Add(new Emp { Empno = 7788, Ename = "SCOTT", Job = "ANALYST", Mgr = 7566, Sal = 2100, Deptno = 20 });
        Emps.Add(new Emp { Empno = 7842, Ename = "TYLER", Job = "CLERK", Mgr = 7698, Sal = 1300, Deptno = 10 });
        
        Depts.Add(new Dept { Deptno = 10, Dname = "ACCOUNTING"});
        Depts.Add(new Dept { Deptno = 20, Dname = "RESEARCH"});
        Depts.Add(new Dept { Deptno = 30, Dname = "FREELOADING"});
        
        Salgrades.Add(new Salgrade { Grade = 1, Losal = 700, Hisal = 1200 });
        Salgrades.Add(new Salgrade { Grade = 2, Losal = 1201, Hisal = 1400 });
        Salgrades.Add(new Salgrade { Grade = 3, Losal = 1401, Hisal = 2000 });
        Salgrades.Add(new Salgrade { Grade = 4, Losal = 2001, Hisal = 3000 });
        Salgrades.Add(new Salgrade { Grade = 5, Losal = 3001, Hisal = 9999 });
    }
}
