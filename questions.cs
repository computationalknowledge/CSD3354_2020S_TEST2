using System;
using System.Diagnostics;
using System.Threading;
class sample
{
    public static void first()
    {
        Console.WriteLine("first method");
    }
    public void second()
    {
        first();
        Console.WriteLine("second method");
    }
    public void second(int i)
    {
        Console.WriteLine(i);
        second();
    }
}

class ArrayPlayground
{
    // Write a simple C# program that has an ARRAY and adds data of different types to that array.
    // write the code to iterate over the array.

    public void Run()
    {
        object[] o = new object[10];

        o[0] = (Object)(new String("Dog"));
        o[1] = 1;
        o[2] = true;
        o[3] = (Object)(new DateTime()); 
        o[4] = (Object)(new sample());
        o[5] = (Object)(new ArrayPlayground());
        o[6] = 1==1;

        foreach (var item in o)
        {
            try
            {
                var a = item.GetType();
                Console.WriteLine(item);
                Console.WriteLine(a); 
                Console.WriteLine("__________________________________");
            }
            catch (Exception e) { Console.WriteLine("msg : {0} {1}",item, e.Message ); }
        }
    }


}
class program
{
    public static void Main2()
    {
        sample obj = new sample();
        sample.first();
        obj.second(10);
    }

    public static void Main3()
    {

        string text = " The quick brown fox jumped over the lazy dog";
        foreach (char c in text)
            Console.Write(c);
        Thread.Sleep(50);
    }

    public static void Main()
    {
        ArrayPlayground ap = new ArrayPlayground();
        ap.Run();
    }
}
