using Subdomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subdomain.Core.Entities;

namespace Subdomain.Infrastructure
{
    public class SubdomainsIPResolver : ISubdomainsIPResolver
    {
        public void Resolve(IEnumerable<SubdomainEntity> subdomains)
        {
            Parallel.ForEach<SubdomainEntity>(subdomains, subdomain => {
                if (subdomain.IP == null)
                {
                    subdomain.IP = new List<string>();
                }
                try
                {
                    var ips = System.Net.Dns.GetHostAddresses(subdomain.Url);
                    foreach (var ip in ips)
                    {
                        subdomain.IP.Add(ip.ToString());
                    }
                }
                catch (Exception)
                {

                }
            
            });
            //foreach (var subdomain in subdomains)
            //{
            //    if (subdomain.IP==null)
            //    {
            //        subdomain.IP = new List<string>();
            //    }
            //    try
            //    {
            //        var ips = System.Net.Dns.GetHostAddresses(subdomain.Url);
            //        foreach (var ip in ips)
            //        {
            //            subdomain.IP.Add(ip.ToString());
            //        }
            //    }
            //    catch (Exception)
            //    {
                    
            //    }
            //}
        }
    }
}
