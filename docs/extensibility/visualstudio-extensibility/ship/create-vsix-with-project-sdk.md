---
title: Modern VSIX Project Template
description: Use Visual Studio's Modern VSIX Project template to create a VSSDK, VisualStudio.Extensibility, or hybrid extension.
ms.date: 10/20/2026
ms.topic: how-to
author: matthew-j-clark
ms.author: matclark
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---
# Modern VSIX Project Template

The C# **Modern VSIX Project** template guides you through creating a VSSDK, VisualStudio.Extensibility, or hybrid extension in Visual Studio.
You can use `Microsoft.VisualStudio.Sdk.Build` as the top-level project SDK (the default) or `Microsoft.NET.Sdk` with explicit package references.
If you already have a VSIX project, [migrate the existing project](../advanced/migrate-vsix-to-project-sdk.md) to keep its extension ID and assets.

Use this guide for new projects in Visual Studio 18.11 or later. The template handles VSIX packaging, so you don't also need to follow the [older VSIX project workflow](vsix-projects.md). That workflow is for earlier development environments or maintaining existing projects; the modern template can still create projects that target Visual Studio 2022 (17.14).

## Prerequisites

- Visual Studio 18.11 or later with the [Visual Studio SDK installed ↗](../../installing-the-visual-studio-sdk.md). The Modern VSIX Project template and project SDK are available starting in 18.11; the wizard can also create projects targeting Visual Studio 2022 (17.14).

## Create the project in Visual Studio

1. Select **File > New > Project**, search for **Modern VSIX Project**, select the template, then select **Next**.
1. Enter a project name and location, then select **Next**.
1. Under **Target VS Version**, choose **Visual Studio 2026 (18.11)** (the default) or **Visual Studio 2022 (17.14)**.
1. Under **Extension Type**, select **VisualStudio.Extensibility (Out-Of-Process)** for new features supported by [VisualStudio.Extensibility](../how-it-works/models/extensibility-models.md). The default is **Visual Studio SDK (VSSDK, In-Process)**; select **Hybrid (VSSDK + VisualStudio.Extensibility, In-Process)** only when you need both models.
1. Keep **Use top-level Visual Studio SDK** selected to use `Microsoft.VisualStudio.Sdk.Build`, or clear it to use `Microsoft.NET.Sdk` with explicit package references. Set **Publisher** and select **Create**.

Select **Extension library** only if the project is a shared library rather than a standalone VSIX.

## Understand the generated project

For example, selecting **VisualStudio.Extensibility (Out-Of-Process)** and **Visual Studio 2026 (18.11)** with the top-level SDK produces a project like this:

```xml
<Project Sdk="Microsoft.VisualStudio.Sdk.Build">
  <PropertyGroup>
    <TargetFrameworks>vs18_11</TargetFrameworks>
    <ExtensionType>VisualStudio.Extensibility</ExtensionType>
    <LangVersion>latest</LangVersion>
  </PropertyGroup>
</Project>
```

With **Use top-level Visual Studio SDK** cleared and the same options selected, the project uses `Sdk="Microsoft.NET.Sdk"` and `TargetFramework=net10.0-windows8.0`, with explicit VSSDK build tools and VisualStudio.Extensibility package references.

> [!NOTE]
> The `Microsoft.NET.Sdk` variant references `Microsoft.VSSDK.BuildTools` and sets `VSSDKBuildToolsAutoSetup` to `true`.
> The package defaults this setting to `false`; setting it to `true` imports the VSSDK build targets and supplies VSIX packaging and debugger defaults for standalone extensions.
> `.pkgdef` generation remains off by default (`GeneratePkgDefFile=false`); set it to `true` if your VSSDK package needs registration.
> `DeployExtension` is deprecated. It controls legacy deployment during a build and defaults to `false`; Visual Studio uses `VsixDeployOnDebug` (which defaults to `true`) when deploying the VSIX for debugging.
> The top-level project SDK imports the build targets itself and doesn't need `VSSDKBuildToolsAutoSetup`.

To inspect the selected SDK and target framework in Visual Studio, right-click the project in **Solution Explorer** and select **Edit Project File**.
For VSSDK and hybrid projects, the template also creates `source.extension.vsixmanifest`; the out-of-process option doesn't create a manifest.

The top-level SDK maps `vs17_14` and `vs18_11` to .NET Framework 4.8 for in-process and hybrid extensions.
Out-of-process extensions use .NET 8 or .NET 10 for Windows, respectively.

## Specify the project SDK version

The top-level SDK option creates a project without a pinned SDK version, as shown in the example.
If you need a fixed [Microsoft.VisualStudio.Sdk.Build ↗](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk.Build/) version across build environments, specify it in `global.json` or the project's `Sdk` attribute.
See [How MSBuild resolves project SDKs ↗](../../../msbuild/how-to-use-project-sdk.md#how-project-sdks-are-resolved) for details.

## Build and test the VSIX in Visual Studio

1. For VSSDK and hybrid projects, open `source.extension.vsixmanifest` and set the extension ID, publisher, supported installation targets, and prerequisites. For out-of-process projects, follow the [VisualStudio.Extensibility getting started guide](../get-started/create-your-first-extension.md) to configure extension metadata instead.
1. Select **Build > Build Solution** to build the VSIX.

Inspect the built VSIX and test it in the targeted Visual Studio version before publishing.
To update an existing VSSDK or hybrid extension rather than create a separate one, keep its manifest ID and increment its version.

## See also

- [Work with VSIX projects](vsix-projects.md)
- [Migrate an existing VSIX project](../advanced/migrate-vsix-to-project-sdk.md)
- [Choose your extensibility model](../how-it-works/models/extensibility-models.md)
