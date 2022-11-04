﻿using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public interface IRepository <T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get (int id);
    }
}

