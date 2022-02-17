using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCertPortal.Shared;

namespace TaxCertPortal.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxCertsController : ControllerBase
    {

        private readonly IDbContextFactory<TaxCertPortalContext> _contextFactory;

        public TaxCertsController(IDbContextFactory<TaxCertPortalContext> contextFactory)
        {
            _contextFactory = contextFactory;

        }

        /// <summary>
        /// This method add a new user to the DbContext and saves it
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<TaxCertificate> AddUserAsync(TaxCertificate certVM)
        {
            try
            {
                using var context = _contextFactory.CreateDbContext();
                await context.AddAsync(certVM);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return certVM;
        }
    }
}
