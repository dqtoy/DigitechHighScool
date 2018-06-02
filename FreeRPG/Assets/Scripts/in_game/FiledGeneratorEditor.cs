using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor (typeof(FieldGenerator))]
public class FiledGeneratorEditor : Editor {

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		FieldGenerator	generator = (FieldGenerator)target;
		if(GUILayout.Button("Make Level"))
		{
			generator.MakeLevel();
		}
	}

}
