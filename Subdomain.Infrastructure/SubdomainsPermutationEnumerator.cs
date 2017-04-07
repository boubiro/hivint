using Subdomain.Core.Entities;
using Subdomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subdomain.Infrastructure
{
    public class SubdomainsPermutationEnumerator : ISubdomainsEnumerator
    {
        public IEnumerable<SubdomainEntity> GetSubdomains(string domain)
        {
            List<SubdomainEntity> subdomainList = new List<SubdomainEntity>();
            for(char sub = 'a'; sub <='z';sub++)
            {
                subdomainList.Add(new SubdomainEntity(string.Concat(sub,".", domain)));
            }
            for (char sub1 = 'a'; sub1 <= 'z'; sub1++)
            {
                for (char sub2 = 'a'; sub2 <= 'z'; sub2++)
                {
                    subdomainList.Add(new SubdomainEntity(string.Concat(sub1, sub2, ".", domain)));
                }
            }
            return subdomainList;
        }
    }
}
