---
title: Upgrade and migrate Visual Studio extensions
description: Learn how to upgrade Visual Studio extensions for Visual Studio 2026 and incrementally migrate from the Visual Studio SDK (VSSDK) to VisualStudio.Extensibility.
ms.date: 10/20/2026
ms.topic: how-to
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Upgrade and migrate Visual Studio extensions

This article covers upgrading an existing extension to Visual Studio 2026 and migrating from the Visual Studio SDK (VSSDK) to the VisualStudio.Extensibility model.

You don't need to change extensibility models just to support a newer Visual Studio version. Test compatibility first, then modernize your build or migrate APIs as needed.

## Upgrade to Visual Studio 2026

Visual Studio 2022 extensions install and run on Visual Studio 2026 with minimal or no changes.

### Install and test

1. Install Visual Studio 2026.
2. Open **Extensions** > **Manage Extensions** and find your extension.
3. Test your extension to verify all features work correctly.

### Breaking changes

Visual Studio 2026 is light on breaking changes:

**Experiences:**

- **Removal of `IntegratedShell` installation target** — Update to `Microsoft.VisualStudio.Community`.
- **Changed frequency of scanning for SDK extensions**
- **Removal of MPF-style VSIX project templates**
- **Removal of Image Library Viewer**

**APIs:**

- **Removal of `IGraphProvider` API** — Use `IAttachedCollectionSourceProvider` instead.
- **Removal of public APIs in `Microsoft.VisualStudio.Text.Internal.dll`**
- **Removal of legacy synchronous Quick Info extensibility** — Use the async Quick Info API.
- **Removal of unused NuGet Visual Studio Extensibility APIs**

If your extension targets `IntegratedShell`, update the manifest:

```xml
<InstallationTarget
  Id="Microsoft.VisualStudio.Community"
  Version="[17.0,)" />
```

For the complete list, see the [breaking changes page ↗](https://github.com/microsoft/VSExtensibility/blob/main/docs/breaking_changes.md) on GitHub.

### Theme color changes

Visual Studio 2026 consolidates theme color tokens, see [Modernize theme colors](modernize-theme-colors.md). Theme migration does not require a new VSIX payload.

## Migrate a VSIX project to the Visual Studio project SDK

To modernize an existing VSSDK project's build setup without changing its extension ID or adopting a different extensibility model, see [Migrate a VSIX project to the Visual Studio project SDK](migrate-vsix-to-project-sdk.md).

## Migrate from VSSDK to VisualStudio.Extensibility

Start by checking whether VisualStudio.Extensibility supports your extension's features. See [Scenarios that require VSSDK](../how-it-works/models/extensibility-models.md#scenarios-that-require-vssdk).

If you still need VSSDK APIs, adopt VisualStudio.Extensibility incrementally in a **hybrid extension**. Both SDKs run in the Visual Studio process and can contribute features from the same VSIX. Follow [Add VisualStudio.Extensibility to an existing VSSDK extension project](../how-it-works/models/in-proc-extensions.md#add-a-visualstudioextensibility-extension-to-an-existing-vssdk-extension-project) for setup and service injection. VSSDK calls retain their threading requirements.

When all required features have VisualStudio.Extensibility equivalents, you can migrate fully **out of process** for process isolation and modern .NET. Use [Create your first extension](../get-started/create-your-first-extension.md) to set up the destination project, port your features, and test behavior before replacing the existing extension.

For the architectural and threading differences, see [Detailed comparison of extensibility models](compare-extensibility-models.md).

## Related content

- [VSSDK users and compatibility](../how-it-works/models/vssdk-and-compatibility.md)
- [Modernize theme colors](modernize-theme-colors.md)
- [In-process extensions](../how-it-works/models/in-proc-extensions.md)
- [Choose your extensibility model](../how-it-works/models/extensibility-models.md)
