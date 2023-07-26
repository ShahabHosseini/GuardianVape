﻿using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Service.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations.Repositories
{
    public class FileRepository : GenericRepository<Image>, IFileRepository
    {
        public FileRepository(DbContext context) : base(context)
        {
        }
    }
}