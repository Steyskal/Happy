/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using UnityEditor;
using UnityEngine;

namespace Happy
{
	/// <summary>
	/// A property drawer for fields marked with the Positive attribute.
	/// </summary>
	[CustomPropertyDrawer (typeof(PositiveAttribute))]
	public class PositiveDrawer : PropertyDrawer
	{
		public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
		{
			return GUIStyleExtension.CommentLabel.fontSize + EditorGUIUtility.singleLineHeight;
		}

		public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
		{
			position.height -= EditorGUIUtility.singleLineHeight;
			EditorGUI.LabelField (position, new GUIContent ("Positive Field"), GUIStyleExtension.CommentLabel);
			position.height += EditorGUIUtility.singleLineHeight;

			position.y += position.height - EditorGUIUtility.singleLineHeight;
			position.height = EditorGUIUtility.singleLineHeight;

			switch (property.propertyType)
			{
				case SerializedPropertyType.Integer:
					{
						EditorGUI.BeginChangeCheck ();

						int n = EditorGUI.IntField (position, label, property.intValue);

						if (EditorGUI.EndChangeCheck () && n > 0)
							property.intValue = n;
					}
					break;

				case SerializedPropertyType.Float:
					{
						EditorGUI.BeginChangeCheck ();

						float x = EditorGUI.FloatField (position, label, property.floatValue);

						if (EditorGUI.EndChangeCheck () && x > 0)
							property.floatValue = x;

					}
					break;

				default:
					EditorGUI.LabelField (position, label.text, "Use Positive attribute with int or float field!");
					break;
			}
		}
	}
}
