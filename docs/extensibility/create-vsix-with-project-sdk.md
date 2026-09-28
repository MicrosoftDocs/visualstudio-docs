---
title: Create a VSIX project with the Visual Studio project SDK
description: Create a Visual Studio extension with the VSIX Project template and the top-level Visual Studio project SDK.
ms.date: 09/28/2026
ms.topic: how-to
author: matthew-j-clark
ms.author: matclark
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---
# Create a VSIX project with the Visual Studio project SDK

The C# **VSIX Project** template uses `Microsoft.VisualStudio.Sdk.Build` as its top-level project SDK by default.
This SDK imports `Microsoft.NET.Sdk` and provides the build tools and package references for a Visual Studio extension.
If you already have a VSIX project, [migrate the existing project](migration/migrate-vsix-to-project-sdk.md) to keep its extension ID and assets.

## Prerequisites

- [Visual Studio with the Visual Studio SDK installed](installing-the-visual-studio-sdk.md).
- The .NET SDK if you use the `dotnet` CLI.

## Create the project

In Visual Studio, search for **VSIX Project** in **Create a new project**.
Choose the target Visual Studio version and extension type, and leave **Use top-level Visual Studio SDK** selected.
For new features supported by the [VisualStudio.Extensibility SDK](visualstudio.extensibility/index.yml), choose the out-of-process extension type.

You can also create the project with the .NET CLI:

```powershell
dotnet new install Microsoft.VisualStudio.Sdk.Templates
dotnet new vsix -n MyExtension
```

The template currently defaults to an in-process `VSSDK` extension targeting Visual Studio (18.11).
Its project file contains `Sdk="Microsoft.VisualStudio.Sdk.Build"`, `TargetFrameworks=vs18_11`, and `ExtensionType=VSSDK`.
To target Visual Studio 2022 (17.14), specify the other template choice:

```powershell
dotnet new vsix -n MyExtension --TargetVSVersionTemplateParameter vs17_14
```

The extension type can be `VSSDK` (in-process), `VisualStudio.Extensibility` (out-of-process), or `VSSDK+VisualStudio.Extensibility` (hybrid).
For a new out-of-process extension, select:

```powershell
dotnet new vsix -n MyExtension --ExtensionTypeTemplateParameter VisualStudio.Extensibility
```

The project SDK maps `vs17_14` and `vs18_11` to .NET Framework 4.8 for in-process and hybrid extensions.
Out-of-process extensions use .NET 8 or .NET 10 for Windows, respectively, and support one Visual Studio target per project.
Run `dotnet new vsix --help` to see the available template options.

> [!NOTE]
> If you need a regular `Microsoft.NET.Sdk` project with explicit package references instead, clear **Use top-level Visual Studio SDK** in Visual Studio or pass `--useTopLevelSdk false` to `dotnet new vsix`.
> The top-level SDK is the default for new extension projects.

## Specify the project SDK version

The template names the project SDK but doesn't pin its version.
Choose an exact published version of [Microsoft.VisualStudio.Sdk.Build](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk.Build/) that supports the selected target, then add it to `global.json` beside your solution:

```json
{
  "msbuild-sdks": {
    "Microsoft.VisualStudio.Sdk.Build": "VERSION"
  }
}
```

Replace `VERSION` with the package version you chose.
If you already have a `global.json`, add the `msbuild-sdks` entry without replacing its other settings.
Alternatively, specify the version on the project element:

```xml
<Project Sdk="Microsoft.VisualStudio.Sdk.Build/VERSION">
```

See [How MSBuild resolves project SDKs](../msbuild/how-to-use-project-sdk.md#how-project-sdks-are-resolved) for details.

## Build and check the VSIX

For VSSDK and hybrid projects, set the extension ID, publisher, supported installation targets, and prerequisites in `source.extension.vsixmanifest`.
The out-of-process template doesn't create this manifest; use the [VisualStudio.Extensibility SDK guidance](visualstudio.extensibility/index.yml) to configure that extension.
Then restore and build the project:

```powershell
dotnet restore MyExtension.csproj
dotnet build MyExtension.csproj
```

Inspect the built VSIX and test it in the targeted Visual Studio version before publishing.
To update an existing VSSDK or hybrid extension rather than create a separate one, keep its manifest ID and increment its version.

## See also

- [Migrate an existing VSIX project](migration/migrate-vsix-to-project-sdk.md)
- [VisualStudio.Extensibility SDK](visualstudio.extensibility/index.yml)
- [Ship Visual Studio extensions](shipping-visual-studio-extensions.md)
