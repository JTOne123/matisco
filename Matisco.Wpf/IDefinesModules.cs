﻿using Autofac;
using System;
using System.Collections.Generic;

namespace Matisco.Wpf
{
    public interface IDefinesModules
    {
        IEnumerable<Type> GetPrismModuleTypes();

        IEnumerable<Module> GetAutofacModules();
    }
}
