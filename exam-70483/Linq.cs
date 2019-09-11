using System.Collections.Generic;
using System.Linq;

namespace exam_70483
{
	public class Linq
	{
		public static IEnumerable<int> LinqQuerySyntax(int[] numbers)
		{
			IEnumerable<int> numbersQuery =
				from number in numbers
				where number % 2 == 0
				orderby number ascending
				select number;

			return numbersQuery;
		}
	}
}
