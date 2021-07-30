using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLinqStuff
{
    public class NumberFilter
    {
        public List<int> RemoveEvensFrom(List<int> numbers)
        {
            var response = new List<int>();
            foreach(var number in numbers)
            {
                if(IsOdd(number))
                {
                    response.Add(number);
                }
            }

            return response;
        }

        public List<int> RemoveOddsFrom(List<int> numbers)
        {
            var response = new List<int>();
            foreach(var number in numbers)
            {
                if(!IsOdd(number))
                {
                    response.Add(number);
                }
            }

            return response;
        }

        private List<int> Filter(List<int> numbers, FilterMethod op)
        {

        }

        private bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
