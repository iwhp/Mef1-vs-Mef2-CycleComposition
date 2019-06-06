using System;

namespace ConsoleApp_Mef1_Mef2_DotNetFramework
{
    [System.Composition.Export]
    [System.ComponentModel.Composition.Export]
    [System.ComponentModel.Composition.PartCreationPolicy(System.ComponentModel.Composition.CreationPolicy.NonShared)]
    public class ClassA
    {
        [System.Composition.Import]
        [System.ComponentModel.Composition.Import]
        public Lazy<ClassB> ClassB { get; set; }

        private Guid InstanceId { get; set; }

        public ClassA()
        {
            this.InstanceId = Guid.NewGuid();
        }

        public void Log()
        {
            Console.WriteLine($"Class A - {this.InstanceId}");
        }
    }
}
