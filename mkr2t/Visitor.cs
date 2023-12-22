using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr2t
{
    public interface Visitor
    {
        void Visit(Teacher teacher);
        void Visit(Student student);
        void Visit(TechnicalWorker worker);
    }
}
