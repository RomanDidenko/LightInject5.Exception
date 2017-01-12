using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public interface IFoo : IDisposable
    { }

    public class Foo : IFoo
    {
        public Foo()
        {
        }

        public void Dispose()
        {

        }
    }
}
