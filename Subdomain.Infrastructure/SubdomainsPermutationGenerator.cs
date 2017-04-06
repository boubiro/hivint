using Subdomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subdomain.Infrastructure
{
    public class SubdomainsPermutationGenerator : ISubdomainsResolver
    {
        public IEnumerable<string> GetSubdomains(string domain)
        {
            List<string> subdomainList = new List<string>();
            for(char sub = 'a'; sub <='z';sub++)
            {
                subdomainList.Add(String.Concat(sub,".", domain));
            }
            for (char sub1 = 'a'; sub1 <= 'z'; sub1++)
            {
                for (char sub2 = 'a'; sub2 <= 'z'; sub2++)
                {
                    subdomainList.Add(string.Concat(sub1, sub2, ".", domain));
                }
            }
            return subdomainList;
        }
    }
}
