# Updating an existing application for MSBuild 15

In versions of MSBuild prior to 15.0, MSBuild was loaded from the Global Assembly Cache and MSBuild extensions were installed in the registry. This ensured that all applications used the same version of MSBuild and had access to the same toolsets, but prevented side-by-side installations of different versions of Visual Studio.

In order to support

## Using MSBuild from Visual Studio

To ensure that programmatic builds from your application match those Visual Studio or MSBuild.exe, load MSBuild assemblies from Visual Studio and use the SDKs available within Visual Studio. The Microsoft.Build.Locator NuGet package automates this.

## Using Microsoft.Build.Locator

### Change MSBuild refs

#### Using NuGet packages (preferred)

#### Using extension assemblies

#### Binding redirects?
#### Ensure output clean

### Add package reference

Add a NuGet package reference to [Microsoft.Build.Locator](https://www.nuget.org/packages/Microsoft.Build.Locator/).

If possible, do this from a project that uses [`PackageReference`](https://docs.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files) rather than `packages.config`. Doing so enables functionality within the package that check project state at build time.

### Ensure output clean
### Register instance before calling MSBuild

