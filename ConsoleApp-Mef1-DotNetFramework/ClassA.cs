using System;
using System.ComponentModel.Composition;

namespace ConsoleApp_Mef1_DotNetFramework
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ClassA
    {
        [Import]
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
