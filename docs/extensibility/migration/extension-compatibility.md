---
title: Extension compatibility model for Visual Studio
description: Learn how API-version-based compatibility keeps VSIX extensions working across Visual Studio 2022 and Visual Studio 2026.
ms.date: 01/09/2026
ms.topic: concept-article
ms.subservice: extensibility-integration
author: tinaschrepfer
ms.author: tinali
---

# Extension compatibility model for Visual Studio

Visual Studio 2026 introduces an API-version-based compatibility model
that reduces the need for extension updates across major releases.
VSIX extensions built for Visual Studio 2022 continue to work in Visual
Studio 2026 without changes when they target supported APIs.

## Overview

Older extensions declared compatibility by specifying Visual Studio
**product version ranges** in the VSIX manifest, usually requiring an
upper-bound change for every new major release. Starting in Visual
Studio 2026, compatibility is driven by **API version support** instead
of product versions, so most Visual Studio 2022 extensions can load in
Visual Studio 2026 without republishing.

## Key principles

- **Extensions declare API versions, not product versions.** At load
  time, Visual Studio evaluates the API versions an extension targets
  and loads only compatible extensions.

  > [!NOTE]
  > The extension API surface includes more than the Visual Studio SDK
  > version. Extensions can reference multiple components (for example,
  > CPS or Roslyn), each with its own versioning scheme. Visual Studio
  > checks compatibility against the APIs available at runtime.

- **Stable APIs avoid breaking changes.** Except for major platform
  shifts (such as the move to 64-bit in Visual Studio 2022), the
  platform aims to preserve backward compatibility for stable APIs.

- **New APIs are additive and preview first.** Preview APIs may change
  or be removed and are not supported for production extensions or
  publishing to the Visual Studio Marketplace.

## Impact on existing extensions

If your VSIX extension works in Visual Studio 2022, no changes are
required for Visual Studio 2026. Visual Studio 2026:

- Supports API version **17.x**.
- Evaluates compatibility using **only the lower bound** of the
  installation target version range.
- Ignores the upper bound of the range.

#### Example

An extension with this installation target runs in both Visual Studio
2022 and Visual Studio 2026:

```xml
<InstallationTarget
  Id="Microsoft.VisualStudio.Community"
  Version="[17.0,18.0)" />
```

### New extensions created in Visual Studio 2026

When you create an extension in Visual Studio 2026, the VSIX manifest is
configured with a lower bound of 17.0 and no upper bound:

```xml
<InstallationTarget
  Id="Microsoft.VisualStudio.Community"
  Version="[17.0,)" />
```

This configuration allows the extension to run on both Visual Studio
2022 and Visual Studio 2026 without modification.

## Testing and troubleshooting

Even if no changes are expected, test your extension on Visual Studio
2026 to catch:

- Behavioral changes.
- Platform issues.
- Unsupported API usage.

If you hit a platform issue, report it with [Report a Problem](../../ide/how-to-report-a-problem-with-visual-studio.md) in
Visual Studio.

## MSI-based extensions

The compatibility model applies only to VSIX extensions. For
MSI-distributed extensions:

- Visual Studio does not manage installation or compatibility.
- You are responsible for adapting the installer for Visual Studio 2026.
- Automatic migration from older Visual Studio versions does not apply.

> [!TIP]
> Prefer VSIX distribution. MSI-based installation is not recommended
> for Visual Studio extensions.

## Related Content

- [Update a Visual Studio extension](./update-visual-studio-extension.md)
- [Visual Studio extensibility documentation](../index.yml)
- [Visual Studio Toolbox video series](/shows/visual-studio-toolbox)
- [Extension samples on GitHub](https://github.com/microsoft/VSSDK-Extensibility-Samples)