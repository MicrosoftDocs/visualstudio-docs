---
title: Work with VSIX projects, templates, and dependencies
description: Learn how to create VSIX projects, use project and item templates, add dependencies, and create extension packs for Visual Studio extensions.
ms.date: 10/20/2026
ms.topic: how-to
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Work with VSIX projects

VSIX projects are the standard way to package Visual Studio extensions for distribution. Whether you're building a VisualStudio.Extensibility extension or a VSSDK-based extension, the output is a `.vsix` file that users install through the Extension Manager or the Visual Studio Marketplace.

> [!IMPORTANT]
> This article covers older VSIX project templates and maintaining existing packaging projects. For new projects in Visual Studio 18.11 or later, use the [Modern VSIX Project Template](create-vsix-with-project-sdk.md), which handles VSIX packaging. These are alternative project workflows, not consecutive steps. Choose based on your development environment and existing project, not just the Visual Studio version your extension targets.

## Create a VSIX project

VSIX project templates are available in the **Create a new project** dialog. Search for "VSIX" to find them:

- **VisualStudio.Extensibility Extension** — For out-of-process extensions using the new extensibility model.
- **VSIX Project** — For VSSDK-based extensions or wrapping multiple extension outputs.
- **VisualStudio.Extensibility Extension with VSSDK Compatibility** — For hybrid extensions using both models.
- **Empty VSIX Project** — A blank VSIX container for packaging existing components.

> [!TIP]
> For new extensions, we recommend Visual Studio 18.11 or later and the [**Modern VSIX Project** template](create-vsix-with-project-sdk.md). Select **VisualStudio.Extensibility (Out-Of-Process)** for features supported by that model; select a VSSDK or hybrid option only when you need in-process APIs. On earlier Visual Studio versions, use the **VisualStudio.Extensibility Extension** template, or the VSSDK-compatible template when you need VSSDK APIs.

## Package extensions in a VSIX project

> [!NOTE]
> The `source.extension.vsixmanifest` file and the steps below apply to **VSSDK and hybrid extensions only**. VisualStudio.Extensibility (out-of-process) extensions generate their metadata from `ExtensionConfiguration.Metadata` in code — no manifest file is needed.

You can package an existing extension or component by wrapping it in a VSIX project:

1. Create a VSIX project using any of the templates above.
2. The `source.extension.vsixmanifest` file opens in the **Manifest Designer**.
3. On the **Assets** tab, select **New** to add components.
4. In the **Type** list, choose the type of asset to add (for example, `Microsoft.VisualStudio.MefComponent`, `Microsoft.VisualStudio.VsPackage`).
5. Set the **Source** to **A project in current solution** and select the project.

The VSIX format supports packaging VSPackages, MEF components, assemblies, project templates, item templates, toolbox controls, and custom extension types.

## Add dependencies to a VSIX package

You can configure your VSIX to require other extensions as dependencies. When a user installs your extension, the installer verifies that all required dependencies are present.

To add a dependency:

1. Open `source.extension.vsixmanifest` in the **Design** view.
2. Go to the **Dependencies** tab and select **New**.
3. Choose **Installed extension** to select a dependency from already-installed extensions, or **File on file system** to reference another VSIX directly.

### Require a specific Visual Studio version

To target a minimum Visual Studio build number, set the `InstallationTarget` version range:

```xml
<Installation>
  <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[17.0,)" />
</Installation>
```

> [!NOTE]
> Starting with Visual Studio 2026, only the lower bound of the version range is evaluated. The upper bound is ignored for compatibility purposes. See [Extension compatibility](../how-it-works/models/vssdk-and-compatibility.md).

## Create an extension pack

An extension pack is a set of extensions that can be installed together. Extension packs let you share your favorite extensions with colleagues or bundle a set of extensions for a scenario.

To create an extension pack:

1. Create a new **VSIX Project**.
2. Right-click the project in **Solution Explorer** and select **Add** > **New Item**.
3. Select the **Extension Pack** template. This adds a `.vsext` file.
4. Edit the `.vsext` file to list the extensions to include:

```json
{
  "id": "MyExtensionPack",
  "name": "My Extension Pack",
  "description": "A curated set of extensions for my team",
  "version": "1.0.0.0",
  "extensions": [
    {
      "vsixId": "41858b2d-ff0b-4a43-80b0-f1b2d6084935",
      "name": "AlignAssignments"
    },
    {
      "vsixId": "42374550-426a-400e-96f9-237682e8dea6",
      "name": "CopyAsHtml"
    }
  ]
}
```

5. Find the `vsixId` on the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/) — open the extension page and select **Copy ID**.
6. Build and publish the project. See [Publish to the Marketplace](publish-to-marketplace.md).

> [!NOTE]
> Extension packs can only install extensions available on the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/) or a [private gallery](../advanced/private-galleries.md).

## Extension architecture overview

Understanding how Visual Studio loads your extension helps you make better packaging and deployment decisions.

### VisualStudio.Extensibility (out-of-process)

Out-of-process extensions run in a separate process from Visual Studio, communicating over a JSON-RPC channel:

```text
┌─────────────────────┐       JSON-RPC        ┌──────────────────────┐
│   Visual Studio     │◄─────────────────────►│  Extension Process   │
│   (DevEnv.exe)      │                        │  (.NET 8+)           │
│                     │                        │                      │
│  ┌───────────────┐  │                        │  ┌────────────────┐  │
│  │ Extension Host│  │                        │  │ Your Extension │  │
│  │ (manages      │  │                        │  │ Code           │  │
│  │  lifecycle)   │  │                        │  └────────────────┘  │
│  └───────────────┘  │                        └──────────────────────┘
└─────────────────────┘
```

**Key characteristics:**
- Extension runs on **modern .NET** (8+)
- Extension process crashes are less likely to bring down Visual Studio
- Install/uninstall **without restarting** VS
- Per-user installation (no admin required)

### VSSDK / Hybrid (in-process)

In-process extensions are loaded directly into the Visual Studio process:

```text
┌──────────────────────────────────────────┐
│   Visual Studio (DevEnv.exe)             │
│                                          │
│  ┌────────────────┐  ┌────────────────┐  │
│  │ VS Core        │  │ Your Extension │  │
│  │ Services       │◄─┤ (.NET Framework│  │
│  │                │  │  or hybrid)    │  │
│  └────────────────┘  └────────────────┘  │
└──────────────────────────────────────────┘
```

**Key characteristics:**
- Full access to all VS APIs and services
- Limited to **.NET Framework** (unless hybrid)
- Extension bugs can affect VS stability
- Requires **VS restart** on install/update

### What's in a .vsix package

A `.vsix` file is a ZIP archive with a standard structure. The contents differ by extension model:

| Component | VisualStudio.Extensibility | VSSDK |
|---|---|---|
| Extension metadata | `ExtensionConfiguration` in code | `source.extension.vsixmanifest` |
| Extension binaries | Your .NET 8+ DLLs | Your .NET Framework DLLs |
| Localization files | `.vsextension/string-resources.json` | `.vsixlangpack` files |
| Content types | `[Content_Types].xml` | `[Content_Types].xml` |
| Package manifest | Auto-generated `extension.vsixmanifest` | Hand-authored `source.extension.vsixmanifest` |

## Related content

- [Publish to the Marketplace](publish-to-marketplace.md)
- [Sign VSIX packages](sign-vsix-packages.md)
