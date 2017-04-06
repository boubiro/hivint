using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subdomain.Core.Interfaces
{
    public interface ISubdomainsEnumerator
    {
        IEnumerable<string> GetSubdomains(string domain);
    }
}
