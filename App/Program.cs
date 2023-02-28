using A;
using B;

internal class Program
{
    private static void Main(string[] _)
    {
        Console.WriteLine($"A {new ClassA()}");
        Console.WriteLine($"B {new ClassB()}");
        Console.WriteLine($"StaticClassB.TestVersion: {StaticClassB.TestVersion}");
        Console.WriteLine($"ThisAssembly.Git.Commit: {ThisAssembly.Git.Commit}");
    }
}