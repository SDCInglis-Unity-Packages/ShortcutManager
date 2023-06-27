# Unity Package Template

## Setting Up a New Package

### Replace "Template" Everywhere
- README.md
- Package/package.json
- Package/Editor/SDCInglis.Template.Editor.asmdef
- Package/Runtime/SDCInglis.Template.asmdef
- Package/Tests/Editor/SDCInglis.Template.Editor.Tests.asmdef
- Package/Tests/Runtime/SDCInglis.Template.Tests.asmdef
- Sample/Packages/manifest.json

For Assembly Definition files make sure to update the names as well as the contents of the files

Also update the repository URL in package.json

### Rename Sample Project
- Update productName in Sample/ProjectSettings/ProjectSettings.asset
- Rename Sample folder

### Add Unity License to Github Action Secrets
- Go to https://github.com/{YOUR_GITHUB_REPO}/settings/actions
- Set "Workflow permissions" to "Read and write permissions"
- Go to https://github.com/{YOUR_GITHUB_REPO}/settings/secrets/actions
- Add a new secret called UNITY_LICENSE
- Copy the value from Unity_v2019.x.ulf

### Update Test Workflow
- Go to .github/workflows/test.yml
- Update the unityVersion matrix as needed
- If this package or project depends on other com.sdcinglis packages:
  - Uncomment the "Authenticate UPM" step
  - Go to each dependent package in GitHub, open the Package Settings and add your new repository to the "Manage Actions access" section

## Releasing an Update
- Update Package/changelog.md
- Navigate to the Package directory in command line
  - Make sure that there is a folder named Package/.git
- npm version patch/minor/major
- npm publish
- cd ..
- git push origin --tags