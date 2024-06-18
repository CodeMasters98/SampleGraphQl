using Microsoft.EntityFrameworkCore;
using SampleGraphQl.Data;
using SampleGraphQl.Entities;
using SampleGraphQl.GraphQL.Articles;
using SampleGraphQl.GraphQL.Users.Add;
using SampleGraphQl.GraphQL.Users.Delete;
using SampleGraphQl.GraphQL.Users.Update;

namespace SampleGraphQl.GraphQL;

public class Mutation
{
    //private readonly ApplicationDbContext _context;
    //public Mutation(ApplicationDbContext context) => _context = context;

    #region User
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

    public async Task<UpdateUserPayload> UpdateUserAsync(UpdateUserInput input, [Service] ApplicationDbContext _context)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == input.Id);
        if (user is null)
            return null;

        user.Name = input.Name;
        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return new UpdateUserPayload(user);
    }

    public async Task<DeleteUserPayload> DeleteUserAsync(DeleteUserInput input, [Service] ApplicationDbContext _context)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == input.Id);
        if (user is null)
            return new DeleteUserPayload("Not Deleted!!");

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return new DeleteUserPayload("Deleted!!");
    }
    #endregion


    #region Article
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
    #endregion

}
