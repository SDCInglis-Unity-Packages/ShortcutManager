# Unity Package Template

## Replace "Template" Everywhere
- README.md
- Package/package.json
- Package/Editor/SDCInglis.Template.Editor.asmdef
- Package/Runtime/SDCInglis.Template.asmdef
- Package/Tests/Editor/SDCInglis.Template.Editor.Tests.asmdef
- Package/Tests/Runtime/SDCInglis.Template.Tests.asmdef
- Sample/Packages/manifest.json

For Assembly Definition files make sure to update the names as well as the contents of the files

## Rename Sample Project
- Update productName in Sample/ProjectSettings/ProjectSettings.asset
- Rename Sample folder

## Add Unity License to Github Action Secrets
- Go to https://github.com/sdcinglis/{YOUR_GITHUB_REPO}/settings/secrets/actions
- Add a new secret called UNITY_LICENSE
- Copy the value from Unity_v2019.x.ulf