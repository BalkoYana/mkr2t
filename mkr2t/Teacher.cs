using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr2t
{
    public class Teacher : Person
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
