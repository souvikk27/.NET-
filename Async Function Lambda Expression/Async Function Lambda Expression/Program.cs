using System;

class Solution
{
    public static void Main(string[] args)
    {
        //Action debug = () => System.Diagnostics.Debug.WriteLine("Expression Lambda");
        //debug();
        Action<string> debug = (s) => System.Diagnostics.Debug.WriteLine(s);
        debug("Expression Lambda with assigned vriable");

        Action statement = () =>
        {
            System.Diagnostics.Debug.WriteLine("Statement Lambda!");
            System.Diagnostics.Debug.WriteLine("Statement Lambda!");
            System.Diagnostics.Debug.WriteLine("Statement Lambda!");
            System.Diagnostics.Debug.WriteLine("Statement Lambda!");
        };
        statement();
    }
}