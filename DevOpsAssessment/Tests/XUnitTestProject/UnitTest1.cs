using System;
using WebApplication.Repository;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestSuperHeroCount()
        {
            int expected = 5;

            // TODO: we should use the interface and MOQ.
            var repo = new SuperheroRepository();

            // check to see if we getting 4 heros back
            var results = repo.Get();
            int actual = results.Count;

            Assert.Equal(expected, actual);
        }
    }
}
