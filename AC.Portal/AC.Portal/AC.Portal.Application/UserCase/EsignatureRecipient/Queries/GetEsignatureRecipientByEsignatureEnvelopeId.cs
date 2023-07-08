using AC.Portal.Application.Interfaces.Persistence;
using AutoMapper;

namespace AC.Portal.Application.UserCase.EsignatureRecipient.Queries
{
    public class GetEsignatureRecipientByEsignatureEnvelopeId : IGetEsignatureRecipientByEsignatureEnvelopeId
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetEsignatureRecipientByEsignatureEnvelopeId(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        public async Task<IList<GetEsignatureRecipientModel>> ExecuteAsync(int esignatureEnvelopeId)
        {
            var esignatureRecipients = await this._unitOfWork
                .EsignatureRecipients
                .GetEsignatureRecipientByEsignatureEnvelopeId(esignatureEnvelopeId);

            var models = esignatureRecipients.Select(x => _mapper.Map<GetEsignatureRecipientModel>(x)).ToList();

            return models;
        }
    }
}
