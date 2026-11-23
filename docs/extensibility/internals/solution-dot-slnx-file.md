---
title: Solution (.slnx) file
description: Learn about the XML-based .slnx format for projects, solution folders, build configurations, dependencies, and persisted properties.
ms.date: 11/17/2026
ms.topic: reference
author: sgreenmsft
ms.author: sgreen
ms.subservice: extensibility-integration
---
# Solution (.slnx) file

In Visual Studio, solutions organize projects. These files store the solution information:

- **Solution file (`.sln` or `.slnx`):** Stores shared solution information in the [traditional, text-based `.sln` format](solution-dot-sln-file.md) or the newer, XML-based `.slnx` format.
- **Solution user options file (`.suo`):** Stores user-specific solution options in a binary format. For more information, see [Solution user options (.suo) file](solution-user-options-dot-suo-file.md).

Each project file defines its own source files, references, and project-specific build settings.

> [!NOTE]
> **This article describes the `.slnx` format.** For the traditional `.sln` format, see [Solution (.sln) file](solution-dot-sln-file.md).

The XML format represents the same solution model as the `.sln` file format, but omits information that can be inferred from project paths and defaults. Most solutions need only a list of projects:

```xml
<Solution>
  <Project Path="src/App/App.csproj" />
  <Project Path="test/App.Tests/App.Tests.csproj" />
</Solution>
```

Paths are relative to the solution file, not to the location of an enclosing solution folder. Forward slashes are recommended for portable files; the serializer also accepts backslashes. Loading a solution model does not require opening the referenced project files.

## Document structure

The root is a single `Solution` element. An empty solution is valid:

```xml
<Solution />
```

The XML declaration is optional. The examples use no XML namespace.

| Child element | Purpose |
| --- | --- |
| `Configurations` | Solution build types, platforms, and project-type definitions. |
| `Folder` | A logical solution folder, its files, and its projects. |
| `Project` | A project at the solution root. |
| `Properties` | A named collection of persisted solution properties. |

`Solution` supports these optional attributes:

| Attribute | Meaning |
| --- | --- |
| `Description` | A user-visible description of the solution. |
| `Version` | The solution file format version, for example `1.0`. This is not a Visual Studio product version. |

The current format major version is `1`. Normally, `Version` can be omitted. A reader rejects a version with a newer, unsupported major version.

## Projects

A `Project` can appear directly under `Solution` or inside a `Folder`. Its required `Path` identifies the project throughout the solution. A project path must be unique, even when projects are in different solution folders. Path comparisons are case-insensitive.

| Attribute | Meaning |
| --- | --- |
| `Path` | Required project file path or, for non-file-based project types (for example, legacy ASP.NET Web Site projects), a folder path or URI. |
| `Type` | Project-type GUID or friendly name. Omit it when the file extension identifies the type. |
| `Id` | Optional project-instance GUID. If omitted, the model generates a deterministic identifier from the project path. |
| `DisplayName` | Name for a project whose path does not provide a filename-derived display name, such as a website directory path ending in `/` or a URI. |
| `DefaultStartup` | Set to `true` to indicate that this project is the default startup project when the solution is loaded. |

