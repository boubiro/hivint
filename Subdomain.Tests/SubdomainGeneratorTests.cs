using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Subdomain.Core.Interfaces;
using Subdomain.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Subdomain.Tests
{
    [TestClass]
    public class SubdomainGeneratorTests
    {
        [TestMethod]
        public void SubdomainGenerator_ReturnsExpectedSubdomains()
        {
            ISubdomainsEnumerator subdomainGenerator = new SubdomainsPermutationEnumerator();
            IEnumerable<string> test=subdomainGenerator.GetSubdomains("yahoo.com");
            //26+26^2
            Assert.AreEqual(702, test.Count());
        }
    }
}
