using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FunctionalTests
{
    [CollectionDefinition("AssemblyFixture")]
    public class AssemblyFixture : ICollectionFixture<TestFactory>
    {
    }

}
