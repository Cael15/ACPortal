using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Application.UserCase.EsignatureRecipient.Commands
{
    public class SoftDeleteEsignatureRecipientModel
    {
        public int ModifiedBy { get; set; }
        public int EnvelopeId { get; set; }
        public int RecipientId { get; set; }
    }
}
