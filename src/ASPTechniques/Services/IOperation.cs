﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTechniques.Services
{
    public interface IOperation
    {
        string OperationId { get; }
    }

    public interface IOperationTransient : IOperation { }
    public interface IOperationScoped : IOperation { }
    public interface IOperationSingleton : IOperation { }
}
