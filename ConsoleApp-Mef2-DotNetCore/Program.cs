using System.Composition.Hosting;

namespace ConsoleApp_Mef2_DotNetCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContainerConfiguration containerConfiguration = new ContainerConfiguration().WithAssembly(typeof(Program).Assembly);
            CompositionHost compositionHost = containerConfiguration.CreateContainer();

            {
                ClassA classA = compositionHost.GetExport<ClassA>();
                classA.Log();
                classA.ClassB.Value.Log();
                classA.ClassB.Value.Log();
            }

            {
                ClassA classA = compositionHost.GetExport<ClassA>();
                classA.Log();
                classA.ClassB.Value.Log();
                classA.ClassB.Value.Log();
            }

            {
                ClassB classB = compositionHost.GetExport<ClassB>();
                classB.Log();
                classB.ClassA.Value.Log();
                classB.ClassA.Value.Log();
            }

            {
                ClassB classB = compositionHost.GetExport<ClassB>();
                classB.Log();
                classB.ClassA.Value.Log();
                classB.ClassA.Value.Log();
            }
        }
    }
}
