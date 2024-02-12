using Microsoft.EntityFrameworkCore;
using RocetseatAuction.API.Entities;

namespace RocetseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\www\\RocketseatAuction\\leilaoDbNLW.db");
    }
}
