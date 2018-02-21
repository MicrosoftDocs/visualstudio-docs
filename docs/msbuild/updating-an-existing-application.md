# Updating an existing application for MSBuild 15

In versions of MSBuild prior to 15.0, MSBuild was loaded from the Global Assembly Cache and MSBuild extensions were installed in the registry. This ensured that all applications used the same version of MSBuild and had access to the same toolsets, but prevented side-by-side installations of different versions of Visual Studio.

In order to support

## Using MSBuild from Visual Studio

To ensure that programmatic builds from your application match those Visual Studio or MSBuild.exe, load MSBuild assemblies from Visual Studio and use the SDKs available within Visual Studio. The Microsoft.Build.Locator NuGet package automates this.

## Using Microsoft.Build.Locator

Must deploy at runtime, but then don't have to ship MSBuild.

### Change MSBuild refs

In order to ensure that MSBuild is loaded from a central location, you must not distribute its assemblies with your application.

The mechanism for changing your project to avoid that depends on how you reference MSBuild.

#### Using NuGet packages (preferred)

If you

Change your project file(s) to reference MSBuild assemblies from their NuGet packages. Specify `ExcludeAssets=runtime` to tell NuGet that the assemblies are needed only at build time, and should not be copied to the output directory.

The major and minor version of the MSBuild packages must be less than or equal to the minimum version of Visual Studio you wish to support. If you wish to support any version of Visual Studio 2017, reference package version `15.1.548`.

For example, 

```xml
<ItemGroup>
  <PackageReference Include="Microsoft.Build" Version="15.1.548" ExcludeAssets="runtime" />
  <PackageReference Include="Microsoft.Build.Utilities" Version="15.1.548" ExcludeAssets="runtime" />
</ItemGroup>
```

#### Using extension assemblies

#### Binding redirects?
#### Ensure output clean

### Add package reference

Add a NuGet package reference to [Microsoft.Build.Locator](https://www.nuget.org/packages/Microsoft.Build.Locator/).

If possible, do this from a project that uses [`PackageReference`](https://docs.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files) rather than `packages.config`. Doing so enables functionality within the package that checks project state at build time.

### Ensure output clean
### Register instance before calling MSBuild

