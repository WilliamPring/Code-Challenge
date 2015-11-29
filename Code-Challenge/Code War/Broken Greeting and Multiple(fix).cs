//Broken Greeting

public class Person
{
    public string Name { get; private set; }

    public Person(string strName)
    {
        this.Name = strName;
    }

    public string Greet(string strOtherName)
    {
        return string.Format("Hi {0}, my name is {1}", strOtherName, this.Name);
    }



    //Multiple fix

    public class CustomMath {
    public static int multiply(int a, int b) {
        return a * b;
    }
}
