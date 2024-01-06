using Microsoft.EntityFrameworkCore;
using WortEx.Infrastructure.Database.Models;

namespace WortEx.Infrastructure.Database.Context;

public class MessageContext : DbContext
{
    public DbSet<MessageModel> Messages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMongoDB("mongodb://localhost:27017", "WortEx");
    }
}