`Type` identifies a project system (for example, C# projects), while `Id` identifies a specific project instance (for example, `src/MyConsoleApp/MyConsoleApp.csproj`). An omitted `Id` is generated from the project path. Specify `Id` to retain a particular GUID instead, for example the project's existing GUID from an `.sln` file.

For file-backed projects (for example, `.csproj` and `.vcxproj` projects, as opposed to non-file-backed projects such as legacy ASP.NET Web Site projects), the filename without its extension determines the display name. `DisplayName` does not override it. For example, a project at `src/App/App.csproj` is named `App` even if `DisplayName` is supplied. Projects in the same solution folder, including the solution root, must have distinct display names, compared case-insensitively. Place projects with the same name in different solution folders.

### Built-in project types

The complete set of built-in project-type mappings is:

| Extension | Friendly type | Project-type GUID |
| --- | --- | --- |
| None | `Common C#` | `9A19103F-16F7-4668-BE54-9A1E7A4F7556` |
| None | `Common VB` | `778DAE3C-4631-46EA-AA77-85C1314464D9` |
| None | `Common F#` | `6EC3EE1D-3C4E-46DD-8F32-0CC8E7565705` |
| `.csproj` | `C#` | `FAE04EC0-301F-11D3-BF4B-00C04F79EFBC` |
| `.vbproj` | `VB` | `F184B08F-C81C-45F6-A57F-5ABD9991F28F` |
| `.fsproj` | `F#` | `F2A71F9B-5D33-465A-A702-920D77279786` |
| `.shproj` | `Shared` | `D954291E-2A0B-460D-934E-DC6B0785DB48` |
| `.webproj` | `Website` | `E24C65DC-7377-472B-9ABA-BC803B73C61A` |
| `.vcxproj` | `VC` | `8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942` |
| `.vcxitems` | None | `8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942` |
| `.exe` | `Exe` | `911E67C6-3D85-4FCE-B560-20A9C3E3FF48` |
| None | `Folder` | `2150E333-8FDC-42A3-9474-1A3956D46DE8` |
| `.esproj` | `Javascript` | `54A90642-561A-4BB1-A94E-469ADEE60C69` |
| `.njsproj` | `Node.js` | `9092AA53-FB77-4645-B42D-1CCCA6BD08BD` |
| `.deployproj` | `Deploy` | `151D2E53-A2C4-4D7D-83FE-D05416EBD58E` |
| `.vsproj` | `Installer` | `54435603-DBB4-11D2-8724-00A0C9A8B90C` |
| `.wixproj` | `Wix` | `930C7802-8A8C-48F9-8165-68863BCCD9DD` |
| `.sqlproj` | `SQL` | `00D1A9C2-B5F0-4AF3-8072-F6C62B433612` |
| `.usqldbproj` | `U-SQL-DB` | `0C603C2C-620A-423B-A800-4F3E2F6281F1` |
| `.usqlproj` | `U-SQL` | `182E2583-ECAD-465B-BB50-91101D7C24CE` |
| `.rptproj` | `SSRS` | `F14B399A-7131-4C87-9E4B-1186C45EF12D` |
| `.sfproj` | `Fabric` | `A07B5EB6-E848-4116-A8D0-A826331D98C6` |
| `.ccproj` | `Cloud Computing` | `CC5FD16D-436D-48AD-A40C-5A424C6E3E79` |
| `.dcproj` | `Docker` | `E53339B2-1760-4266-BCC7-CA923CBCF16C` |

Entries with no extension are not inferred from filenames. The `.vcxitems` mapping shares the `VC` GUID but has no separate friendly name. The `Folder` entry identifies the solution-folder type; use `Folder` elements to declare solution folders. A separate unnamed entry supplies default configuration rules rather than a project-type mapping.

If the project type cannot be inferred from the path (for example, a URI or an unrecognized file extension), set the `Project` element's `Type` attribute to a project-type GUID or a known friendly type name. Specifying a GUID in `Type` does not require a custom `ProjectType` definition. Alternatively, define an extension mapping with `ProjectType`, described in [Project-type definitions and shared defaults](#project-type-definitions-and-shared-defaults), to infer the type from that extension without specifying `Type` on each project.

```xml
<Solution>
  <Project Path="src/App/App.csproj" DefaultStartup="true" />
  <Project Path="source/site/"
           Type="E24C65DC-7377-472B-9ABA-BC803B73C61A"
           DisplayName="Website" />
</Solution>
```

The website project uses a local folder rather than a project file. In this example, the trailing slash lets `DisplayName` supply the name `Website`.

## Solution folders and files

A solution folder is a logical grouping, not a file system directory. Its required `Name` is a full logical path that starts and ends with `/`. Nested folder paths contain additional `/` separators. Declare folders as siblings under `Solution`, rather than nesting `Folder` elements:

```xml
<Solution>
  <Folder Name="/Source/">
    <File Path="README.md" />
    <Project Path="src/App/App.csproj" />
  </Folder>
  <Folder Name="/Source/Libraries/">
    <Project Path="src/Library/Library.csproj" />
  </Folder>
</Solution>
```

The `/Source/` parent can also be created implicitly by declaring `/Source/Libraries/`. A `File` requires a `Path`; it adds an existing file to the logical folder, without making it part of a project or changing how it is built. Its path, like a project's path, is relative to the solution file.

When you create a solution folder by editing the XML, normally omit its optional `Id` and `Properties` metadata:

- `Id` retains a particular folder-instance GUID, for example a folder GUID read from an existing `.sln` file. Otherwise, the model generates the identifier from the folder's name and its parent's identifier. Folder nesting in `.slnx` is expressed by the `Name` paths, not by these GUIDs. The SolutionPersistence library's default `.sln`-to-`.slnx` conversion discards explicit identifiers; callers that need to retain them must set `SlnxSerializerSettings.TrimVisualStudioProperties` to `false` on the XML serializer model extension.
- `Properties` preserves named, tool-defined data attached to the folder. For example, custom `ProjectSection` data on a solution-folder entry in a `.sln` file can be retained here during conversion. Only add these collections when a consuming tool defines their meaning; they are not needed to group projects or add solution files.

Folder names and file paths within a folder are compared case-insensitively.

## Solution configurations

A solution configuration is a build type and platform pair, such as `Debug|Any CPU`. Define the available dimensions in the single optional `Configurations` element:

```xml
<Solution>
  <Configurations>
    <BuildType Name="Debug" />
    <BuildType Name="Release" />
    <BuildType Name="Shipping" />
    <Platform Name="Any CPU" />
    <Platform Name="x64" />
  </Configurations>
  <Project Path="src/App/App.csproj" />
</Solution>
```

The combinations of the listed build types and platforms are the solution configurations. These declarations describe the solution's choices; they do not add configurations to the project files themselves.

For a solution containing projects, omitted dimensions have these solution-level defaults:

| Dimension | Default solution value |
| --- | --- |
| No `BuildType` entries | `Debug` and `Release` |
| No `Platform` entries | `Any CPU` |

These defaults apply independently. For example, a `Configurations` element containing only `Platform` entries still has `Debug` and `Release` build types. The serializer can omit explicitly listed defaults when saving.

These are not necessarily the platforms selected for individual projects. For example, with no `Platform` entries, the solution platform is `Any CPU`, but the built-in `.vcxproj` mapping selects the project platform `x64`. To make `x64` the solution platform itself, declare `<Platform Name="x64" />` inside `Configurations`.

### Mapping solution configurations to projects

Place mapping rules inside a `Project` to override how a solution configuration selects that project's configuration and participation in solution builds and deployments:

```xml
<Solution>
  <Configurations>
    <BuildType Name="Debug" />
    <BuildType Name="Release" />
    <Platform Name="Any CPU" />
    <Platform Name="x64" />
  </Configurations>
  <Project Path="src/App/App.csproj">
    <!-- For solution build type Release on any platform, select the
         project's Release build type. -->
    <BuildType Solution="Release|*" Project="Release" />
    <!-- For solution platform x64 with any build type, select the
         project's Any CPU platform. -->
    <Platform Solution="*|x64" Project="Any CPU" />
    <!-- Exclude this project from the solution build for Debug|x64. -->
    <Build Solution="Debug|x64" Project="false" />
    <!-- When deploying solution configuration Release|x64, include this
         project. Omitting Project is equivalent to Project="true". -->
    <Deploy Solution="Release|x64" />
  </Project>
</Solution>
```

| Rule element | Meaning of `Project` |
| --- | --- |
| `BuildType` | Project build type to select. |
| `Platform` | Project platform to select. |
| `Build` | Whether the project participates in the solution build: `true` or `false`. |
| `Deploy` | Whether the project participates in solution deployment: `true` or `false`. |

The optional `Solution` selector has the form `BuildType|Platform`. Either dimension can be `*`, meaning all values of that dimension. Omitting `Solution` applies the rule to every solution configuration. Use a distinct selector for each rule of the same element type within a project or project-type definition.

`BuildType` and `Platform` require a nonempty `Project` value. For these mappings, `Project="*"` selects the corresponding solution value. `Build` and `Deploy` default their `Project` value to `true` when the attribute is omitted, so `<Deploy />` enables deployment for all solution configurations.

Without overriding rules, a project generally follows the solution build type and platform, participates in the build, and does not deploy. Built-in project-type rules refine these defaults: for example, C# projects map to `AnyCPU`, Visual C++ projects map the solution platform `x86` to `Win32`, and shared-code projects do not build separately.

### Project-type definitions and shared defaults

`ProjectType` entries in `Configurations` associate extensions or friendly names with GUIDs and define configuration rules shared by projects of that type:

```xml
<Solution>
  <Configurations>
    <ProjectType Name="Custom" Extension=".customproj"
                 TypeId="B1CC274F-733D-46A5-B148-8309670B362D">
      <Platform Project="x64" />
    </ProjectType>
    <ProjectType Name="Custom library" Extension=".customlib"
                 BasedOn="Custom" />
  </Configurations>
  <Project Path="src/App/App.customproj" />
  <Project Path="src/Library/Library.customlib" />
</Solution>
```

| Attribute | Meaning |
| --- | --- |
| `Name` | Friendly type name that a project's `Type` can reference. |
| `Extension` | Extension used to infer the type when possible; a leading `.` is recommended. |
| `TypeId` | Project-type GUID. It can be inherited through `BasedOn`. |
| `BasedOn` | Base type from which to inherit its GUID and configuration rules. Use a declared type's friendly name, or a built-in type's name or extension. |
| `IsBuildable` | Defaults to `true`. Setting it to `false` supplies a no-build rule and ignores other rules on that type. |
| `SupportsPlatform` | Defaults to `true`. Setting it to `false` marks the project type as having no platform configuration. Ignored when `IsBuildable` is `false`. |

A named or extension-specific definition must be identifiable by `Name` or `Extension`. Extension mappings and friendly names must be unique within the solution's definitions. A `BasedOn` reference must resolve and must not form a cycle.

A solution's `ProjectType` definitions can override built-in extension mappings or friendly names. Use `BasedOn` to inherit a built-in type's GUID and rules, then override the rules that need to differ. Reusing an extension, friendly name, or GUID does not by itself inherit that type's rules.

For example, this definition retains the built-in C# type GUID and rules but overrides its project platform with `x64` for projects whose type is inferred from `.csproj`:

```xml
<Solution>
  <Configurations>
    <ProjectType Extension=".csproj" BasedOn="C#">
      <Platform Project="x64" />
    </ProjectType>
  </Configurations>
  <Project Path="src/App/App.csproj" />
</Solution>
```

The override is local to this solution. It changes solution-to-project configuration mappings, not the contents of the project file or the project system's implementation. A project that explicitly selects a different type definition uses that definition's rules instead.

A `ProjectType` with no `Name`, `Extension`, or `TypeId` defines solution-wide default rules rather than a particular project type. For example, a `<Build Project="false" />` rule inside such an entry disables building by default; individual projects can opt back in.

Configuration rules are applied from general to specific: built-in defaults, base project types, the selected project type, solution-wide defaults, and finally the project's own rules. A project's explicit mapping therefore takes precedence over a shared default. Shared defaults apply when the project type resolves through the built-in table or the solution's definitions; a bare, unregistered GUID has no project-type rule chain.

## Build dependencies

A project's `BuildDependency` elements identify other projects that must build before it. The required `Project` attribute is the other project's solution path, not its GUID or display name:

```xml
<Solution>
  <Project Path="src/App/App.csproj">
    <BuildDependency Project="src/Generator/Generator.csproj" />
  </Project>
  <Project Path="src/Generator/Generator.csproj" />
</Solution>
```

The referenced project must exist in the solution, and a project cannot depend on itself. A dependency can reference a project in another solution folder. Prefer project-to-project references in the project files when they can express the dependency.

For example, suppose `Generator.csproj` builds a custom MSBuild task that `App.csproj` invokes during its build. The dependency above ensures that the task assembly is built before the solution starts building `App`; it does not add a compiler reference to that assembly or invoke the task. This is a [documented use case for an explicit project dependency](../../ide/how-to-create-and-remove-project-dependencies.md).

`BuildDependency` records ordering at solution level. Building `App.csproj` directly still requires a way to build or locate the task assembly.

## Persisted properties

`Solution`, `Folder`, and `Project` can contain named `Properties` collections. Each collection contains `Property` elements with a required `Name` and an optional `Value`. An omitted `Value` represents an empty string.

```xml
<Solution>
  <Project Path="src/App/App.csproj" />
  <Properties Name="ExampleExtension">
    <Property Name="Mode" Value="Shared" />
  </Properties>
  <Properties Name="ExampleExtension.AfterLoad" Scope="PostLoad">
    <Property Name="Enabled" Value="true" />
  </Properties>
</Solution>
```

`Properties.Name` identifies the collection to its consumer. Its optional `Scope` defaults to `PreLoad`; `PostLoad` marks information for use after project loading. These correspond to the pre-solution and post-solution property sections in a `.sln` file. Values are strings; their interpretation belongs to the component that persists them.

## Editing and compatibility

Use ordinary XML escaping inside attribute values: for example, write `&amp;` for `&`, `&lt;` for `<`, and `&quot;` for a double quote.

Use XML comments (`<!-- ... -->`) to explain why an entry or rule exists. For example, a comment beside a `Build` rule can explain why a project is excluded from a particular solution configuration's build. Comments are for people reading the file; they do not affect configuration mappings or build behavior.

The SolutionPersistence serializer preserves existing comments, whitespace, path separator choices, and unrecognized XML where possible when saving the loaded model. This preservation is not a guarantee that every tool understands an extension. Converting through another file format or constructing a new model can discard XML-only information.

Compared with a `.sln` file:

| `.sln` file | `.slnx` file |
| --- | --- |
| `Project` blocks with type and instance GUIDs | `Project` elements; type and instance IDs can be inferred or generated. |
| `NestedProjects` GUID mappings | Full logical paths in `Folder.Name` and projects contained in those folders. |
| Solution and project configuration sections | `Configurations` dimensions, defaults, and project mapping rules. |
| `ProjectDependencies` GUID entries | `BuildDependency` elements referencing project paths. |
| Named global or project property sections | Named `Properties` collections on solutions, folders, or projects. |

For the implementation's schema and examples, see [Slnx.xsd](https://github.com/microsoft/vs-solutionpersistence/blob/main/src/Microsoft.VisualStudio.SolutionPersistence/Serializer/Xml/Slnx.xsd) and the [sample solution files](https://github.com/microsoft/vs-solutionpersistence/tree/main/test/Microsoft.VisualStudio.SolutionPersistence.Tests/SlnAssets). The schema is not exhaustive; for example, the reader also supports the `Id` and `DefaultStartup` attributes described in [Projects](#projects).

## See also

- [Solution (.sln) file](solution-dot-sln-file.md)
- [Solution user options (.suo) file](solution-user-options-dot-suo-file.md)
- [Solutions](solutions-overview.md)
- [Create and remove project dependencies](../../ide/how-to-create-and-remove-project-dependencies.md)
