using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor (typeof(DayNightController))]
public class DayNightEditor : Editor
{

	private static DayNightController _controller;
	
	private static bool _showCurrentWorldTime;

	void Start ()
	{
		
	}
	
	public override void OnInspectorGUI ()
	{
		DrawDefaultInspector ();
		
		if (_controller == null) {
			_controller = (DayNightController)target;
		}
		
		var worldTime = serializedObject.FindProperty ("LocalTime");

		EditorGUILayout.BeginHorizontal ();
		GUILayout.Label (worldTime.FindPropertyRelative ("Hours").intValue.ToString (), GUILayout.MaxWidth (20));
		GUILayout.Label (":", GUILayout.MaxWidth (10));
		GUILayout.Label (worldTime.FindPropertyRelative ("Minutes").intValue.ToString (), GUILayout.MaxWidth (20));
		EditorGUILayout.EndHorizontal ();
		
		_controller.SecondsInFullDay = EditorGUILayout.IntField ("Seconds in full day: ", _controller.SecondsInFullDay);
		


	}
}
