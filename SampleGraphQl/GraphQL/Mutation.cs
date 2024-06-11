using SampleGraphQl.Data;
using SampleGraphQl.Entities;
using SampleGraphQl.GraphQL.Articles;
using SampleGraphQl.GraphQL.Users;

namespace SampleGraphQl.GraphQL;

public class Mutation
{
    //private readonly ApplicationDbContext _context;
    //public Mutation(ApplicationDbContext context) => _context = context;

    public async Task<AddUserPayload> AddUserAsync(AddUserInput input, [Service] ApplicationDbContext _context)
    {
        var user = new User
        {
            Name = input.Name
        };

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return new AddUserPayload(user);
    }

    public async Task<AddArticlePayload> AddArticleAsync(AddArticleInput input, [Service] ApplicationDbContext _context)
    {
        var aricle = new Article
        {
            Title = input.Title,
            Description = input.Description,
            AuthorId = input.AuthorId
        };


        await _context.Articles.AddAsync(aricle);
        await _context.SaveChangesAsync();

        return new AddArticlePayload(aricle);
    }


}
