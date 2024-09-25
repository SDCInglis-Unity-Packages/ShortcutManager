# Shortcut Manager

### Update Test Workflow
- Go to .github/workflows/test.yml
- Update the unityVersion matrix as needed
- If this package or project depends on other com.sdcinglis packages:
  - Uncomment the "Authenticate UPM" step
  - Go to https://github.com/{YOUR_GITHUB_REPO}/settings/secrets/actions
  - Add a new secret called PACKAGE_TOKEN
  - Copy the value from "GitHub PAT - read:packages" in BitWarden
- If this package generates a CodeCoverage report
  - Uncomment the "Upload Coverage Report" step

## Publishing to Rapidash/GitHub Registry (Subject to Change)
- Make sure the default NPM registry is set to Minior
  - npm config set registry=http://minior.local:4873/
- Update Package/changelog.md
- Navigate to the Package directory in command line
  - Make sure that there is a folder named Package/.git
- npm version patch/minor/major
- npm publish
- cd ..
- git push origin --tags
