using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core.Mvvm
{
    public sealed class ViewAttribute:Attribute
    {
        public Type Type { get; }
        public ViewAttribute(Type type)
        {
            Type = type;
        }
    }
}
