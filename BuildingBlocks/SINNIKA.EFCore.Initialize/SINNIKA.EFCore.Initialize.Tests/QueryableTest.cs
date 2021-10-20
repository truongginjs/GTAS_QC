using System;
using System.Collections.Generic;
using System.Linq;
using SINNIKA.EFCore.Initialize.Extensions;
using SINNIKA.EFCore.Initialize.Types;
using Xunit;

namespace SINNIKA.EFCore.Initialize.Tests
{
    public class QueryableTest
    {
        private readonly IQueryable<Test> tests;

        public QueryableTest()
        {
            tests = new List<Test>{
                new Test{Str = "sv1",Num=1.1,Redund=1},
                new Test{Str = "sv4",Num=0.2,Redund=2},
                new Test{Str = "ss1",Num=2.2,Redund=4},
                new Test{Str = "sa2",Num=2.2,Redund=2},
                new Test{Str = "ssb3",Num=3.3,Redund=3}
            }.AsQueryable();
        }

        [Fact]
        public void TestOrderBy()
        {
            var expected = "12234";
            var dict = new Dictionary<string,OrderByType>{
                {nameof(Test.Redund), OrderByType.ASC}
            };
            var rs = tests.OrderByWithArguments(dict).ToList();
            var actual = string.Join("", rs.Select(_=>_.Redund));
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void TestWhere()
        {
            var expected = "ss1ssb3";
            var dict = new Dictionary<string, object>{
                {nameof(Test.Str), new Dictionary<string, string>{
                    {ConditionDict.Operators[ConditionType.StartsWith], "ss"},
                    {ConditionDict.Operators[ConditionType.And], "s"}
                    }
                    }
            };
            var rs = tests.WhereWithArguments(dict).ToList();
            var actual = string.Join("", rs.Select(_ => _.Str));
            Assert.Equal(expected, actual);
        }
    }

    public class Test
    {
        public string Str { get; set; }
        public double Num { get; set; }
        public int Redund { get; set; }
    }
}
