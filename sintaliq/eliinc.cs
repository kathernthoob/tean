public class BaseClass
{
    public virtual void MyMethod()
    {
        Console.WriteLine("BaseClass.MyMethod");
    }
}

public class DerivedClass : BaseClass
{
    public override void MyMethod()
    {
        Console.WriteLine("DerivedClass.MyMethod");
    }
}
