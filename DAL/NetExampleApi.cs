using Microsoft.EntityFrameworkCore;
using NetExampleApi.DAL.Models;

namespace NetExampleApi.DAL;

public class NetExampleApiDbContext : DbContext
{
    public NetExampleApiDbContext(DbContextOptions<NetExampleApiDbContext> options) : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}