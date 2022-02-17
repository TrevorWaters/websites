using AutoMapper;
using System.Collections.Generic;
using TaxCertPortal.Shared;

namespace TaxCertPortal.Server.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaxCertificateViewModel, TaxCertificate>();
        }
    }
}