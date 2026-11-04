---
title: "Extension project anatomy"
description: "Understand the key files, classes, and structure of a VisualStudio.Extensibility extension project."
ms.date: 09/29/2026
ms.topic: concept-article
author: jasonchlus
ms.author: jasonc
---

# Anatomy of an extension

After [creating your first extension](create-your-first-extension.md), let's understand the key parts of the project.

## Project structure

A typical VisualStudio.Extensibility extension project looks like this:

```
MyExtension/
├── MyExtension.csproj
├── ExtensionEntrypoint.cs      ← Extension class (entry point)
├── Commands/
│   └── Command1.cs             ← Command handlers
├── ToolWindows/                ← Tool window definitions
├── .vsextension/
│   └── string-resources.json   ← Localized strings
└── bin/Debug/.vsextension/
    └── extension.json          ← Generated build output (metadata)
```

## The Extension class

Every extension has one class that inherits from `Extension`. This is your entry point:

```csharp
[VisualStudioContribution]
internal class ExtensionEntrypoint : Extension
{
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
            id: "MyExtension.abc123",
            version: this.ExtensionAssemblyVersion,
            publisherName: "My Company",
            displayName: "My Extension"),
    };
}
```

The `[VisualStudioContribution]` attribute tells Visual Studio this class exists and should be loaded.

## Commands

Commands are the most common contribution. Each command is a class:

```csharp
[VisualStudioContribution]
internal class MyCommand : Command
{
    public override CommandConfiguration CommandConfiguration => new("My Command")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
    {
        // Your logic here
    }
}
```

## Key concepts

| Concept | What it does |
|---------|--------------|
| `[VisualStudioContribution]` | Registers a class as a VS contribution (command, tool window, etc.) |
| `CommandConfiguration` | Declares where a command appears, its icon, and visibility rules |
| `IClientContext` | Provides access to the current IDE state when a command executes |
| `Extensibility` property | Access to VS services (shell, editor, documents) |
| `Extension` class | The entry point that defines metadata for your extension |

## How it connects

```
Visual Studio                       Your Extension (separate process)
┌─────────────────────┐             ┌─────────────────────────────┐
│                     │  ← JSON →   │ ExtensionEntrypoint         │
│ Loads               │             │                             │
│ extension.json      │ ← Commands →│ MyCommand.ExecuteCommandAsync()│
│                     │             │                             │
│ Menu click ─────────│────────────>│                             │
│                     │             │                             │
│ Tool window <───────│─────────────│ RemoteUserControl           │
│                     │  ← UI →    │ (XAML + ViewModel)          │
└─────────────────────┘             └─────────────────────────────┘
```

Your extension runs in its own process. Visual Studio communicates with it via JSON-RPC. This isolates extension process crashes, though extension bugs can still affect the IDE.

## Next steps

- [Add a command](../recipes/commands/commands.md) — the most common extension feature
- [Tool windows](../recipes/tool-windows.md) — add custom UI
- [Activation constraints](../how-it-works/activation-constraints.md) — control when your extension is active
- [Dependency injection](../how-it-works/dependency-injection.md) — how services are provided

## Related content

- [Extension models compared](../how-it-works/models/extensibility-models.md)
- [Out-of-process architecture](../how-it-works/inside-the-sdk.md)
