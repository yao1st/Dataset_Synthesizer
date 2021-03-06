/*
* Copyright (c) 2018 NVIDIA Corporation. All rights reserved.
* This work is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 4.0
* International License.  (https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode)
*/

using UnrealBuildTool;
using System.IO;
 
public class NVSceneCapturerEditor : ModuleRules
{
	public NVSceneCapturerEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicIncludePaths.AddRange(new string[] { "NVSceneCapturerEditor/Public" });
 
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "Json", "JsonUtilities", "InputCore", "RHI", "UnrealEd", "ImageWrapper" });
        PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore", "UMG", "EditorStyle", "AssetTools", "AssetRegistry", "PlacementMode", "LevelEditor", "PropertyEditor" });
        PrivateDependencyModuleNames.AddRange(new string[] { "NVSceneCapturer" });

        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        bFasterWithoutUnity = true;
    }
}