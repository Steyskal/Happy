/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using UnityEngine;

public static class Vector2Extension
{
	public static float RandomValue (this Vector2 v2)
	{
		return Random.Range (v2.x, v2.y);
	}
}
