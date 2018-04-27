# Updating an existing application for MSBuild 15

In versions of MSBuild prior to 15.0, MSBuild was loaded from the Global Assembly Cache (GAC) and MSBuild extensions were installed in the registry. This ensured that all applications used the same version of MSBuild and had access to the same toolsets, but prevented side-by-side installations of different versions of Visual Studio.

In order to support faster, smaller, and side-by-side installation, Visual Studio 2017 no longer places MSBuild in the GAC or modifies the registry. Unfortunately, this means that applications that wish to use the MSBuild API to evaluate or build projects cannot implicitly rely on the Visual Studio installation.

## Using MSBuild from Visual Studio

To ensure that programmatic builds from your application match those done within Visual Studio or MSBuild.exe, load MSBuild assemblies from Visual Studio and use the SDKs available within Visual Studio. The Microsoft.Build.Locator NuGet package streamlines this.

## Using Microsoft.Build.Locator

If you redistribute `Microsoft.Build.Locator.dll` with your application, you will not need to distribute other MSBuild assemblies.

Updating a project to use MSBuild 15 and the locator API requires a few changes in your project, described below. To see an example of the changes required to update a project, see [the commits made to an example project in the MSBuildLocator repository](https://github.com/Microsoft/MSBuildLocator/commits/example-updating-to-msbuild-15).

### Change MSBuild references

In order to ensure that MSBuild is loaded from a central location, you must not distribute its assemblies with your application.

The mechanism for changing your project to avoid loading MSBuild from a central locations depends on how you reference MSBuild.

#### Using NuGet packages (preferred)

These instructions assume that you're using [`PackageReference`-style NuGet references](https://docs.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files).

Change your project file(s) to reference MSBuild assemblies from their NuGet packages. Specify `ExcludeAssets=runtime` to tell NuGet that the assemblies are needed only at build time, and should not be copied to the output directory.

The major and minor version of the MSBuild packages must be less than or equal to the minimum version of Visual Studio you wish to support. If you wish to support any version of Visual Studio 2017, reference package version `15.1.548`.

For example, you can use this XML:

```xml
<ItemGroup>
  <PackageReference Include="Microsoft.Build" Version="15.1.548" ExcludeAssets="runtime" />
  <PackageReference Include="Microsoft.Build.Utilities" Version="15.1.548" ExcludeAssets="runtime" />
</ItemGroup>
```

#### Using extension assemblies

If you cannot use NuGet packages, you can reference MSBuild assemblies that are distributed with Visual Studio. If you reference MSBuild directly, ensure that it will not be copied to your ouput directory by setting `Copy Local` to `False`. In the project file, this will look like the following:

```xml
    <Reference Include="Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <Private>False</Private>
    </Reference>
```

#### Binding redirects

Referencing the Microsoft.Build.Locator package automatically ensures that your application uses the required binding redirects of all versions of MSBuild assemblies to version `15.1.0.0`.

### Ensure output clean

Build your project and inspect the output directory to make sure that it does not contain any `Microsoft.Build.*.dll` assemblies (other than `Microsoft.Build.Locator.dll`, added in the next step).

### Add package reference

Add a NuGet package reference to [Microsoft.Build.Locator](https://www.nuget.org/packages/Microsoft.Build.Locator/).

```xml
    <PackageReference Include="Microsoft.Build.Locator">
      <Version>1.0.7-preview-ge60d679b53</Version>
    </PackageReference>
```

### Register instance before calling MSBuild

Add a call to the Locator API before calling any method that uses MSBuild.

The simplest way to do this is to add a call to

```c#
MSBuildLocator.RegisterDefaults();
```

in your application startup code.

If you would like finer-grained control over the loading of MSBuild, you can select a result of `MSBuildLocator.QueryVisualStudioInstances()` to pass to `MSBuildLocator.RegisterInstance()` manually, but this is generally not needed.
