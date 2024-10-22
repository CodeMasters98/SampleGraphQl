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
    [UseFiltering]
    [UseSorting]
    public IQueryable<Article> Articles([Service] ApplicationDbContext _context)
        => _context.Articles;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Entities.Tag> Tags([Service] ApplicationDbContext _context)
        => _context.Tags;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IEnumerable<GroupedUser> GetUsersGroupedByAge([Service] ApplicationDbContext _context)
    {
        var users = _context.Set<User>().ToList();
        return users.GroupBy(u => u.Age)
                    .Select(g => new GroupedUser
                    {
                        Age = g.Key,
                        Users = g.ToList()
                    });
    }
}

public class GroupedUser
{
    public int? Age { get; set; }
    public List<User> Users { get; set; }
}