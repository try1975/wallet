using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.GetFiles;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class StatementsController : TypedController<StatementDto, Guid>
    {
        public StatementsController(IStatementApi api) : base(api)
        {
        }

        public override IEnumerable<StatementDto> Get()
        {
            var list = _api.GetItems();
            var baseUri = $"{Request.RequestUri.Scheme}://{Request.RequestUri.Host}:{Request.RequestUri.Port}";
            var statements = list as StatementDto[] ?? list.ToArray();
            foreach (var statementDto in statements)
            {
                var uri = $"{baseUri}/GetFiles/{nameof(GetStatementFile)}.ashx?id={statementDto.Id}";
                statementDto.StatementLink = new Uri(uri);
            }


            return statements;
        }
    }
}
