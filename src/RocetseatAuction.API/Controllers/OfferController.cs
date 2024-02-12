using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocetseatAuction.API.Comunication.Requests;
using RocetseatAuction.API.Filters;
using RocetseatAuction.API.UseCases.Offers.CreateOffer;

namespace RocetseatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase usecase
    )
    {
        var id = usecase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
