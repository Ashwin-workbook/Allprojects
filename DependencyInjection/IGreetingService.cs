using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal interface IGreetingService
    {
        void Greet(string name);
    }
}
