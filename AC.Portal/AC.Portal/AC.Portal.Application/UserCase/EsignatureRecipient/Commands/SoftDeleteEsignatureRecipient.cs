using AC.Portal.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Application.UserCase.EsignatureRecipient.Commands
{
    public class SoftDeleteEsignatureRecipient : ISoftDeleteEsignatureRecipient
    {
        private readonly IUnitOfWork _unitOfWork;

        public SoftDeleteEsignatureRecipient(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> ExecuteAsync(SoftDeleteEsignatureRecipientModel model)
        {
            return await _unitOfWork
                .EsignatureRecipients
                .SoftDeteleAsync(model.ModifiedBy, model.EnvelopeId, model.EnvelopeId);
        }
    }
}
