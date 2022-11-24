using UnrealBuildTool;

public class CreatorChallenge1Target : TargetRules
{
	public CreatorChallenge1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CreatorChallenge1");
	}
}
