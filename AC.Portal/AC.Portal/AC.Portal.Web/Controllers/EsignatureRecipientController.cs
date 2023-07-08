using AC.Portal.Application.UserCase.EsignatureRecipient.Commands;
using AC.Portal.Application.UserCase.EsignatureRecipient.Queries;
using AC.Portal.Application.ViewModels.EsignatureRecipient;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AC.Portal.Web.Controllers
{
    public class EsignatureRecipientController : Controller
    {
        private readonly ISoftDeleteEsignatureRecipient _softDeleteQueryExecuter;
        private readonly IGetEsignatureRecipientByEsignatureEnvelopeId _getEsignatureRecipientQueryExecuter;
        private readonly IMapper _mapper;

        public EsignatureRecipientController(ISoftDeleteEsignatureRecipient softDeleteQueryExecuter, 
            IGetEsignatureRecipientByEsignatureEnvelopeId getEsignatureRecipientQueryExecuter,
            IMapper mapper)
        {
            _softDeleteQueryExecuter = softDeleteQueryExecuter;
            _getEsignatureRecipientQueryExecuter = getEsignatureRecipientQueryExecuter;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(new ModelContainerViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> ReadEsignatureRecipient(ModelContainerViewModel model)
        {
            var esignatureRecipient = await _getEsignatureRecipientQueryExecuter
                .ExecuteAsync(model.ReadTableEsignatureRecipient.EsignatureEnvelopeId);

            var viewModels = esignatureRecipient.Select(x => _mapper.Map<EsignatureRecipientViewModel>(x)).ToList();

            var modelContainer = new ModelContainerViewModel { EsignatureRecipients = viewModels };

            return View("Index", modelContainer);

        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete(ModelContainerViewModel model)
        {
            var recipient = new SoftDeleteEsignatureRecipientModel
            {
                ModifiedBy = model.SoftDeleteEsignatureRecipient.ModifiedBy,
                EnvelopeId = model.SoftDeleteEsignatureRecipient.EnvelopeId,
                RecipientId = model.SoftDeleteEsignatureRecipient.RecipientId
            };
            var result = await this._softDeleteQueryExecuter.ExecuteAsync(recipient);
            if (result == 0) ViewData["ErrorMessage"] = "0 rows were affected.";
            if (result > 0) ViewData["ErrorSuccess"] = "Stored Procedure run successfully.";

            return View("Index", model);
        }
    }
}
