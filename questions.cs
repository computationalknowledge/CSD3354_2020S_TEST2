using System;
using System.Diagnostics;
using System.Threading;

class Student
{
    public Student(string aName, float theirGPA)
    {
        this.name = aName;
        this.gpa = theirGPA;
    }
    string name;
    float gpa;
}
class ArrayPlayground
{
    // Write a simple C# program that has an ARRAY and adds data of different types to that array.
    // write the code to iterate over the array.
    object[] obj1 = new object[10];
    public void PackData()
    {
        // step 1. Create an ARRAY of type OBJECT (appicable to any data structure as Stack or Queue)
        // object is the parent container of ALL OTHER OBJECTS in C# (and Java)
        // That means that if I type my array as OBJECT, I put ANYTHING primitive or object in it!
        // remember that all the primitives have Wrapper Classes, which is what let's a primitive
        // such as int, get treated as an OBJECT
        // eg. int (a primitive) -> Int32 (object)
        // Step 2: We must use OBJECT CASTING as shown below!

        obj1[0] = (Object)(new String("Dog"));
        obj1[1] = 1;
        obj1[2] = true;
        obj1[3] = (Object)(new DateTime());
        obj1[4] = (Object)(new Student("Harpeet", 4.0f));
        obj1[5] = (Object)(new ArrayPlayground());
        obj1[6] = 1 == 2; // this is functionally equivalent to boolean false

        // so we have done half the work: getting the data INTO THE ARRAY
        // Now the 2nd part of our JOB is to extract the Data back OUT:
    }

    public void UnPackData() {

        foreach (var item in obj1)
        {
            Console.WriteLine(item.GetType());
        }
    }


}
class Program
{
    public static void Main()
    {
            ArrayPlayground ap = new ArrayPlayground();
            ap.PackData();
            ap.UnPackData();
    }
}
