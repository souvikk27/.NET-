using System;

interface Example{
    void ex();
    int ex1();
    string ex2(string str);
}
class Solution : Example
{
    public static void Main(string[] args)
    {
        var obj = new Solution();
        obj.ex1();
        int x = obj.ex1();
        Console.WriteLine(x);
        string y = obj.ex2("Souvik");
        Console.WriteLine(y);
        obj.ex();

    }

    public void ex()
    {
        Console.WriteLine("Void Function!");
    }

    public int ex1()
    {
        return 1;
    }

    public string ex2(string str)
    {
        return str;
    }
}