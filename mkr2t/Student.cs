using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr2t
{
    public class Student : Person
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public string Specialty { get; set; }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
