---
title: Choose the right Visual Studio extensibility model
description: Compare VisualStudio.Extensibility and the Visual Studio SDK (VSSDK) to choose the right extensibility model for your extension.
author: TinaSchrepfer
ms.author: tinali

ms.date: 10/20/2026
ms.topic: product-comparison
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---
# Choose the right Visual Studio extensibility model

Visual Studio provides two extensibility models: VisualStudio.Extensibility and the Visual Studio SDK (VSSDK). Use this guide to choose the right model for your scenario, or combine both SDKs in a hybrid extension when needed.

## Recommendation

**Start with VisualStudio.Extensibility.** It's the primary recommendation for new extensions because it supports modern .NET, uses an [Out-of-process architecture](../inside-the-sdk.md) for better reliability, and offers the simplest way to get started. If you later need APIs that aren't yet available, you can move to [In-process (hybrid) extensions](in-proc-extensions.md) while keeping VisualStudio.Extensibility as your foundation.

> [!NOTE]
> Don't think of these as "new vs. old" models. They're both valid approaches for different scenarios today.

> [!IMPORTANT]
> If your extension needs to use **modern .NET** (for example, .NET 8 or later), you must use an out-of-process extension. In-process (VSSDK) extensions are limited to .NET Framework. Choose VisualStudio.Extensibility and its [Out-of-process architecture](../inside-the-sdk.md) for full access to the modern .NET ecosystem.

## The models at a glance

| | **VisualStudio.Extensibility (out of process)** | **VSSDK** |
|---|---|---|
| **Runtime** | Modern .NET | .NET Framework |
| **Hosting** | Separate process | Visual Studio process |
| **API patterns** | Asynchronous APIs and code-based configuration | COM, managed services, MEF, and command tables |
| **Scenario coverage** | Growing API surface | Broader access to in-process features |
| **Installation** | Supports installation without restarting Visual Studio | Requires restarting Visual Studio |
| **Visual Studio versions** | Visual Studio 2022 and later | Includes support for Visual Studio 2019 and earlier |

Hybrid extensions use VisualStudio.Extensibility APIs in process alongside VSSDK. They retain the in-process hosting and .NET Framework requirements.

## VisualStudio.Extensibility

VisualStudio.Extensibility is the modern extensibility model where extensions run outside of the main Visual Studio process. This architectural shift enables:

- **Modern .NET** — target .NET 8+ and use the full ecosystem
- **Process isolation** — reduces the risk of extension failures bringing down Visual Studio
- **No-restart installs** — users install extensions without restarting the IDE
- **Simple, consistent APIs** — IntelliSense-driven development with async patterns throughout

If you later need APIs that aren't yet available out-of-process, you can run your extension [in process](in-proc-extensions.md) while still using the VisualStudio.Extensibility API surface.

## VSSDK

[VSSDK ↗](/visualstudio/extensibility/visual-studio-sdk) (Visual Studio SDK) is the model that most extensions on the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/vs) are based on. It's the most complete and the most powerful, but also the most complex to learn and use correctly. Extensions run in the same process as Visual Studio, which means they're limited to .NET Framework and can potentially crash or hang the IDE.

> [!TIP]
> For full VSSDK documentation, including API references, walkthroughs, and samples, see the [Visual Studio SDK documentation ↗](/visualstudio/extensibility/visual-studio-sdk).

> [!NOTE]
> The [Community Toolkit ↗](/visualstudio/extensibility/vsix/visual-studio-community-toolkit) is an optional, community-maintained helper library for VSSDK. It isn't a separate extensibility model and doesn't change VSSDK's runtime, hosting, or threading requirements.

> [!TIP]
> For a technical comparison of the two SDKs — including code examples, threading analysis, and architectural tradeoffs — see [Detailed comparison of extensibility models](../../advanced/compare-extensibility-models.md).

## Common scenarios

### I'm new to Visual Studio extension development

Use **VisualStudio.Extensibility**. It provides the easiest onboarding experience and produces high-quality extensions by default.

### I need APIs that VisualStudio.Extensibility doesn't support yet

Adopt the **hybrid approach** — create a VisualStudio.Extensibility extension that [runs in process](in-proc-extensions.md), giving you access to VSSDK APIs alongside the modern API surface.

### I need to support Visual Studio 2019 and earlier

Use **VSSDK**. VisualStudio.Extensibility only supports Visual Studio 2022 and above.

### I have an existing extension I'd like to migrate

This depends on your version support needs:

- **VS 2022+ only**: Rewrite to VisualStudio.Extensibility, or use [hybrid mode](in-proc-extensions.md) if you need VSSDK APIs that don't have equivalents yet.
- **Multi-version support**: Refactor shared logic into a common library, then create separate VSIX projects for each target (VSSDK for VS 2019, VisualStudio.Extensibility for VS 2022+). See [Migrate from VSSDK](../../advanced/upgrade-and-migrate.md) for a detailed walkthrough.

## Scenarios that require VSSDK

VisualStudio.Extensibility is actively growing, but some scenarios aren't yet supported out-of-process. For these, use the [hybrid approach](in-proc-extensions.md) or pure VSSDK:

| Scenario | VisualStudio.Extensibility | VSSDK / Hybrid |
|---|---|---|
| Commands, menus, toolbars | ✅ | ✅ |
| Tool windows | ✅ | ✅ |
| Editor margins, taggers, CodeLens | ✅ | ✅ |
| Language Server Protocol (LSP) | ✅ | ✅ |
| Debugger visualizers | ✅ | ✅ |
| Settings and options | ✅ | ✅ |
| Custom editors (designer surfaces) | ❌ | ✅ |
| IntelliSense providers | ❌ | ✅ |
| Light bulb actions (code fixes) | ❌ | ✅ |
| Custom project systems | ❌ | ✅ |
| Build system integration | ❌ | ✅ |
| Custom debugger engines | ❌ | ✅ |
| Source control providers | ❌ | ✅ |

> [!TIP]
> If your extension needs a scenario marked ❌ above, create a **hybrid extension** using the "VisualStudio.Extensibility Extension with VSSDK Compatibility" template. This lets you use VisualStudio.Extensibility for supported features while accessing VSSDK APIs in-process for the rest. See [In-process extensions](in-proc-extensions.md) for details.

## Next steps

- [Create your first extension](../../get-started/create-your-first-extension.md) — build something in 5 minutes
- [Install the tools](../../get-started/install-tools.md) — set up your development environment
- [In-process extensions](in-proc-extensions.md) — when you need VSSDK APIs alongside VisualStudio.Extensibility
- [Detailed model comparison](../../advanced/compare-extensibility-models.md) — code examples and threading deep-dive
- [Browse samples on GitHub ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples)
