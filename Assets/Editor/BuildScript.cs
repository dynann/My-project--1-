using UnityEditor;
using UnityEngine;

public class BuildScript
{
    static void PerformBuild()
    {
        BuildPlayerOptions options = new BuildPlayerOptions();
        options.scenes = new[] { "Assets/Scenes/SampleScene.unity" }; // ← your scenes
        options.locationPathName = "ios";
        options.target = BuildTarget.iOS;
        options.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(options);
    }
}