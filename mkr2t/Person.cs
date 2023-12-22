using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr2t
{
    public interface Person
    {   
        string Name { get; set; }
        void Accept(Visitor visitor);
    }
}
