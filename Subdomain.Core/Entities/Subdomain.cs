using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subdomain.Core.Entities
{
    public class SubdomainEntity
    {
        public string Url { get; set; }
        public List<string> IP { get; set; }
        public SubdomainEntity(string url)
        {
            this.Url = url;
            this.IP = new List<string>();
        }
    }
}
