using Microsoft.EntityFrameworkCore;

public class
    MovieAppContext : DbContext
{
    public MovieAppContext(DbContextOptions<MovieAppContext> options)
            : base(options)
    {
    }

    // this code below maps/represents our Movie model as a database table (movies)
    // in the database
    public DbSet<MovieApp.Models.Movie> Movie { get; set; }

    public DbSet<MovieApp.Models.Artist> Artist { get; set; }
}
