using Microsoft.EntityFrameworkCore.Design;

namespace Dependencies.Database
{
    public class DesignTimeContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args) => new MyContext();
    }
}
