using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public class PanaceaInjectAttribute : Attribute
    {
        public string Alias { get; set; }

        public string Description { get; set; }

        public string Example { get; set; }


        public PanaceaInjectAttribute(string alias, string description, string example)
        {
            Alias = alias;
            Description = description;
            Example = example;
        }
    }

}


