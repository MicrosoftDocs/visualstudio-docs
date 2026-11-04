---
title: "What is Visual Studio extensibility?"
description: "Learn about extending Visual Studio with custom commands, tool windows, editor features, and more using the VisualStudio.Extensibility SDK."
ms.date: 09/29/2026
ms.topic: overview
author: jasonchlus
ms.author: jasonc
---

# What is Visual Studio extensibility?

Visual Studio is designed to be extended. You can add commands, tool windows, editor features, language support, debugger visualizers, and much more — customizing the IDE to fit your workflow or sharing your tools with the community.

## How extensions work

Extensions are packaged as VSIX files and installed into Visual Studio. They integrate with the IDE through well-defined APIs that let you:

- **Add commands** to menus, toolbars, and context menus
- **Create tool windows** with custom UI for specialized workflows
- **Extend the editor** with margins, CodeLens, taggers, and syntax highlighting
- **Provide language support** via the Language Server Protocol (LSP)
- **Add debugger visualizers** for complex data types
- **Integrate with the project system** to query and modify solutions
- **Display prompts and dialogs** for user interaction
- **Write to the output window and status bar** for notifications

## The VisualStudio.Extensibility SDK

The **VisualStudio.Extensibility** SDK is the recommended way to build extensions. It runs your extension in a separate process from Visual Studio, which means:

| Benefit | What it means |
|---------|---------------|
| **Reliability** | Out-of-process hosting reduces the risk of extension failures bringing down Visual Studio |
| **Performance** | Heavy work runs outside the IDE process, helping preserve responsiveness |
| **Simplicity** | Modern .NET APIs with dependency injection |
| **Hot-loading** | Install and load your extension without restarting VS |

Extensions built with this SDK target modern .NET and use familiar patterns like async/await and dependency injection.

## When you need more

Some advanced editor features (IntelliSense, light bulb actions, custom editors) aren't yet available out of process. For these, you can build **hybrid extensions** that combine VisualStudio.Extensibility with traditional in-process VSSDK components. See [In-process (hybrid) extensions](../how-it-works/models/in-proc-extensions.md) for details.

## Experimental APIs and breaking changes

Most APIs in the VisualStudio.Extensibility SDK are stable starting with the 17.9 release. A few newer APIs are explicitly labeled with the `[Experimental]` attribute while they mature based on user feedback.

For more information, including how to use experimental APIs, see the [Experimental APIs ↗](https://github.com/microsoft/VSExtensibility/blob/main/docs/experimental_apis.md) documentation. Breaking changes are communicated in advance on the [breaking changes ↗](https://github.com/microsoft/VSExtensibility/blob/main/docs/breaking_changes.md) page.

## API reference

- [Microsoft.VisualStudio.Extensibility ↗](/dotnet/api/microsoft.visualstudio.extensibility)
- [Microsoft.VisualStudio.Extensibility.Editor ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor)
- [Microsoft.VisualStudio.ProjectSystem.Query ↗](/dotnet/api/microsoft.visualstudio.projectsystem.query)

## Next steps

- [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) — decide which model fits your scenario
- [Install the tools](../get-started/install-tools.md) — set up your development environment
- [Create your first extension](../get-started/create-your-first-extension.md) — build something in 5 minutes
