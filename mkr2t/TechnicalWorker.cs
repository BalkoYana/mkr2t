﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr2t
{
    public class TechnicalWorker : Person
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
