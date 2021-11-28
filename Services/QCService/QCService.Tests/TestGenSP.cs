using QCService.DTOs.Responses;
using QCService.Helpers;
using QCService.Infrastructure;
using System;
using System.Text.Json;
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

        [Fact]
        public void TestSeed()
        {
            var data = SeedDefect.SeedFullLib();

            var hs = data.Item2;
            //Console.WriteLine(hs);
            Assert.True(hs.Length>0);
        }
    }
}
