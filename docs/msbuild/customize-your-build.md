---
title: Customize your build | Microsoft Docs
description: Learn about several extensibility hooks you can use to customize MSBuild projects that use the standard build process. 
ms.custom: SEO-VS-2020
ms.date: 09/13/2021
ms.topic: conceptual
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
ms.assetid: d0bceb3b-14fb-455c-805a-63acefa4b3ed
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Customize your build

MSBuild projects that use the standard build process (importing *Microsoft.Common.props* and *Microsoft.Common.targets*) have several extensibility hooks that you can use to customize your build process.

## Add arguments to command-line MSBuild invocations for your project

A *Directory.Build.rsp* file in or above your source directory will be applied to command-line builds of your project. For details, see [MSBuild response files](../msbuild/msbuild-response-files.md#directorybuildrsp).

## Directory.Build.props and Directory.Build.targets

You can add a new property to every project by defining it in a single file called *Directory.Build.props* in the root folder that contains your source. When MSBuild runs, *Microsoft.Common.props* searches your directory structure for the *Directory.Build.props* file (and *Microsoft.Common.targets* looks for *Directory.Build.targets*). If it finds one, it imports the file and reads the properties defined within it. *Directory.Build.props* is a user-defined file that provides customizations to projects under a directory.

> [!NOTE]
> Linux-based file systems are case-sensitive. Make sure the casing of the Directory.Build.props filename matches exactly, or it won't be detected during the build process.
>
> See [this GitHub issue](https://github.com/dotnet/core/issues/1991#issue-368441031) for more information.

### Directory.Build.props example

For example, if you wanted to enable all of your projects to access the new Roslyn **/deterministic** feature (which is exposed in the Roslyn `CoreCompile` target by the property `$(Deterministic)`), you could do the following.

1. Create a new file in the root of your repo called *Directory.Build.props*.
2. Add the following XML to the file.

   ```xml
   <Project>
    <PropertyGroup>
      <Deterministic>true</Deterministic>
    </PropertyGroup>
   </Project>
   ```

3. Run MSBuild. Your project’s existing imports of *Microsoft.Common.props* and *Microsoft.Common.targets* find the file and import it.

### Search scope

When searching for a *Directory.Build.props* file, MSBuild walks the directory structure upwards from your project location (`$(MSBuildProjectFullPath)`), stopping after it locates a *Directory.Build.props* file. For example, if your `$(MSBuildProjectFullPath)` was *c:\users\username\code\test\case1*, MSBuild would start searching there and then search the directory structure upward until it located a *Directory.Build.props* file, as in the following directory structure.

```
c:\users\username\code\test\case1
c:\users\username\code\test
c:\users\username\code
c:\users\username
c:\users
c:\
```

The location of the solution file is irrelevant to *Directory.Build.props*.

### Import order

*Directory.Build.props* is imported very early in *Microsoft.Common.props*, and properties defined later are unavailable to it. So, avoid referring to properties that are not yet defined (and will evaluate to empty).

Properties that are set in *Directory.Build.props* can be overridden elsewhere in the project file or in imported files, so you should think of the settings in *Directory.Build.props* as specifying the defaults for your projects.

*Directory.Build.targets* is imported from *Microsoft.Common.targets* after importing *.targets* files from NuGet packages. So, it can override properties and targets defined in most of the build logic, or set properties for all your projects regardless of what the individual projects set.

When you need to set a property or define a target for an individual project that overrides any prior settings, put that logic in the project file after the final import. In order to do this in an SDK-style project, you first have to replace the SDK-style attribute with the equivalent imports. See [How to use MSBuild project SDKs](how-to-use-project-sdk.md).

> [!NOTE]
> The MSBuild engine reads in all imported files during evaluation, before starting build execution for a project (including any `PreBuildEvent`), so these files are not expected to be modified by the `PreBuildEvent` or any other part of the build process. Any modifications do not take effect until the next invocation of *MSBuild.exe* or the next Visual Studio build. Also, if your build process contains many project builds (as with multitargeting or building dependent projects), then imported files, including *Directory.build.props* are read when evaluation occurs for each individual project build.

### Use case: multi-level merging

Suppose you have this standard solution structure:

```
\
  MySolution.sln
  Directory.Build.props     (1)
  \src
    Directory.Build.props   (2-src)
    \Project1
    \Project2
  \test
    Directory.Build.props   (2-test)
    \Project1Tests
    \Project2Tests
```

It might be desirable to have common properties for all projects *(1)*, common properties for *src* projects *(2-src)*, and common properties for *test* projects *(2-test)*.

To make MSBuild correctly merge the "inner" files (*2-src* and *2-test*) with the "outer" file (*1*), you must take into account that once MSBuild finds a *Directory.Build.props* file, it stops further scanning. To continue scanning and merge into the outer file, place this code into both inner files:

`<Import Project="$([MSBuild]::GetPathOfFileAbove('Directory.Build.props', '$(MSBuildThisFileDirectory)../'))" />`

A summary of MSBuild's general approach is as follows:

- For any given project, MSBuild finds the first *Directory.Build.props* upward in the solution structure, merges it with defaults, and stops scanning for more.
- If you want multiple levels to be found and merged, then [`<Import...>`](../msbuild/property-functions.md#msbuild-getpathoffileabove) (shown above) the "outer" file from the "inner" file.
- If the "outer" file does not itself also import something above it, then scanning stops there.
- To control the scanning/merging process, use `$(DirectoryBuildPropsPath)` and `$(ImportDirectoryBuildProps)`.

Or more simply: the first *Directory.Build.props* that doesn't import anything is where MSBuild stops.

### Choose between adding properties to a .props or .targets file

MSBuild is import-order dependent, and the last definition of a property (or a `UsingTask` or target) is the definition used.

When using explicit imports, you can import from a *.props* or *.targets* file at any point. Here is the widely used convention:

- *.props* files are imported early in the import order.

- *.targets*  files are imported late in the build order.

This convention is enforced by `<Project Sdk="SdkName">` imports (that is, the import of *Sdk.props* comes first, before all of the contents of the file, then *Sdk.targets* comes last, after all of the contents of the file).

When deciding where to put the properties, use the following general guidelines:

- For many properties, it doesn't matter where they're defined, because they're not overwritten and will be read only at execution time.

- For behavior that might be customized in an individual project, set defaults in *.props* files.

- Avoid setting dependent properties in *.props* files by reading the value of a possibly customized property, because the customization won't happen until MSBuild reads the user's project.

- Set dependent properties in *.targets* files, because they'll pick up customizations from individual projects.

- If you need to override properties, do it in a *.targets* file, after all user-project customizations have had a chance to take effect. Be cautious when using derived properties; derived properties may need to be overridden as well.

- Include items in *.props* files (conditioned on a property). All properties are considered before any item, so user-project property customizations get picked up, and this gives the user's project the opportunity to `Remove` or `Update` any item brought in by the import.

- Define targets in *.targets* files. However, if the *.targets* file is imported by an SDK, remember that this scenario makes overriding the target more difficult because the user's project doesn't have a place to override it by default.

- If possible, prefer customizing properties at evaluation time over changing properties inside a target. This guideline makes it easier to load a project and understand what it's doing.

## MSBuildProjectExtensionsPath

By default, *Microsoft.Common.props* imports `$(MSBuildProjectExtensionsPath)$(MSBuildProjectFile).*.props` and *Microsoft.Common.targets* imports `$(MSBuildProjectExtensionsPath)$(MSBuildProjectFile).*.targets`. The default value of `MSBuildProjectExtensionsPath` is `$(BaseIntermediateOutputPath)`, `obj/`. NuGet uses this mechanism to refer to build logic delivered with packages; that is, at restore time, it creates `{project}.nuget.g.props` files that refer to the package contents.

You can disable this extensibility mechanism by setting the property `ImportProjectExtensionProps` to `false` in a *Directory.Build.props* or before importing *Microsoft.Common.props*.

> [!NOTE]
> Disabling MSBuildProjectExtensionsPath imports will prevent build logic delivered in NuGet packages from applying to your project. Some NuGet packages require build logic to perform their function and will be rendered useless when this is disabled.

## .user file

*Microsoft.Common.CurrentVersion.targets* imports `$(MSBuildProjectFullPath).user` if it exists, so you can create a file next to your project with that additional extension. For long-term changes you plan to check into source control, prefer changing the project itself, so that future maintainers do not have to know about this extension mechanism.

## MSBuildExtensionsPath and MSBuildUserExtensionsPath

> [!WARNING]
> Using these extension mechanisms makes it harder to get repeatable builds across machines. Try to use a configuration that can be checked into your source control system and shared among all developers of your codebase.

By convention, many core build logic files import

```xml
$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\{TargetFileName}\ImportBefore\*.targets
```

before their contents, and

```xml
$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\{TargetFileName}\ImportAfter\*.targets
```

afterward. This convention allows installed SDKs to augment the build logic of common project types.

The same directory structure is searched in `$(MSBuildUserExtensionsPath)`, which is the per-user folder *%LOCALAPPDATA%\Microsoft\MSBuild*. Files placed in that folder will be imported for all builds of the corresponding project type run under that user's credentials. You can disable the user extensions by setting properties named after the importing file in the pattern `ImportUserLocationsByWildcardBefore{ImportingFileNameWithNoDots}`. For example, setting `ImportUserLocationsByWildcardBeforeMicrosoftCommonProps` to `false` would prevent importing `$(MSBuildUserExtensionsPath)\$(MSBuildToolsVersion)\Imports\Microsoft.Common.props\ImportBefore\*`.

## Customize the solution build

> [!IMPORTANT]
> Customizing the solution build in this way applies only to command-line builds with *MSBuild.exe*. It **does not** apply to builds inside Visual Studio. For this reason, it is not recommended to put customization at the solution level. A better alternative for customizing all projects in a solution is to use *Directory.Build.props* and *Directory.build.targets* files in the solution folder, as discussed elsewhere in this article.

When MSBuild builds a solution file, it first translates it internally into a project file and then builds that. The generated project file imports `before.{solutionname}.sln.targets` before defining any targets and `after.{solutionname}.sln.targets` after importing targets, including targets installed to the `$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\SolutionFile\ImportBefore` and `$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\SolutionFile\ImportAfter` directories.

For example, you could define a new target to write a custom log message after building *MyCustomizedSolution.sln* by creating a file in the same directory named *after.MyCustomizedSolution.sln.targets* that contains

```xml
<Project>
 <Target Name="EmitCustomMessage" AfterTargets="Build">
   <Message Importance="High" Text="The solution has completed the Build target" />
 </Target>
</Project>
```

The solution build is separate from the project builds, so settings here do not affect project builds.

## Customize all .NET builds

When maintaining a build server, you might need to configure MSBuild settings globally for all builds on the server.  In principle, you could modify the global *Microsoft.Common.Targets* or *Microsoft.Common.Props* files, but there is a better way. You can affect all builds of a certain project type (such as all C# projects) by using certain MSBuild properties and adding certain custom `.targets` and `.props` files.

To affect all C# or Visual Basic builds governed by an installation of MSBuild or Visual Studio, create a file *Custom.Before.Microsoft.Common.Targets* or *Custom.After.Microsoft.Common.Targets* with targets that will run before or after *Microsoft.Common.targets*, or a file *Custom.Before.Microsoft.Common.Props* or *Custom.After.Microsoft.Common.Props* with properties that will be processed before or after *Microsoft.Common.props*.

You can specify the locations of these files by using the following MSBuild properties:

- CustomBeforeMicrosoftCommonProps
- CustomBeforeMicrosoftCommonTargets
- CustomAfterMicrosoftCommonProps
- CustomAfterMicrosoftCommonTargets
- CustomBeforeMicrosoftCSharpTargets
- CustomBeforeMicrosoftVisualBasicTargets
- CustomAfterMicrosoftCSharpTargets
- CustomAfterMicrosoftVisualBasicTargets

The *Common* versions of these properties affect both C# and Visual Basic projects. You can set these properties in the MSBuild command line.

```cmd
msbuild /p:CustomBeforeMicrosoftCommonTargets="C:\build\config\Custom.Before.Microsoft.Common.Targets" MyProject.csproj
```

The best approach depends on your scenario. Using Visual Studio Extensibility, you can customize the build system and provide a mechanism for installing and managing the customizations.

If you have a dedicated build server and want to ensure that certain targets always execute on all builds of the appropriate project type that execute on that server, then using a global custom `.targets` or `.props` file makes sense.  If you want the custom targets to only execute when certain conditions apply, then use another file location and set the path to that file by setting the appropriate MSBuild property in the MSBuild command line only when needed.

> [!WARNING]
> Visual Studio uses the custom `.targets` or `.props` files if it finds them in the MSBuild folder whenever it builds any project of the matching type. This can have unintended consequences, and if done incorrectly, can disable the ability of Visual Studio to build on your computer.

## Customize C++ builds

For C++ projects, the previously mentioned custom *.targets* and *.props* files cannot be used in the same way to override default settings. *Directory.Build.props* is imported by *Microsoft.Common.props*, which is imported in `Microsoft.Cpp.Default.props` while most of the defaults are defined in *Microsoft.Cpp.props* and for a number of properties a "if not yet defined" condition cannot be used, as the property is already defined, but the default needs to be different for particular project properties defined in `PropertyGroup` with `Label="Configuration"` (see [.vcxproj and .props file structure](/cpp/build/reference/vcxproj-file-structure)).

But, you can use the following properties to specify *.props* file(s) to be automatically imported before/after *Microsoft.Cpp.\** files:

- ForceImportAfterCppDefaultProps
- ForceImportBeforeCppProps
- ForceImportAfterCppProps
- ForceImportBeforeCppTargets
- ForceImportAfterCppTargets

To customize the default values of properties for all C++ builds, create another *.props* file (say, *MyProps.props*), and define the `ForceImportAfterCppProps` property in `Directory.Build.props` pointing to it:

```xml
<PropertyGroup>
  <ForceImportAfterCppProps>$(MsbuildThisFileDirectory)\MyProps.props<ForceImportAfterCppProps>
</PropertyGroup>
```

*MyProps.props* will be automatically imported at the very end of *Microsoft.Cpp.props*.

## Customize all C++ builds

Customizing the Visual Studio installation isn't recommended, since it's not easy to keep track of such customizations, but if you're extending Visual Studio to customize C++ builds for a particular platform, you can create `.targets` files for each platform and place them in the appropriate import folders for those platforms as part of a Visual Studio extension.

The `.targets` file for the Win32 platform, *Microsoft.Cpp.Win32.targets*, contains the following `Import` element:

```xml
<Import Project="$(VCTargetsPath)\Platforms\Win32\ImportBefore\*.targets"
        Condition="Exists('$(VCTargetsPath)\Platforms\Win32\ImportBefore')"
/>
```

There's a similar element near the end of the same file:

```xml
<Import Project="$(VCTargetsPath)\Platforms\Win32\ImportAfter\*.targets"
        Condition="Exists('$(VCTargetsPath)\Platforms\Win32\ImportAfter')"
/>
```

Similar import elements exist for other target platforms in *%ProgramFiles32%\MSBuild\Microsoft.Cpp\v{version}\Platforms\*.

Once you place the `.targets` file in the appropriate `ImportAfter` folder according to the platform, MSBuild imports your file into every C++ build for that platform. You can put multiple `.targets` files there, if needed. 

Using Visual Studio Extensibility, further customizations are possible, such as defining a new platform. For more information, see [C++ project extensibility](../extensibility/visual-cpp-project-extensibility.md).

### Specify a custom import on the command line

For custom `.targets` that you want to include for a specific build of a C++ project, set one or both of the properties `ForceImportBeforeCppTargets` and `ForceImportAfterCppTargets` on the command line.

```cmd
msbuild /p:ForceImportBeforeCppTargets="C:\build\config\Custom.Before.Microsoft.Cpp.Targets" MyCppProject.vcxproj
```

For a global setting (to affect, say, all C++ builds for a platform on a build server), there are two methods. First, you can set these properties using a system environment variable that is always set. This works because MSBuild always reads the environment and creates (or overrides) properties for all the environment variables.

## See also

- [MSBuild concepts](../msbuild/msbuild-concepts.md)

- [MSBuild reference](../msbuild/msbuild-reference.md)
