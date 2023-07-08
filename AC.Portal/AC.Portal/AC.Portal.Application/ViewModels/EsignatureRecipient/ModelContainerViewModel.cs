namespace AC.Portal.Application.ViewModels.EsignatureRecipient
{
    public class ModelContainerViewModel
    {
        public ReadTableEsignatureRecipientViewModel ReadTableEsignatureRecipient { get; set; }
        public IList<EsignatureRecipientViewModel> EsignatureRecipients { get; set; }
        public SoftDeleteEsignatureRecipientViewModel SoftDeleteEsignatureRecipient { get; set; }
    }
}
