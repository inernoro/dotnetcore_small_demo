﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core.Dependency;

namespace demo.core
{
    public interface IStore : ITransientDependency
    {
        void StoreWrite(string field, string value);
         
    }
}
