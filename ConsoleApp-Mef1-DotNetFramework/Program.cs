using System.ComponentModel.Composition.Hosting;

namespace ConsoleApp_Mef1_DotNetFramework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AggregateCatalog aggregateCatalog = new AggregateCatalog();
            aggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            CompositionContainer compositionContainer = new CompositionContainer(aggregateCatalog);

            {
                ClassA classA = compositionContainer.GetExportedValue<ClassA>();
                classA.Log();
                classA.ClassB.Value.Log();
                classA.ClassB.Value.Log();
            }

            {
                ClassA classA = compositionContainer.GetExportedValue<ClassA>();
                classA.Log();
                classA.ClassB.Value.Log();
                classA.ClassB.Value.Log();
            }

            {
                ClassB classB = compositionContainer.GetExportedValue<ClassB>();
                classB.Log();
                classB.ClassA.Value.Log();
                classB.ClassA.Value.Log();
            }

            {
                ClassB classB = compositionContainer.GetExportedValue<ClassB>();
                classB.Log();
                classB.ClassA.Value.Log();
                classB.ClassA.Value.Log();
            }
        }
    }
}
