/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using System.Collections.Generic;

using UnityEngine;

namespace Happy
{
	public static class ListExtension
	{
		public static T RandomElement<T> (this List<T> list)
		{
			return list [Random.Range (0, list.Count)];
		}

		public static void Swap<T> (this List<T> list, int indexA, int indexB)
		{
			T tmp = list [indexA];
			list [indexA] = list [indexB];
			list [indexB] = tmp;
		}
	}
}
