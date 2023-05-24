﻿using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Contracts.Repositories
{
    //It's for ConditionRole Condition Type and ConditionRoleType
    public interface IConditionRepository : IGenericRepository<ConditionRole>
    {
    }
}