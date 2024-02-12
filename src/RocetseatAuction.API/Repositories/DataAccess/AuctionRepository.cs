using Microsoft.EntityFrameworkCore;
using RocetseatAuction.API.Entities;

namespace RocetseatAuction.API.Repositories.DataAccess;

public class AuctionRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;

    public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        return _dbContext
           .Auctions
           .Include(auction => auction.Items)
           .First();
        //.FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);

    }

}
