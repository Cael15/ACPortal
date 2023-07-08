using AC.Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Application.Interfaces.Persistence
{
    public interface IDocuSignEnvelopeRepository : IRepository<DocuSignEnvelope>
    {
        DocuSignEnvelope GetById(int id);

    }
}
