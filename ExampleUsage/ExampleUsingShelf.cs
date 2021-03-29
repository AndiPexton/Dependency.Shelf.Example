using ExampleGateway;
using static Dependency.Shelf;

namespace ExampleUsage
{
    public class ExampleUsingShelf
    {
        private static IInjectedDependency InjectedDependency =>
            RetrieveInstance<IInjectedDependency>();

        public static void RunSomeDependentCode()
        {
            InjectedDependency.DoSomething();
        }
    }
}