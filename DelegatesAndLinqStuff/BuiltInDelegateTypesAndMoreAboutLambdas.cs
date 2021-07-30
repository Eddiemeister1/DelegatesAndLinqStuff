using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DelegatesAndLinqStuff
{
    public delegatre
    public class BuiltInDelegateTypesAndMoreAboutLambdas
    {
        [Fact]
        public void Commands()
        {
            //commands are methods that return void. They can take arguments or not
            //so, when you need a delegate to refer to one of those, you can use one of these.

            Action<string, int> x;
            x = DoIt;
            x("Bob", 42);

            x = (a, b) => Console.Write(a + b);

            x("Joe", 99);
        }

        [Fact]
        public void GettingFuncy()
        {
            //queries are methods that return something (other than void)

            Func<int, int, int> mathOp;

            mathOp = (a, b) => a + b;
            Assert.Equal(3, mathOp(1, 2));

            mathOp = (x, y) => x * y;

            Assert.Equal(9, mathOp(3, 3));

            Func<string, string, string> formatter = (first, last) => $"{last}, {first}";
            Assert.Equal("Solo, Han", formatter("Han", "Solo"));

            var numbers = "1,2,3,4,5,6,7,8,9";

            var total = numbers.Split(",")
                .Select(x => int.Parse(x))
                .Sum();

            Assert.Equal(45, total);
        }

        [Fact]
        public void Predicate()
        {
            Predicate<int> ofAge;

            ofAge = age => age >= 18;

            Assert.True(ofAge(21));

            ofAge = age => age >= 21;

            Assert.False(ofAge(20));
        }

        public void DoIt(string name, int age)
        {
            ///

        }
    }
}
