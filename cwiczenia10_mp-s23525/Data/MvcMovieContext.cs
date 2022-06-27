#nullable enable
using Microsoft.EntityFrameworkCore;

namespace cwiczenia10_mp_s23525.Data;

public class MvcMovieContext : DbContext
{
    public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
        : base(options)
    {
    }

    public DbSet<cwiczenia10_mp_s23525.Models.Movie>? Movie { get; set; }
}