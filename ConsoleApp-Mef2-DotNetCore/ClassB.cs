using System;
using System.Composition;

namespace ConsoleApp_Mef2_DotNetCore
{
    [Export]
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
