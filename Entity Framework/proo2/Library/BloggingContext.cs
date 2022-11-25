namespace Library
{
    internal class BloggingContext
    {
        private Microsoft.EntityFrameworkCore.DbContextOptions<BloggingContext> options;

        public BloggingContext(Microsoft.EntityFrameworkCore.DbContextOptions<BloggingContext> options)
        {
            this.options = options;
        }
    }
}