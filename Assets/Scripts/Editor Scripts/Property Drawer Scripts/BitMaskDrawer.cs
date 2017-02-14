/*
 *
 *	Happy
 *	by Toni Steyskal, 2016-2017
 * 
 */

using UnityEngine;
using UnityEditor;

namespace Happy
{
	/// <summary>
	/// A property drawer for fields marked with the BitMask attribute.
	/// </summary>
	[CustomPropertyDrawer (typeof(BitMaskAttribute))]
	public class BitMaskDrawer : PropertyDrawer
	{
		public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
		{
			return GUIStyleExtension.CommentLabel.fontSize + EditorGUIUtility.singleLineHeight;
		}

		public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
		{
			position.height -= EditorGUIUtility.singleLineHeight;
			EditorGUI.LabelField (position, new GUIContent ("Bit Mask Field"), GUIStyleExtension.CommentLabel);
			position.height += EditorGUIUtility.singleLineHeight;

			position.y += position.height - EditorGUIUtility.singleLineHeight;
			position.height = EditorGUIUtility.singleLineHeight;

			if (property.propertyType == SerializedPropertyType.Enum)
				property.intValue = EditorGUI.MaskField (position, label, property.intValue, property.enumNames);
			else
				EditorGUI.LabelField (position, label.text, "Use BitMask attribute with enum field!");
		}
	}
}
