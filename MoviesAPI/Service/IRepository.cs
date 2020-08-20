﻿using MoviesAPI.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Service
{
    public interface IRepository
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int Id);
    }
}
