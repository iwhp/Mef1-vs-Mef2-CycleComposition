using System;
using System.ComponentModel.Composition;

namespace ConsoleApp_Mef1_Mef2_DotNetFramework
{
    [System.Composition.Export]
    [System.ComponentModel.Composition.Export]
    [System.ComponentModel.Composition.PartCreationPolicy(System.ComponentModel.Composition.CreationPolicy.NonShared)]
    public class ClassB
    {
        [System.Composition.Import]
        [System.ComponentModel.Composition.Import]
        public Lazy<ClassA> ClassA { get; set; }

        private Guid InstanceId { get; set; }

        public ClassB()
        {
            this.InstanceId = Guid.NewGuid();
        }

        public void Log()
        {
            Console.WriteLine($"Class B - {this.InstanceId}");
        }
    }
}
