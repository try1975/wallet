using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class ClientsController : TypedController<ClientDto, string>
    {
        public ClientsController(IClientApi api) : base(api)
        {
        }
    }
    //[RoutePrefix(WalletConstants.ClientAppApi.Clients)]
    //[Authorize]
    //public class ClientsController : ApiController
    //{
    //    private readonly IClientApi _clientApi;
    //    public ClientsController(IClientApi clientApi)
    //    {
    //        _clientApi = clientApi;
    //    }

    //    [HttpGet]
    //    [Route("", Name = nameof(GetClients) + Ro.Route)]
    //    public IEnumerable<ClientDto> GetClients()
    //    {
    //        return  _clientApi.GetItems();
    //    }


    //    [HttpPost]
    //    [Route("", Name = nameof(PostClient) + Ro.Route)]
    //    [ResponseType(typeof(ClientDto))]
    //    public IHttpActionResult PostClient (ClientDto creatingDto)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        var dto = _clientApi.AddItem(creatingDto);
    //        if (dto == null)
    //        {
    //            return BadRequest("POST failed.");
    //        }
    //        return Ok(dto);
    //    }

    //}
}
