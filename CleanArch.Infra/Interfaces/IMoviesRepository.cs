﻿using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Interfaces
{
    public interface IMoviesRepository
    {
        List<Movie> GetAll();
    }
}
