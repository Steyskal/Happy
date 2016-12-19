/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using System.Collections;
using System.Collections.Generic;

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
