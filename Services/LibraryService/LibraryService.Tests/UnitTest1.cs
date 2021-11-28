using LibraryService.Models.DTOs;
using System;
using System.Text.Json;
using Xunit;

namespace LibraryService.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var str = @"{""FormType"":0,""FilterForm"":{""QCReqNo"":true,""OCNo"":true,""Buyer"":true,""GRNNo"":true,""PONo"":false},""Fields"":null}";
            JsonSerializer.Deserialize<FormLibDTO>(str);
        }
    }
}
