using Subdomain.Core.Entities;
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
        private ISubdomainsEnumerator _subdomainEnumerator;
        private ISubdomainsIPResolver _subdomainIpResolver;

        public SubdomainController(ISubdomainsEnumerator subdomainResolver,ISubdomainsIPResolver subdomainIpResolver)
        {
            this._subdomainEnumerator = subdomainResolver;
            this._subdomainIpResolver = subdomainIpResolver;
        }

        [Route("enumerate/{domain}")]
        [HttpGet]
        public IHttpActionResult Enumerate(string domain)
        {
            var subdomains = _subdomainEnumerator.GetSubdomains(domain);
            return Ok(subdomains);
        }

        [Route("findIPAddresses")]
        [HttpPost]
        public IHttpActionResult Resolve([FromBody]SubdomainEntity[] subdomains)
        {
            _subdomainIpResolver.Resolve(subdomains);
            return Ok(subdomains);
        }
    }
}
