﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTepl
{
    class DepoNotFoundException : Exception
    {
        public DepoNotFoundException(int i) : base("Не найден поезд по месту " + i)
        { }
    }
}
