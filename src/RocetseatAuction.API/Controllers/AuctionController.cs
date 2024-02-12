﻿using Microsoft.AspNetCore.Mvc;
using RocetseatAuction.API.Entities;
using RocetseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocetseatAuction.API.Controllers;

public class AuctionController : RocketseatAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();
        if (result is null)
        {
            return NoContent();
        }

        return Ok(result);
    }

}
