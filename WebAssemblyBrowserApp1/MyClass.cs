using System.Runtime.InteropServices.JavaScript;

public partial class MyClass
{
    [JSExport]
    private static string Greeting() => "Greetings from .NET";
    
    [JSExport]
    private static int Sum(int a, int b) => a + b;
}