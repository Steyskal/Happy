/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using UnityEngine;

namespace Happy
{
	[DisallowMultipleComponent]
	public class DontDestroyOnLoad : MonoBehaviour
	{
		void Awake ()
		{
			DontDestroyOnLoad (gameObject);
		}
	}
}
