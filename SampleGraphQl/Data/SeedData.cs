using Microsoft.EntityFrameworkCore;
using SampleGraphQl.Entities;

namespace SampleGraphQl.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
        {

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                new User { Id = 1, Name = "John", Family = "Doe", Address = "1234 Main St", Phone = "555-111-1234", Age = 30 },
                new User { Id = 2, Name = "Jane", Family = "Smith", Address = "4321 Oak St", Phone = "555-222-5678", Age = 25 },
                new User { Id = 3, Name = "Michael", Family = "Johnson", Address = "9876 Pine Rd", Phone = "555-333-9101", Age = 40 },
                new User { Id = 4, Name = "Emily", Family = "Williams", Address = "5432 Birch Ln", Phone = "555-444-1122", Age = 22 },
                new User { Id = 5, Name = "David", Family = "Brown", Address = "6789 Cedar St", Phone = "555-555-1212", Age = 35 },
                new User { Id = 6, Name = "Sarah", Family = "Davis", Address = "1122 Elm St", Phone = "555-666-1234", Age = 28 },
                new User { Id = 7, Name = "Robert", Family = "Miller", Address = "2244 Maple Rd", Phone = "555-777-5678", Age = 45 },
                new User { Id = 8, Name = "Olivia", Family = "Martinez", Address = "3344 Oakwood Dr", Phone = "555-888-9101", Age = 32 },
                new User { Id = 9, Name = "James", Family = "Gonzalez", Address = "4455 Ash St", Phone = "555-999-1122", Age = 50 },
                new User { Id = 10, Name = "Mia", Family = "Hernandez", Address = "5566 Spruce Ave", Phone = "555-101-1212", Age = 29 },
                new User { Id = 11, Name = "Ethan", Family = "Moore", Address = "6677 Cedar Ln", Phone = "555-202-2345", Age = 26 },
                new User { Id = 12, Name = "Sophia", Family = "Taylor", Address = "7788 Hickory Dr", Phone = "555-303-3456", Age = 34 },
                new User { Id = 13, Name = "Alexander", Family = "Anderson", Address = "8899 Walnut Rd", Phone = "555-404-4567", Age = 42 },
                new User { Id = 14, Name = "Lucas", Family = "Thomas", Address = "9900 Beech St", Phone = "555-505-5678", Age = 27 },
                new User { Id = 15, Name = "Charlotte", Family = "Garcia", Address = "1111 Chestnut St", Phone = "555-606-6789", Age = 23 },
                new User { Id = 16, Name = "Benjamin", Family = "Martinez", Address = "2222 Willow Rd", Phone = "555-707-7890", Age = 38 },
                new User { Id = 17, Name = "Isabella", Family = "Rodriguez", Address = "3333 Poplar Ln", Phone = "555-808-8901", Age = 31 },
                new User { Id = 18, Name = "Liam", Family = "Harris", Address = "4444 Maple Dr", Phone = "555-909-9012", Age = 36 },
                new User { Id = 19, Name = "Amelia", Family = "Clark", Address = "5555 Palm St", Phone = "555-010-1234", Age = 33 },
                new User { Id = 20, Name = "Mason", Family = "Lee", Address = "6666 Pine Rd", Phone = "555-111-2345", Age = 48 });
                context.SaveChanges();
            }

            if (!context.Articles.Any())
            {
                context.Articles.AddRange(
                new Article { Id = 1, Title = "Understanding GraphQL", Image = "img1.jpg", Description = "Introduction to GraphQL", Like = 10, PublishDate = DateTime.Now.AddDays(-10), AuthorId = 1 },
                new Article { Id = 2, Title = "REST vs GraphQL", Image = "img2.jpg", Description = "A comparison between REST and GraphQL", Like = 15, PublishDate = DateTime.Now.AddDays(-5), AuthorId = 2 },
                new Article { Id = 3, Title = "Getting Started with .NET Core", Image = "img3.jpg", Description = "Beginner's guide to .NET Core", Like = 20, PublishDate = DateTime.Now.AddDays(-7), AuthorId = 3 },
                new Article { Id = 4, Title = "Understanding Entity Framework", Image = "img4.jpg", Description = "Deep dive into EF Core", Like = 25, PublishDate = DateTime.Now.AddDays(-12), AuthorId = 4 },
                new Article { Id = 5, Title = "Building APIs with .NET", Image = "img5.jpg", Description = "Learn to build robust APIs", Like = 18, PublishDate = DateTime.Now.AddDays(-15), AuthorId = 5 },
                new Article { Id = 6, Title = "Mastering C# Basics", Image = "img6.jpg", Description = "Master the basics of C#", Like = 30, PublishDate = DateTime.Now.AddDays(-2), AuthorId = 6 },
                new Article { Id = 7, Title = "Asynchronous Programming in .NET", Image = "img7.jpg", Description = "How to write async code", Like = 35, PublishDate = DateTime.Now.AddDays(-8), AuthorId = 7 },
                new Article { Id = 8, Title = "Introduction to Docker", Image = "img8.jpg", Description = "Basics of containerization", Like = 12, PublishDate = DateTime.Now.AddDays(-9), AuthorId = 8 },
                new Article { Id = 9, Title = "Advanced LINQ Queries", Image = "img9.jpg", Description = "Advanced querying with LINQ", Like = 22, PublishDate = DateTime.Now.AddDays(-14), AuthorId = 9 },
                new Article { Id = 10, Title = "Secure Your APIs", Image = "img10.jpg", Description = "Best practices for securing APIs", Like = 17, PublishDate = DateTime.Now.AddDays(-6), AuthorId = 10 },
                new Article { Id = 11, Title = "Intro to Cloud Computing", Image = "img11.jpg", Description = "Cloud computing basics", Like = 25, PublishDate = DateTime.Now.AddDays(-11), AuthorId = 11 },
                new Article { Id = 12, Title = "Working with Azure", Image = "img12.jpg", Description = "A guide to using Microsoft Azure", Like = 40, PublishDate = DateTime.Now.AddDays(-13), AuthorId = 12 },
                new Article { Id = 13, Title = "Blazor: Building Interactive UIs", Image = "img13.jpg", Description = "Build interactive UIs with Blazor", Like = 28, PublishDate = DateTime.Now.AddDays(-4), AuthorId = 13 },
                new Article { Id = 14, Title = "Kubernetes for Beginners", Image = "img14.jpg", Description = "Introduction to Kubernetes", Like = 33, PublishDate = DateTime.Now.AddDays(-16), AuthorId = 14 },
                new Article { Id = 15, Title = "Using Redis with .NET", Image = "img15.jpg", Description = "Using Redis as a cache", Like = 20, PublishDate = DateTime.Now.AddDays(-20), AuthorId = 15 },
                new Article { Id = 16, Title = "GraphQL in Production", Image = "img16.jpg", Description = "Deploying GraphQL services", Like = 23, PublishDate = DateTime.Now.AddDays(-3), AuthorId = 16 },
                new Article { Id = 17, Title = "WebSockets in .NET", Image = "img17.jpg", Description = "Working with WebSockets in .NET", Like = 19, PublishDate = DateTime.Now.AddDays(-18), AuthorId = 17 },
                new Article { Id = 18, Title = "Building Microservices", Image = "img18.jpg", Description = "Microservices architecture with .NET", Like = 27, PublishDate = DateTime.Now.AddDays(-17), AuthorId = 18 },
                new Article { Id = 19, Title = "Testing with xUnit", Image = "img19.jpg", Description = "Unit testing using xUnit", Like = 14, PublishDate = DateTime.Now.AddDays(-1), AuthorId = 19 },
                new Article { Id = 20, Title = "Design Patterns in C#", Image = "img20.jpg", Description = "Common design patterns in C#", Like = 37, PublishDate = DateTime.Now.AddDays(-19), AuthorId = 20 });
                context.SaveChanges();
            }

            if (!context.Tags.Any())
            {
                context.Tags.AddRange(
                new Entities.Tag { Id = 1, Name = "GraphQL", CreateAt = DateTime.Now.AddMonths(-2), ArticleId = 1 },
                new Entities.Tag { Id = 2, Name = "REST", CreateAt = DateTime.Now.AddMonths(-2), ArticleId = 2 },
                new Entities.Tag { Id = 3, Name = ".NET", CreateAt = DateTime.Now.AddMonths(-1), ArticleId = 3 },
                new Entities.Tag { Id = 4, Name = "Entity Framework", CreateAt = DateTime.Now.AddMonths(-3), ArticleId = 4 },
                new Entities.Tag { Id = 5, Name = "API", CreateAt = DateTime.Now.AddMonths(-4), ArticleId = 5 },
                new Entities.Tag { Id = 6, Name = "C#", CreateAt = DateTime.Now.AddMonths(-1), ArticleId = 6 },
                new Entities.Tag { Id = 7, Name = "Async", CreateAt = DateTime.Now.AddMonths(-5), ArticleId = 7 },
                new Entities.Tag { Id = 8, Name = "Docker", CreateAt = DateTime.Now.AddMonths(-3), ArticleId = 8 },
                new Entities.Tag { Id = 9, Name = "LINQ", CreateAt = DateTime.Now.AddMonths(-4), ArticleId = 9 },
                new Entities.Tag { Id = 10, Name = "Security", CreateAt = DateTime.Now.AddMonths(-6), ArticleId = 10 },
                new Entities.Tag { Id = 11, Name = "Cloud", CreateAt = DateTime.Now.AddMonths(-2), ArticleId = 11 },
                new Entities.Tag { Id = 12, Name = "Azure", CreateAt = DateTime.Now.AddMonths(-1), ArticleId = 12 },
                new Entities.Tag { Id = 13, Name = "Blazor", CreateAt = DateTime.Now.AddMonths(-5), ArticleId = 13 },
                new Entities.Tag { Id = 14, Name = "Kubernetes", CreateAt = DateTime.Now.AddMonths(-4), ArticleId = 14 },
                new Entities.Tag { Id = 15, Name = "Redis", CreateAt = DateTime.Now.AddMonths(-2), ArticleId = 15 },
                new Entities.Tag { Id = 16, Name = "Production", CreateAt = DateTime.Now.AddMonths(-3), ArticleId = 16 },
                new Entities.Tag { Id = 17, Name = "WebSockets", CreateAt = DateTime.Now.AddMonths(-1), ArticleId = 17 },
                new Entities.Tag { Id = 18, Name = "Microservices", CreateAt = DateTime.Now.AddMonths(-4), ArticleId = 18 },
                new Entities.Tag { Id = 19, Name = "Testing", CreateAt = DateTime.Now.AddMonths(-5), ArticleId = 19 },
                new Entities.Tag { Id = 20, Name = "Design Patterns", CreateAt = DateTime.Now.AddMonths(-6), ArticleId = 20 });
                context.SaveChanges();
            }
        }
    }
}
