using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TaxCertPortal.Shared
{
    public class TaxCertificatesService : TaxCertificates.TaxCertificatesBase
    {
        private readonly IDbContextFactory<TaxCertPortalContext> _contextFactory;
        private protected IMapper _mapper;

        public TaxCertificatesService(IDbContextFactory<TaxCertPortalContext> contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;

        }

        /// <summary>
        /// This method add a new user to the DbContext and saves it
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public override Task<CertificateReply> AddCertificate(TaxCertificateViewModel certVM, ServerCallContext context)
        {
            try
            {

                var taxCertRecord = new TaxCertificate
                {
                    ParcelNumber = certVM.ParcelNumber,
                    CertID = certVM.CertID,
                    UnpaidYear = certVM.UnpaidYear,
                    CertCost = certVM.CertCost,
                    CertInterestCost = certVM.CertInterestCost,
                    PurchaseFee = certVM.PurchaseFee,
                    BillNumber = certVM.BillNumber,
                    DateBought = certVM.DateBought,
                    Comments = certVM.Comments,
                    Acreage = certVM.Acreage,
                    DateCreated = DateTime.Now.ToString()
                };

                //var taxCertRecord = _mapper.Map<TaxCertificateViewModel, TaxCertificate>(certVM);
                using var dbContext = _contextFactory.CreateDbContext();
                dbContext.Add(taxCertRecord);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                return Task.FromResult(new CertificateReply { Reply = $"{e.Message} {e.InnerException.Message}" });
            }
            return Task.FromResult(new CertificateReply { Reply = "Success!" });
        }
    }
}
