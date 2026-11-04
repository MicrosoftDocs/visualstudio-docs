---
title: VSSDK users and extension compatibility
description: Learn how the VisualStudio.Extensibility model differs from the Visual Studio SDK (VSSDK) and how the API-version compatibility model works across VS versions.
ms.date: 09/29/2026
ms.topic: concept-article
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# VSSDK users and extension compatibility

If you have experience building Visual Studio extensions with the Visual Studio SDK (VSSDK), this article helps you understand how VisualStudio.Extensibility differs and how the extension compatibility model works across Visual Studio versions.

## Why a new model?

The VSSDK comes with inherent challenges:

- **Extension crashes affect Visual Studio** — In-process extensions can crash or hang VS.
- **Threading complexity** — Many APIs require the UI thread, leading to deadlocks.
- **Restart required** — Installing or updating extensions requires restarting VS.
- **.NET Framework only** — Extensions can't use .NET 6+ or modern .NET features.
- **API complexity** — COM, DTE, MEF, and `.vsct` files in a single extension.

VisualStudio.Extensibility addresses these with out-of-process execution, fully async APIs, .NET support, and a consistent programming model.

## Architecture

Extensions run out-of-process by default in a separate ServiceHub process communicating via RPC:

- **Isolation** — Out-of-process extension crashes are less likely to bring down Visual Studio.
- **.NET support** — Modern .NET runtimes.
- **True async** — All APIs genuinely asynchronous, no thread switching.
- **Hot-loading** — Extensions load during development without restarting VS.

## In-process bridge

If your extension requires VSSDK APIs without VisualStudio.Extensibility equivalents, run in-process while using the new APIs:

- Access VSSDK services via `MefInjection<T>` and `AsyncServiceProviderInjection<T>`
- Use DTE, MEF components via dependency injection
- Incrementally migrate features

For details, see [In-process extensions](in-proc-extensions.md).

## Extension compatibility model

Visual Studio 2026 introduces an API-version-based compatibility model that reduces the need for extension updates across major releases.

### Key principles

- **Extensions declare API versions, not product versions.** VS evaluates API versions at load time.
- **Stable APIs avoid breaking changes.** Backward compatibility is preserved except for major platform shifts.
- **New APIs are additive and preview first.** Preview APIs may change and are not supported for Marketplace publishing.

### Impact on existing extensions

If your VSIX extension works in Visual Studio 2022, no changes are required for Visual Studio 2026:

- Supports API versions **17.x** and **18.x**.
- Evaluates compatibility using **only the lower bound** of the installation target.
- Ignores the upper bound of the range.

```xml
<!-- This works in both VS 2022 and VS 2026 -->
<InstallationTarget
  Id="Microsoft.VisualStudio.Community"
  Version="[17.0,18.0)" />
```

> [!NOTE]
> Because Visual Studio 2026 ignores the upper bound, there is currently no supported way to restrict an extension to Visual Studio 2022 only using the manifest version range.

### New extensions in Visual Studio 2026

```xml
<InstallationTarget
  Id="Microsoft.VisualStudio.Community"
  Version="[17.0,)" />
```

### MSI-based extensions

The compatibility model applies only to VSIX extensions. For MSI-distributed extensions, you are responsible for adapting the installer for VS 2026.

> [!TIP]
> Adopt VSIX for distribution whenever possible.

## Related content

- [Upgrade and migrate](../../advanced/upgrade-and-migrate.md)
- [In-process extensions](in-proc-extensions.md)
- [Choose your extensibility model](extensibility-models.md)
- [VSIX Cookbook ↗](https://www.vsixcookbook.com/)
