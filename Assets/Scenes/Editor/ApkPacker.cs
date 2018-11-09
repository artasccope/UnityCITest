using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class ApkPacker {

	[MenuItem("Tools/Build/打常规安卓包")]
	public static void PackAndriodApk_Routine()
	{
		var apkName = "testBuild" + "_" +
		              DateTime.Now.Hour + "-" + DateTime.Now.Minute;

		var savePath = Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).FullName 
		               + "/BuildApks/"
		               +apkName + ".apk";
		if(File.Exists(savePath))
			File.Delete(savePath);

		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
		var buildPlayerOptions = new BuildPlayerOptions();
		buildPlayerOptions.scenes = new[]
		{
			"Assets/Scenes/SampleScene.unity"
		};
		buildPlayerOptions.locationPathName = savePath;
		buildPlayerOptions.target = BuildTarget.Android;
		buildPlayerOptions.options = BuildOptions.None;
		BuildPipeline.BuildPlayer(buildPlayerOptions);
	}
}
