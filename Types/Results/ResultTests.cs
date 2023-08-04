using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpStorybook.Types.Results
{
    public class ResultTests
    {
        [Fact]
        public void TestResultFailure()
        {
            var result = Result.Failure("Shouldn't be an empty string");

            Assert.True(result.IsFailure);
        }

        [Fact]
        public void TestResultNull()
        {
            Result<string> result = null;

            Assert.True(result.IsSuccess);
        }
    }
}
