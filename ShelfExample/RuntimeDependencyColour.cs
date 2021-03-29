using System;
using ExampleGateway;

namespace ShelfExample
{
    internal class RuntimeDependencyColour : IInjectedDependency
    {
        public void DoSomething()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Done Something ... in colour");
            Console.ResetColor();
        }
    }
}