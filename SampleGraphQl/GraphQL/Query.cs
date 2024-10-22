using SampleGraphQl.Data;
using SampleGraphQl.Entities;

namespace SampleGraphQl.GraphQL;

public class Query
{
    //private readonly ApplicationDbContext _context;
    //public Query(ApplicationDbContext context) => _context = context;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<User> Users([Service] ApplicationDbContext _context)
        => _context.Users;

    [UseProjection]
    public User User([Service] ApplicationDbContext _context, int id)
        => _context.Users.FirstOrDefault(u => u.Id == id);

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Article> Articles([Service] ApplicationDbContext _context)
        => _context.Articles;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Entities.Tag> Tags([Service] ApplicationDbContext _context)
        => _context.Tags;

}
