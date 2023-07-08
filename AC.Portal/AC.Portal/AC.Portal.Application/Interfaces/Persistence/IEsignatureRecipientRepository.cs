using AC.Portal.Domain.Entities;

namespace AC.Portal.Application.Interfaces.Persistence
{
    public interface IEsignatureRecipientRepository : IRepository<EsignatureRecipient>
    {
        Task<IList<EsignatureRecipient>> GetEsignatureRecipientByEsignatureEnvelopeId(int esignatureEnvelopeId);
        Task<int> SoftDeteleAsync(int modifiedby, int esignatureEnvelopeId, int recipientId);
    }
}
