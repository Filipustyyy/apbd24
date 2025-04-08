
public class Emp
{
    public int Empno { get; set; }
    public string Ename { get; set; }
    public string Job { get; set; }
    public int? Mgr { get; set; }
    public decimal Sal { get; set; }
    public int Deptno { get; set; }
}

public class Dept
{
    public int Deptno { get; set; }
    public string Dname { get; set; }
}

public class Salgrade
{
    public int Grade { get; set; }
    public int Losal { get; set; }
    public int Hisal { get; set; }
}