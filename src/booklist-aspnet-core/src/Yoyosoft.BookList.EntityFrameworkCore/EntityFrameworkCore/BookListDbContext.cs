using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yoyosoft.BookList.Authorization.Roles;
using Yoyosoft.BookList.Authorization.Users;
using Yoyosoft.BookList.BookListManagement.Books;
using Yoyosoft.BookList.BookListManagement.BookTags;
using Yoyosoft.BookList.BookListManagement.CloudBookList;
using Yoyosoft.BookList.MultiTenancy;

namespace Yoyosoft.BookList.EntityFrameworkCore
{
    public class BookListDbContext : AbpZeroDbContext<Tenant, Role, User, BookListDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Book> Books { get; set; }

        public DbSet<CloudBookList> BookLists { get; set; }

        public DbSet<BookTag> BookTags { get; set; }

        public BookListDbContext(DbContextOptions<BookListDbContext> options)
            : base(options)
        {
        }
    }
}
