using Subdomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subdomain.Core.Entities;

namespace Subdomain.Infrastructure
{
    /// <summary>
    /// An implrmrntation of ISubdomainsIPResolver that depends on System.Net.Dns.GetHostAddreses to
    /// resolve ips
    /// </summary>
    public class SubdomainsIPResolver : ISubdomainsIPResolver
    {
        public void Resolve(IEnumerable<SubdomainEntity> subdomains)
        {
            //A parallel foreach to improve performance
            Parallel.ForEach<SubdomainEntity>(subdomains, subdomain => {
                //initialize the subdomain ip list if null
                if (subdomain.IP == null)
                {
                    subdomain.IP = new List<string>();
                }
                try
                {
                    //resolve the ip addresses
                    var ips = System.Net.Dns.GetHostAddresses(subdomain.Url);
                    foreach (var ip in ips)
                    {
                        //add the addresses to list
                        subdomain.IP.Add(ip.ToString());
                    }
                }
                catch (Exception)
                {
                    //if the subdomain resolves to nothing, do nothing
                }
            
            });
            //Old code that used normal foreach, performance was bad
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
