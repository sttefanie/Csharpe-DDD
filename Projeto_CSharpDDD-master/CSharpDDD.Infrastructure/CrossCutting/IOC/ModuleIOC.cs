﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDDD.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
