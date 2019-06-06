using System;
using System.Composition;

namespace ConsoleApp_Mef2_DotNetCore
{
    [Export]
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
