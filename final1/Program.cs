using System;

public class Program
{
    public static void Main(string[] args)
    {
        Exception[] exceps = {new ArgumentException(), new MyException(),
            new ArgumentNullException(), new DivideByZeroException(),
            new IndexOutOfRangeException() };


        foreach (Exception ex in exceps)
        {
            try
            {
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

class MyException : Exception
{

    public MyException(string message)
    : base(message) { }

    public MyException()
    : base() { }

}
