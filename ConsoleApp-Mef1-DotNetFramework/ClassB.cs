using System;
using System.ComponentModel.Composition;

namespace ConsoleApp_Mef1_DotNetFramework
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ClassB
    {
        [Import]
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
