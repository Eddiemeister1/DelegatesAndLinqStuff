using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DelegatesAndLinqStuff
{
    public delegate bool FilterMethod(int x);

    public class NumberFilterTests
    {
        [Fact]
        public void WeCanRemoveAllEvenNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var filter = new NumberFilter();

            List<int> results = filter.RemoveEvensFrom(numbers);

            Assert.Equal(1, results[0]);
            Assert.Equal(3, results[1]);
            Assert.Equal(5, results[2]);
        }

        [Fact]
        public void WeCanRemoveAllOddNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var filter = new NumberFilter();

            List<int> results = filter.RemoveOddsFrom(numbers);

            Assert.Equal(2, results[0]);
            Assert.Equal(4, results[1]);
            Assert.Equal(6, results[2]);
        }
    }
}
