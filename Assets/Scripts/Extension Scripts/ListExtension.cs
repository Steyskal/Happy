/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using System.Collections.Generic;

namespace Happy
{
	public static class ListExtension
	{
		public static void Swap<T> (this List<T> list, int indexA, int indexB)
		{
			T tmp = list [indexA];
			list [indexA] = list [indexB];
			list [indexB] = tmp;
		}
	}
}
