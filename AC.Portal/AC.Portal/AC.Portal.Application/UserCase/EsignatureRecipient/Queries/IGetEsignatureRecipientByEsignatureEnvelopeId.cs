using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Application.UserCase.EsignatureRecipient.Queries
{
    public interface IGetEsignatureRecipientByEsignatureEnvelopeId
    {
        Task<IList<GetEsignatureRecipientModel>> ExecuteAsync(int esignatureEnvelopeId);
    }
}
