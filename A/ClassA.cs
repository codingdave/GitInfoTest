using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public class ClassA
    {
        public ClassA()
        {
        }

        public override string ToString()
        {
            return $"A ThisAssembly.Git.Commit: {ThisAssembly.Git.Commit}";
        }
    }
}
