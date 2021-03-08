using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace sampleclasslibrary.unittests
{
    public class RandomNameGeneratorTests
    {
        private readonly RandomNameGenerator randomNameGenerator;

        public RandomNameGeneratorTests()
        {
            randomNameGenerator = new RandomNameGenerator();
        }

        [Fact]
        public void TestReturnString()
        {
            string result = randomNameGenerator.GetRandomName();
            Assert.True(result.GetType() == typeof(string), String.Format("Expected a string; Actual: {0}",
                                     result));
        }
    }
}
