using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpStorybook.Operators
{
    public class NullCoalescingTests
    {
        [Fact]
        public void TestNull()
        {
            dynamic expando = new ExpandoObject();
            expando.variable = null;

            var result = expando.variable?.which?.isNull ?? 0;

            Assert.Equal(result, 0);
        }
    }
}
