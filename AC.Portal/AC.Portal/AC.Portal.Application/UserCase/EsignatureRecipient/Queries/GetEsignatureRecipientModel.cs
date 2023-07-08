using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Application.UserCase.EsignatureRecipient.Queries
{

    public class GetEsignatureRecipientModel
    {
        public int Id { get; set; }
        public int EsignatureEnvelopeId { get; set; }
        public string Name { get; set; }
        public int? ClientNumber { get; set; }
        public Guid? DocuSignRecipientId { get; set; }
        public DateTime? SentDateTime { get; set; }
        public DateTime? DeliveredDateTime { get; set; }
        public DateTime? SignedDateTime { get; set; }
        public int? Status { get; set; }
        public bool IsDeleted { get; set; }
        public int ModifiedBy { get; set; }
    }
}
