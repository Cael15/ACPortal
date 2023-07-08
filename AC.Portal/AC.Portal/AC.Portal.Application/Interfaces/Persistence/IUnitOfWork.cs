using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Application.Interfaces.Persistence
{
    public interface IUnitOfWork
    {
        IEsignatureRecipientRepository EsignatureRecipients { get; }
        IDocuSignEnvelopeRepository DocuSignEnvelopes { get; }
        Task<int> SaveChangesAsync();
    }
}
