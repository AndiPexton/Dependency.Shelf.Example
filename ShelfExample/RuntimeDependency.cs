using System;
using ExampleGateway;

namespace ShelfExample
{
    internal class RuntimeDependency : IInjectedDependency
    {
        public void DoSomething() => 
            Console.WriteLine("Done Something!");
    }
}