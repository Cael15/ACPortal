using AC.Portal.Application.Interfaces.Persistence;
using AC.Portal.Domain.Entities;
using AC.Portal.Persistence.Shared;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace AC.Portal.Persistence.Repositories.EsignatureRecipientRepository
{
    public class EsignatureRecipientRepository : IEsignatureRecipientRepository
    {
        private ACPortalDbContext _dbContext;

        public EsignatureRecipientRepository(ACPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(EsignatureRecipient entity) 
        {
            await _dbContext.EsignatureRecipients.AddAsync(entity);
        }

        public async Task<int> SoftDeteleAsync(int modifiedby, int esignatureEnvelopeId, int recipientId)
        {
            var parameters = new SqlParameter[] {
                         new SqlParameter("@ModifiedBy", modifiedby),
                         new SqlParameter("@EnvelopeID", esignatureEnvelopeId),
                         new SqlParameter("@RecipientID", recipientId),
            };

            int affectedRows = await _dbContext
                .Database
                .ExecuteSqlRawAsync("EXEC [dbo].[AC_Emergency_SoftDeleteEsignatureRecipient] @ModifiedBy, @EnvelopeID, @RecipientID", parameters);

            return affectedRows;
        }
        public async Task<IList<EsignatureRecipient>> GetEsignatureRecipientByEsignatureEnvelopeId(int esignatureEnvelopeId)
        {
            return await this._dbContext.EsignatureRecipients
                .Where(x => x.EsignatureEnvelopeId == esignatureEnvelopeId)
                .ToListAsync();
        }

    }
}
