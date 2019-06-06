namespace ConsoleApp_Mef1_Mef2_DotNetFramework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region MEF1

            System.ComponentModel.Composition.Hosting.AggregateCatalog aggregateCatalog = new System.ComponentModel.Composition.Hosting.AggregateCatalog();
            aggregateCatalog.Catalogs.Add(new System.ComponentModel.Composition.Hosting.AssemblyCatalog(typeof(Program).Assembly));
            System.ComponentModel.Composition.Hosting.CompositionContainer compositionContainer = new System.ComponentModel.Composition.Hosting.CompositionContainer(aggregateCatalog);

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

            #endregion

            #region MEF2

            System.Composition.Hosting.ContainerConfiguration containerConfiguration = new System.Composition.Hosting.ContainerConfiguration().WithAssembly(typeof(Program).Assembly);
            System.Composition.Hosting.CompositionHost compositionHost = containerConfiguration.CreateContainer();

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

            #endregion
        }
    }
}
