using Subdomain.Core.Entities;
using Subdomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subdomain.Infrastructure
{
    /// <summary>
    /// An implementation of ISubdomainsEnumerator that gets every possible combination of 1 and 2
    /// letters 3rd level subdomains of a domain
    /// </summary>
    public class SubdomainsPermutationEnumerator : ISubdomainsEnumerator
    {
        /// <summary>
        /// Enumerates every possible combination of 1 and 2 letters 3rd level subdomains of a domain
        /// </summary>
        /// <param name="domain">The domain name</param>
        /// <returns>List of SubdomainEntity containing the enumerated subdomains</returns>
        public IEnumerable<SubdomainEntity> GetSubdomains(string domain)
        {
            List<SubdomainEntity> subdomainList = new List<SubdomainEntity>();
            //add all letters from a to z
            for(char sub = 'a'; sub <='z';sub++)
            {
                subdomainList.Add(new SubdomainEntity(string.Concat(sub,".", domain)));
            }
            //add every possible 2-letter combination 
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
