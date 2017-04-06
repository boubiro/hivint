using Subdomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Subdomain.Web.Controllers
{
    [RoutePrefix("subdomain")]
    public class SubdomainController : ApiController
    {
        private ISubdomainsEnumerator _subdomainResolver;

        public SubdomainController(ISubdomainsEnumerator subdomainResolver)
        {
            this._subdomainResolver = subdomainResolver;
        }

        [Route("enumerate/{domain}")]
        [HttpGet]
        public IHttpActionResult Enumerate(string domain)
        {
            var subdomains = _subdomainResolver.GetSubdomains(domain);
            return Ok(subdomains);
        }
    }
}
