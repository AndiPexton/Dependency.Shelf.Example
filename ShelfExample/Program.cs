using System;
using System.Runtime.CompilerServices;
using ExampleGateway;
using ExampleUsage;
using static Dependency.Shelf;

namespace ShelfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // This example does not reflect real life usage,
            // and serves as an example only!

            // Shelve and call
            ShelveInstance<IInjectedDependency>(new RuntimeDependency());
            ExampleUsingShelf.RunSomeDependentCode();

            // Clear, Shelve and Call
            ClearInstance<IInjectedDependency>();
            ShelveInstance<IInjectedDependency>(new RuntimeDependencyColour());
            ExampleUsingShelf.RunSomeDependentCode();

            // Clear shelf and attempt call
            Clear();
            try
            {
                ExampleUsingShelf.RunSomeDependentCode();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null");
            }

            // Shelf and call again
            ShelveInstance<IInjectedDependency>(new RuntimeDependency());
            ExampleUsingShelf.RunSomeDependentCode();
        }
    }
}
