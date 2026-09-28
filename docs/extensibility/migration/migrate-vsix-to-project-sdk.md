---
title: Migrate a VSIX project to the Visual Studio project SDK
description: Convert a legacy or .NET SDK-style VSIX project to the Visual Studio project SDK while keeping its extension ID.
ms.date: 09/28/2026
ms.topic: how-to
author: matthew-j-clark
ms.author: matclark
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---
# Migrate a VSIX project to the Visual Studio project SDK

You can move an existing managed VSIX project to the top-level `Microsoft.VisualStudio.Sdk.Build` SDK without creating a new extension.
Keep the existing VSIX manifest so installed copies still have the same extension ID.
For a new project, use the [VSIX Project template](../create-vsix-with-project-sdk.md).

## Check the target version

The current project SDK supports `vs17_14` (Visual Studio 2022 17.14) and `vs18_11` (Visual Studio 18.11).
Both targets use .NET Framework 4.8 for in-process or hybrid extensions.
Out-of-process `VisualStudio.Extensibility` extensions use .NET 8 or .NET 10 for Windows, respectively, and can have only one target per project.
If your extension must support an earlier Visual Studio version, check compatibility before changing the target.
Moving an older in-process extension from .NET Framework 4.7.2 to either Visual Studio target also moves it to .NET Framework 4.8.

Choose an exact published version of [Microsoft.VisualStudio.Sdk.Build](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk.Build/) that supports your target.
Pin it in `global.json` or the project's `Sdk` attribute as described in [Specify the project SDK version](../create-vsix-with-project-sdk.md#specify-the-project-sdk-version).

## Convert a non-SDK-style project

Older C# VSIX projects use `ToolsVersion`, `TargetFrameworkVersion`, explicit source-file includes, and imports such as `Microsoft.CSharp.targets` and `Microsoft.VsSDK.targets`.
Replace that project header and those imports with the top-level SDK.
For an in-process extension targeting Visual Studio 2022, start with:

```xml
<Project Sdk="Microsoft.VisualStudio.Sdk.Build">
  <PropertyGroup>
    <TargetFrameworks>vs17_14</TargetFrameworks>
    <ExtensionType>VSSDK</ExtensionType>
    <GeneratePkgDefFile>true</GeneratePkgDefFile>
    <AssemblyName>MyExtension</AssemblyName>
    <RootNamespace>MyExtension</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <Content Include="license.txt" />
  </ItemGroup>
</Project>
```

Use `vs18_11` to target Visual Studio 18.11.
Choose `ExtensionType=VisualStudio.Extensibility` or `VSSDK+VisualStudio.Extensibility` only if the extension uses those APIs.
Bring over project-specific build settings, referenced projects, resources, and VSIX assets.
Remove the old MSBuild XML namespace, `ToolsVersion`, `VSToolsPath`, `TargetFrameworkVersion`, legacy project flavor GUIDs, and explicit .NET and VSSDK target imports.

Review the items and references before building:

- The .NET SDK includes C# files and common framework references by default. Remove duplicate `Compile Include` entries. If you retain `Properties\AssemblyInfo.cs`, set `GenerateAssemblyInfo` to `false` or move its attributes to project properties to avoid duplicate assembly attributes.
- Convert any remaining [`packages.config` dependencies to `PackageReference`](/nuget/consume-packages/migrate-packages-config-to-package-reference). The project SDK supplies `Microsoft.VisualStudio.SDK` and `Microsoft.VSSDK.BuildTools` for a VSSDK extension; remove duplicate references but keep other dependencies. It also supplies the corresponding VisualStudio.Extensibility packages when `ExtensionType` uses that model. If you need explicit package versions, use `EnableDefaultVSSDKPackageReferences` or `EnableDefaultVSExtensibilityPackageReferences` to disable the relevant defaults.
- The SDK includes `.vsct` files as `VSCTCompile` with `Menus.ctmenu` as the default resource name. Remove an explicit `VSCTCompile Include` for the same file. To keep different metadata, use `VSCTCompile Update`, for example `<VSCTCompile Update="Commands.vsct" ResourceName="CustomMenus.ctmenu" />`.
- The existing `source.extension.vsixmanifest` is included as a default `None` item. Remove a duplicate `None Include` entry, or use `None Update` to keep its metadata. Keep explicit `Content` items needed in the VSIX; those items are packaged by default, but the SDK doesn't mark files as `Content` automatically.
- When `GeneratePkgDefFile` is `true`, `UseCodeBase` and `CopyBuildOutputToOutputDirectory` default to `true`. Remove old explicit `true` values only when other configurations don't override them. Keep any explicit `false` values and settings specific to your extension.

## Convert a .NET SDK-style VSIX project

If the project uses `<Project Sdk="Microsoft.NET.Sdk">`, replace its `Sdk` attribute with `Microsoft.VisualStudio.Sdk.Build`.
If it imports `Microsoft.NET.Sdk` props and targets explicitly, replace those imports with the top-level `Sdk` attribute instead.
Remove an explicit `Microsoft.VSSDK.targets` import if present; the project SDK provides the VSSDK build targets.
Set `TargetFrameworks` to `vs17_14` or `vs18_11` and set `ExtensionType` to match the extension.
Remove package and `.vsct` references now provided by the project SDK, but keep custom metadata and other project settings.
Use the same [SDK versioning](../create-vsix-with-project-sdk.md#specify-the-project-sdk-version) and VSIX checks as for a non-SDK-style project.

## Preserve and verify the extension

For an existing VSSDK or hybrid VSIX, keep `source.extension.vsixmanifest`, especially its ID, publisher, and asset declarations.
Check hard-coded installation target and prerequisite ranges against the selected Visual Studio version; changing `TargetFrameworks` does not rewrite those ranges.
Review architecture and runtime requirements, then restore and build.
Inspect the VSIX for the expected `.pkgdef`, command table, referenced assemblies, and content.
Increment the manifest version for a published update, then test that it upgrades the installed extension in each supported Visual Studio version instead of appearing as a separate extension.

## See also

- [Create a VSIX project with the Visual Studio project SDK](../create-vsix-with-project-sdk.md)
- [Upgrade your Visual Studio extension](update-visual-studio-extension.md)
- [VisualStudio.Extensibility SDK](../visualstudio.extensibility/index.yml)
