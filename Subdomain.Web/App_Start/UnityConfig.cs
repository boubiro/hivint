using Microsoft.Practices.Unity;
using Subdomain.Core.Interfaces;
using Subdomain.Infrastructure;
using System.Web.Http;
using Unity.WebApi;

namespace Subdomain.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ISubdomainsEnumerator, SubdomainsPermutationEnumerator>();
            container.RegisterType<ISubdomainsIPResolver, SubdomainsIPResolver>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            
        }
    }
}