using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subdomain.Core.Entities;

namespace Subdomain.Core.Interfaces
{
    public interface ISubdomainsEnumerator
    {
        IEnumerable<SubdomainEntity> GetSubdomains(string domain);
    }
}
