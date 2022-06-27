#nullable enable
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace cwiczenia10_mp_s23525.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}