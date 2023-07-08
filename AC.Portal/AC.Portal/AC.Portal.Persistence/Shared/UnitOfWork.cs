using AC.Portal.Application.Interfaces.Persistence;
using AC.Portal.Persistence.Repositories.DocuSignEnvelopeRepository;
using AC.Portal.Persistence.Repositories.EsignatureRecipientRepository;

namespace AC.Portal.Persistence.Shared
{
    public class UnitOfWork : IUnitOfWork
    {
        private IEsignatureRecipientRepository _esignatureRecipients;
        private IDocuSignEnvelopeRepository _docuSignEnvelopes;

        private readonly ACPortalDbContext _dbContext;

        public UnitOfWork(ACPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEsignatureRecipientRepository EsignatureRecipients => _esignatureRecipients = _esignatureRecipients ?? new EsignatureRecipientRepository(this._dbContext);
        public IDocuSignEnvelopeRepository DocuSignEnvelopes => _docuSignEnvelopes = _docuSignEnvelopes ??  new DocuSignEnvelopeRepository(this._dbContext);
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
