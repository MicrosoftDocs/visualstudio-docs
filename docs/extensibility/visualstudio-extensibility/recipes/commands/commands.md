---
title: "Add a command"
description: "Add commands to Visual Studio menus and toolbars using the VisualStudio.Extensibility SDK."
ms.date: 09/29/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# Add a command

Commands let users trigger actions from menus, toolbars, and keyboard shortcuts in Visual Studio. This guide shows you how to create, place, and configure commands using the VisualStudio.Extensibility SDK.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete implementations:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/SimpleRemoteCommandSample/CommandHandler.cs":::

> [!TIP]
> Surround display names with `%` characters (for example, `%MyCommand.DisplayName%`) to enable localization via a `string-resources.json` file. See [Localize your extension](../../ship/localize-extensions.md).

For command parenting (placing commands in context menus using VSCT GUIDs):

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/CommandParentingSample/SampleCommand.cs":::

> [!TIP]
> See the full working samples: [SimpleRemoteCommandSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SimpleRemoteCommandSample/) and [CommandParentingSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandParentingSample/)

**Related concepts:** [Contributions and configurations](../../how-it-works/contributions-and-configurations.md) — how `[VisualStudioContribution]` and command configurations work

## Understand the example

**What you'll build:** A command that appears in the **Tools** menu with an icon and executes asynchronous logic when invoked.

### Step 1: Create the command class

Extend the `Command` base class and apply the `[VisualStudioContribution]` attribute:

```csharp
[VisualStudioContribution]
internal class MyCommand : Command
{
    public override CommandConfiguration CommandConfiguration => new("Do Something")
    {
        Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
        Icon = new(ImageMoniker.KnownValues.Run, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
    {
        // Your command logic here
        await DoWorkAsync(ct);
    }
}
```

### Step 2: Place the command

Use `CommandPlacement.KnownPlacements` to position your command in standard menus:

```csharp
Placements = [
    CommandPlacement.KnownPlacements.ToolsMenu,
    CommandPlacement.KnownPlacements.ExtensionsMenu.WithPriority(0x0100),
],
```

To place in a VSCT-defined group, use `CommandPlacement.VsctParent`:

```csharp
Placements = [
    CommandPlacement.VsctParent(
        new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"),
        id: 0x016B,
        priority: 0x0801),
],
```

### Step 3: Add an icon

Use a built-in image moniker or a custom image:

```csharp
// Built-in icon
Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),

// Custom icon (place image files in the Images/ folder)
Icon = new(ImageMoniker.Custom("MyImage"), IconSettings.IconOnly),
```

### Step 4: Control visibility and enabled state

Use `ActivationConstraint` to show or enable the command conditionally:

```csharp
public override CommandConfiguration CommandConfiguration => new("My Command")
{
    Placements = [CommandPlacement.KnownPlacements.ToolsMenu],
    VisibleWhen = ActivationConstraint.ClientContext(
        ClientContextKey.Shell.ActiveSelectionFileName, @"\.(cs|vb)$"),
    EnabledWhen = ActivationConstraint.ClientContext(
        ClientContextKey.Shell.ActiveSelectionFileName, @"\.cs$"),
};
```

You can also disable a command while it's running:

```csharp
public MyCommand(VisualStudioExtensibility extensibility) : base(extensibility)
{
    DisableDuringExecution = true;
}
```

### Step 5: Add keyboard shortcuts

```csharp
Shortcuts = [
    new(ModifierKey.LeftAlt, Key.M),
    new(ModifierKey.ControlShift, Key.Y, ModifierKey.ControlShift, Key.B),
],
```

### Step 6: Change display name at runtime

Update `DisplayName` or `TooltipText` from within `ExecuteCommandAsync`:

```csharp
public override Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    this.DisplayName = "Updated Name";
    return Task.CompletedTask;
}
```

### Step 7: Use command flags

Set `Flags` for toggle or selection behavior (enables proper screen reader announcements):

```csharp
Flags = CommandFlags.CanToggle,
```

## Tips

### ✅ DO

- Always include at least one `CommandPlacement` so the command is visible in the IDE.
- Use `ActivationConstraint` for visibility and enabled-state rules.
- Use `CancellationToken` in `ExecuteCommandAsync` and pass it to async calls.
- Use `ImageMoniker.KnownValues` for built-in icons.

### ❌ DON'T

- Don't create commands without placements — they won't appear in menus (only in Search).
- Don't block the command execution thread with synchronous work.
- Don't ignore `CancellationToken` — users expect to cancel long-running commands.

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Command doesn't appear | Check the `Placements` array; verify the `VisibleWhen` constraint is satisfied. |
| Command is grayed out | Check `EnabledWhen` constraint; ensure the activation context is met. |
| Icon not showing | Use `IconSettings.IconAndText` or `IconSettings.IconOnly`; verify image files are in the `Images/` folder. |
| Shortcut doesn't work | Verify the key combination isn't already bound; check shortcut activation constraint scope. |

## Next steps

- [Menus and toolbars](menus-and-toolbars.md) — create custom menus, toolbars, and groups.
- [Localize command metadata](../../ship/localize-extensions.md) — localize display names and tooltips.
- [Tool windows](../tool-windows.md) — open a tool window from your command.
- [Activation constraints](../../how-it-works/activation-constraints.md) — full reference for visibility rules.
