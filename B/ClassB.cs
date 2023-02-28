using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using A;

namespace B
{
    public class ClassB
    {
        public ClassB()
        {
        }

        public override string ToString()
        {
            var a = new ClassA();
            return $"B ThisAssembly.Git.Commit: {ThisAssembly.Git.Commit}, A: {a}";
        }
    }
}
