---
title: "Menus and toolbars"
description: "Place commands in Visual Studio menus and toolbars using VisualStudio.Extensibility."
ms.date: 05/04/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# Menus and toolbars

Place your extension commands in Visual Studio menus, toolbars, and context menus using `CommandPlacement` and configuration objects.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete menu and toolbar configuration:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/CommandParentingSample/ExtensionCommandConfiguration.cs":::

> [!TIP]
> See the full working sample: [CommandParentingSample ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandParentingSample)

**Related concepts:** [Contributions and configurations](../../how-it-works/contributions-and-configurations.md) — how placements, groups, and menu contributions work

## Understand the example

### Place a command in a built-in menu

Use `CommandPlacement.KnownPlacements` to add your command to a standard Visual Studio menu:

```csharp
[VisualStudioContribution]
internal class MyCommand : Command
{
    public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
    {
        Placements =
        [
            CommandPlacement.KnownPlacements.ToolsMenu,
        ],
    };

    public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
```

Available `KnownPlacements` values:

| Placement | Location |
|-----------|----------|
| `ToolsMenu` | **Tools** menu |
| `ViewOtherWindowsMenu` | **View** > **Other Windows** |
| `ExtensionsMenu` | **Extensions** menu |

### Place a command in a context menu

Use `CommandPlacement.VsctParent` with a GUID and group ID to target context menus:

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    Placements =
    [
        // Solution Explorer: file in project context menu
        CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 521, priority: 0),

        // Solution Explorer: project context menu
        CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 518, priority: 0),

        // Solution Explorer: solution context menu
        CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 537, priority: 0),
    ],
};
```

> [!TIP]
> The `priority` parameter controls ordering relative to other items in the same group. Lower values appear first.

### Create a toolbar

Define a `ToolbarConfiguration` as a static property and add commands to its `Children`:

```csharp
internal static class ExtensionCommandConfiguration
{
    [VisualStudioContribution]
    public static ToolbarConfiguration MyToolbar => new("%MyExtension.Toolbar.DisplayName%")
    {
        Children =
        [
            ToolbarChild.Command<MyCommand>(),
        ],
    };
}
```

The toolbar appears under **View** > **Toolbars** and users can toggle its visibility.

### Create a submenu

Define a `MenuConfiguration` and nest it inside a parent menu or group:

```csharp
[VisualStudioContribution]
public static MenuConfiguration MySubMenu => new("My Submenu");

[VisualStudioContribution]
public static MenuConfiguration MyParentMenu => new("My Menu")
{
    Placements =
    [
        CommandPlacement.KnownPlacements.ToolsMenu,
    ],
    Children =
    [
        MenuChild.Command<CommandA>(),
        MenuChild.Separator,
        MenuChild.Menu(MySubMenu),
    ],
};
```

### Group commands with separators

Use `MenuChild.Separator` or inline groups to visually cluster related commands:

```csharp
[VisualStudioContribution]
public static MenuConfiguration MyMenu => new("%MyMenu.DisplayName%")
{
    Children =
    [
        MenuChild.Group(
            GroupChild.Command<NewFileCommand>(),
            GroupChild.Command<OpenFileCommand>()),
        MenuChild.Group(
            GroupChild.Command<SaveCommand>(),
            GroupChild.Command<SaveAllCommand>()),
    ],
};
```

### Add a group to an existing VS menu

Use `CommandGroupConfiguration` with a `GroupPlacement` to inject commands into a built-in menu without defining your own:

```csharp
[VisualStudioContribution]
public static CommandGroupConfiguration MyGroup => new(GroupPlacement.KnownPlacements.ToolsMenu)
{
    Children =
    [
        GroupChild.Command<MyCommand>(),
    ],
};
```

## Tips

### ✅ DO

- Use `KnownPlacements` for standard menus
- Set `priority` to control item order in VSCT-parented groups
- Use `MenuChild.Separator` or inline groups for visual clustering

### ❌ DON'T

- Don't hardcode VSCT GUIDs when a `KnownPlacements` value exists
- Don't provide `Placements` for groups used only as children of your own menu or toolbar
- Don't place the same command in too many locations — it confuses users

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Command not visible? | Ensure the command class has `[VisualStudioContribution]` |
| Menu empty? | Menus with no visible children are hidden automatically |
| Wrong order? | `Priority` only applies to VSCT-parented items, not `Children` arrays |

## Next steps

- [Localize command metadata](../../ship/localize-extensions.md) — localize display names and tooltips
- [Commands overview](commands.md) — full command authoring reference
