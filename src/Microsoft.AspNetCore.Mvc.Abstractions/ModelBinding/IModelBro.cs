﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc.ModelBinding
{
    public interface IModelBro
    {
        Task BindAsync(ModelBroContext bindingContext);
    }
}