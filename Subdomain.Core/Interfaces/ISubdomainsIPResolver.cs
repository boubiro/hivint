using Subdomain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subdomain.Core.Interfaces
{
    public interface ISubdomainsIPResolver
    {
        void Resolve(IEnumerable<SubdomainEntity> subdomains);
    }
}
