/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using UnityEngine;

namespace Happy
{
	public static class TransformExtension
	{
		#region Position Extensions

		public static void SetPositionX (this Transform transform, float x)
		{
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}

		public static void SetPositionY (this Transform transform, float y)
		{
			transform.position = new Vector3 (transform.position.x, y, transform.position.z);
		}

		public static void SetPositionZ (this Transform transform, float z)
		{
			transform.position = new Vector3 (transform.position.x, transform.position.y, z);
		}

		#endregion

		#region Rotation Extensions

		public static void SetRotationX (this Transform transform, float x)
		{
			transform.eulerAngles = new Vector3 (x, transform.eulerAngles.y, transform.eulerAngles.z);
		}

		public static void SetRotationY (this Transform transform, float y)
		{
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, y, transform.eulerAngles.z);
		}

		public static void SetRotationZ (this Transform transform, float z)
		{
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, z);
		}

		#endregion

		#region Local Scale Extensions

		public static void SetLocalScaleX (this Transform transform, float x)
		{
			transform.localScale = new Vector3 (x, transform.localScale.y, transform.localScale.z);
		}

		public static void SetLocalScaleY (this Transform transform, float y)
		{
			transform.localScale = new Vector3 (transform.localScale.x, y, transform.localScale.z);
		}

		public static void SetLocalScaleZ (this Transform transform, float z)
		{
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y, z);
		}

		#endregion

		#region General Extensions

		public static void Reset (this Transform transform)
		{
			transform.position = Vector3.zero;
			transform.rotation = Quaternion.identity;
			transform.localScale = Vector3.one;
		}

		#endregion
	}
}
