using QCService.Helpers;
using System;
using Xunit;

namespace QCService.Tests
{
    public class TestGenSP
    {
        [Fact]
        public void TestSeedStoreProcedure()
        {
            var sql = SeedStoreProcedure.CreateSPQCRequest();

            Assert.NotNull(sql);
        }
    }
}
