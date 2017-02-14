/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using UnityEngine;

public static class GUIStyleExtension
{
	public static GUIStyle CommentLabel
	{
		get
		{
			GUIStyle commentLabel = new GUIStyle ();

			commentLabel.alignment = TextAnchor.LowerLeft;
			commentLabel.fontSize = 9;
			commentLabel.wordWrap = true;
			commentLabel.normal.textColor = new Color(0.4f, 0.4f, 0.4f);

			return commentLabel;
		}
	}
}
