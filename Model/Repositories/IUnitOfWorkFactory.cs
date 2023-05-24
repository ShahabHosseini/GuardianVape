﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Contracts.Repositories
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
