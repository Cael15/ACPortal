using AC.Portal.Application.Interfaces.Persistence;
using AC.Portal.Domain.Entities;
using AC.Portal.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Persistence.Repositories.DocuSignEnvelopeRepository
{
    public class DocuSignEnvelopeRepository : IDocuSignEnvelopeRepository
    {
        private ACPortalDbContext _dbContext;

        public DocuSignEnvelopeRepository(ACPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(DocuSignEnvelope entity)
        {
            await _dbContext.DocuSignEnvelopes.AddAsync(entity);
        }

        public DocuSignEnvelope GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
