using UnityEditor;
using UnityEditor.Build.Reporting;
using System.IO;

public class BuildScript
{
    public static void PerformBuild()
    {
        string buildPath = "Builds/iOS";

        if (!Directory.Exists(buildPath))
        {
            Directory.CreateDirectory(buildPath);
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = GetScenes(),
            locationPathName = buildPath,
            target = BuildTarget.iOS,
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result != BuildResult.Succeeded)
        {
            throw new System.Exception("Build failed");
        }
    }

    private static string[] GetScenes()
    {
        return new string[]
        {
            "Assets/Scenes/SampleScene.unity"
        };
    }
}