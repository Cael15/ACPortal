using AC.Portal.Application.UserCase.EsignatureRecipient.Commands;
using AC.Portal.Application.UserCase.EsignatureRecipient.Queries;
using AC.Portal.Application.ViewModels.EsignatureRecipient;
using AC.Portal.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Infraestructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EsignatureRecipientViewModel, GetEsignatureRecipientModel>().ReverseMap();
            CreateMap<GetEsignatureRecipientModel, EsignatureRecipient>().ReverseMap();
            CreateMap<SoftDeleteEsignatureRecipientModel, SoftDeleteEsignatureRecipientViewModel>().ReverseMap();
        }
    }
}
