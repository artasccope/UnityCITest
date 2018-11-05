using UnityEditor;
using UnityEngine;
 
public class MyEditorScript 
{
	public static void MyMethod ()
	{
			string executeMethod = "MyEditorScript.MyMethod";
			foreach(string arg in System.Environment.GetCommandLineArgs()) {
				Debug.Log(arg);
			}
	}
}