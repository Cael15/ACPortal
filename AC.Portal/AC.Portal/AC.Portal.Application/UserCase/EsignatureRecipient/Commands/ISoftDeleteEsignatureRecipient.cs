using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Application.UserCase.EsignatureRecipient.Commands
{
    public interface ISoftDeleteEsignatureRecipient
    {
        Task<int> ExecuteAsync(SoftDeleteEsignatureRecipientModel model);
    }
}
