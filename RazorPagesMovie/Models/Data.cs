using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public class Data
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>());
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("RazorPagesMovieContext");
            }
            if (context.Movie.Any())
            {
                return;
            }
            context.Movie.AddRange(
                    );
            context.SaveChanges();
        }
    }
}
