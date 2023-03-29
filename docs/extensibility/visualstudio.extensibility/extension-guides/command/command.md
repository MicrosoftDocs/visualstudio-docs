---
title: Commands reference
description: An overview of extensibility commands
date: 2023-2-2
author: ghogen
ms.author: ghogen
ms.technology: vs-ide-sdk
ms.topic: overview
ms.date: 02/02/2023
ms.custom: template-overview
---

# Commands overview

A command represented by the `Command` class is some action that can be initiated by a user, such as when the user chooses a menu item, presses a toolbar button, or types a keyboard shortcut. Commands have a display name, an execution method (`ExecuteCommandAsync`) that performs the action, an icon for display in the toolbar to identify the command, and a tooltip to explain the command to the user. Commands can be enabled or disabled depending on various conditions.

Commands in the new Extensibility Model run asynchronously so the user can continue to interact with the IDE while commands are executing.

## Work with commands

This overview covers these top scenarios for working with commands:

- [Create a command](#create-a-command)
- [Place a command in the IDE](#place-a-command-in-the-ide)
- [Add an icon to a Command](#add-an-icon-to-a-command)
- [Add shortcuts to a command](#shortcuts)
- [Configure a command](#configure-a-command)
- [Change the display name of a command](#change-the-display-name-of-a-command)

## Create a command

Creating a command with the new Extensibility Model begins with extending the base class [`Microsoft.VisualStudio.Extensibility.Commands.Command`](./../../api/Microsoft.VisualStudio.Extensibility.md/#command-type), adorning the class with the `VisualStudioContribution` attribute, and implementing the `CommandConfiguration` property.

```csharp
[VisualStudioContribution]
public class MyCommand : Command
{
  /// <inheritdoc />
  public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%");
}
```

### CommandConfiguration class

The [`CommandConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#commandconfiguration-type) class has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| DisplayName | String | Yes | The default display name of your command. Surround this string with the '%' character to enable localizing this string. See more on this at [Localize metadata](localize-metadata.md). |
| TooltipText | String | No | The text to display as the tooltip when the command is hovered or focused. Surround this string with the '%' character to enable localizing this string. See more on this at [Localize metadata](localize-metadata.md) |
| Flags | CommandFlags | No | Flags to set additional properties on the command. Some options include CanToggle and CanSelect. See more on this at [Command Flags](#command-flags). |
| Placements | CommandPlacement[] | No | Specifies the existing groups within Visual Studio that the Command will be parented to. See more on this at [Place a command in the IDE](#place-a-command-in-the-ide). Even without a placement, your command will still be available via the Visual Studio Search feature. Commands can also be placed onto [Menus, Toolbars, and Groups](menus-and-toolbars.md) defined in your extension. |
| Icon | CommandIconConfiguration | No | Commands can be displayed in the UI as either just an Icon, an Icon with text, or just text. This property configures what that icon should be, if any, and how it should be displayed. |
| Shortcuts | CommandShortcutConfiguration[] | No | Defines the set of key combinations that can be used to execute the command. Shortcuts can be scoped down to only be applicable to specific IDE contexts. See more on this at [Shortcuts](#shortcuts). |
| ClientContexts[] | String | No | Client contexts requested by the command. By default the Shell and Editor contexts are returned. A client context is a snapshot of specific IDE states at the time a command was originally executed. Since these commands are executed asynchronously this state could change between the time the user executed the command and the command handler running. See more on this at [Client contexts](./../../inside-the-sdk/activation-constraints.md/#client-contexts). |
| Priority | uint | No | Describes the display order of the command relative to other commands parented to the same `CommandPlacement.KnownPlacements`. |

### Example

The `Command` also needs a constructor that takes the `VisualStudioExtensibility` object (which allows communication with the IDE), and an execution method `ExecuteCommandAsync`. The following example provides a minimal implementation of a generic command that doesn't do anything:

```csharp
[VisualStudioContribution]
public class MyCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%");

    public MyCommand(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
```

## Place a command in the IDE

There are a set of well-defined places in Visual Studio where commands can be placed. These placements are defined by the property `KnownPlacements` on the class `Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement`. The current set of `KnownPlacements` are:

- `ToolsMenu` - The command will be placed in a group under the top-level "Tools" menu in Visual Studio.
- `ViewOtherWindowsMenu` - The command will be placed in a group under the top-level "View" -> "Other Windows" menu in Visual Studio.
- `ExtensionsMenu` - The command will be placed in a group under the top-level "Extensions" menu in Visual Studio.

Commands parented to the same placement are sorted based on their `Priority` property, relative to other commands or menus with the same placement.

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    Placements = new CommandPlacement[]
    {
        CommandPlacement.KnownPlacements.ToolsMenu
    },
};
```

## Add an icon to a command

Commands support adding icons to their menu item, either in addition to or instead of the display name of the command. To add an icon to your command, set the `Icon` property on your command's [`Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#CommandConfiguration-type).

### CommandIconConfiguration

The [`CommandIconConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#CommandIconConfiguration-type) has two parameters:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| IconName | ImageMoniker | Yes | You can either use a custom moniker for an image that you added following the [Adding custom images](#use-a-custom-image-for-the-command-icon) section or reference a Visual Studio [ImageMoniker](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#ImageMoniker-type) like `ImageMonikers.KnownValues.AddItem` |
| IconSettings | IconSettings | Yes | Configures how the command will be displayed. For example `IconSettings.IconAndText` displays the icon alongside the command's display name, whereas `IconSettings.IconOnly` will only show the command's icon and not its DisplayName if parented to a toolbar. |

### ImageMoniker.KnownValues Example

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    Icon = new CommandIconConfiguration(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
};
```

### Use a custom image for the command icon

You can add custom images, which you can then reference with custom monikers by following these steps:

1. Rename the image source files to follow the `%Custom Moniker%.*` pattern (for example, `MyImage.1.png`). Files prefixed with the same moniker will all be used as backing sources for the same custom moniker. Different source will be used based on the requested icon size.
    - For example, `MyImage.16.16.png` (a 16\*16 png), `MyImage.20.20.png` (a 20\*20 png) and `MyImage.xaml` are all considered as sources for `MyImage`.
    - When the requested icon size is 16*16, `MyImage.16.16.png` will be used, when requested size is 20\*20, `MyImage.20.20.png` will be used, in all other cases, `MyImage.xaml` will be used.
2. Put all of the image source files under `Images` folder.
    - The default image assets folder is `Images`, but you can also customized it by adding `<ImageAssetsPath>%YourFolder%</ImageAssetsPath>`
  
### ImageMoniker.Custom Example

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    Icon = new CommandIconConfiguration(ImageMoniker.Custom("MyImage"), IconSettings.IconAndText),
};
```

## Shortcuts

Commands can be configured to be executed when a specific key combination is used. A Shortcut consists of one or two chords, where each chord consists of a `Microsoft.VisualStudio.Extensibility.Commands.ModifierKey` and one `Microsoft.VisualStudio.Extensibility.Commands.Key`. Possible values for `ModifierKey` are `LeftAlt`, `Shift`, `Control`, `ControlShift`, `ControlShiftLeftAlt`, and `None`, where `None` is only valid when used in the second chord of a Shortcut. The same `ModifierKey` does not need to be used for both chords in a Shortcut. The `Key` used in a chord can be almost any other keyboard key.

Many keyboard shortcuts are already used in Visual Studio. You should not assign the same shortcut to more than one command because duplicate bindings are hard to detect and may also cause unpredictable results. Therefore, it is a good idea to verify the availability of a shortcut before you assign it.

### Shortcut Activation Constraint

An activation constraint can be included in the configuration to have the Shortcut available in different contexts. These activation constraints are defined in the form of a `Guid`, and usually relate to an editor. When a Shortcut is given an activation constraint it will only be available in that specific context. For example, use the `Guid` "{5EFC7975-14BC-11CF-9B2B-00AA00573819}" to make the Shortcut available in the Visual Studio editor. In this case the Shortcut would only be available when the Visual Studio editor is focused.

### Shortcut Sample

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    Shortcuts = new CommandShortcutConfiguration[]
    {
        new(ModifierKey.LeftAlt, Key.M),
        new(ModifierKey.ControlShift, Key.Y, ModifierKey.ControlShift, Key.B),
    },
};
```

## Configure a command

You can configure visibility and the enabled/disabled state of a command, and set additional metadata using flags.

### Visibility

The visibility of a command can be controlled by setting the `VisibleWhen` property on your command's [`Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#CommandConfiguration-type).

The attribute supports specifying a condition through a number of individual parameters that together specify the condition and all its logic and inputs. To specify the condition, you specify an expression in one parameter, define a set of terms (strings) used in the expression in another parameter, and what values those terms should be replaced with upon evaluation in a third parameter. The combination of the expression, terms, and values is called a *rule-based activation constraint* and is fully described at [Rule-based activation constraints](../../inside-the-sdk/activation-constraints.md/#rule-based-activation-constraints).

If this property is omitted from your configuration, the default is for the command to always be visible.

### Visibility Example

```csharp
public override CommandConfiguration CommandConfiguration => new("My command")
{
    VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.(jpg|jpeg|txt)$"),
};
```

### Enabled/disabled state

The enabled/disabled state of a command can be controlled by setting the `EnabledWhen` property on your command's [`Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#CommandConfiguration-type).

This type of configuration is called a *rule-based activation constraint* and is fully described at [Using rule based activation constraints](../../inside-the-sdk/activation-constraints.md/#rule-based-activation-constraints).

If this configuration is omitted from your command, the default is for the command to always be enabled. You can also automatically have your command be disabled if it is currently executing by setting `this.DisableDuringExecution = true;` in the constructor of your command class. Setting this property will override the enabled/disabled state defined by the `EnabledWhen` configuration while the command is being executed.

### Enabled/disabled state Example

```csharp
public override CommandConfiguration CommandConfiguration => new("My command")
{
    EnabledWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.(jpg|jpeg|txt)$"),
};
```

For more information on valid term values, see [Rule-based activation constraints](./../../inside-the-sdk/activation-constraints.md/#rule-based-activation-constraints).

### Command flags

Command flags help define additional properties on your commands that are used at runtime to define special behaviors that your command can have. The flags that are currently supported are:

- `CanToggle` - Indicates that the `IsChecked` property of the command can change so that screen readers can announce the command properly. Functionally, it ensures that the automation property `IsTogglePatternAvailable` returns true for the UI element.
- `CanSelect` - Indicates that the `IsChecked` property of the command can change so that screen readers can announce the command properly. Functionally, it ensures that the automation property `IsSelectionPatternAvailable` returns true for the UI element.

## Change the display name of a command

While the display name for a command is initially set in the [`CommandConfiguration`](./../../api/Microsoft.VisualStudio.Extensibility.Contracts.md/#CommandConfiguration-type) (see [Creating a Command](#create-a-command)), it can be changed at runtime by setting the `DisplayName` property in your command. The `ToolTipText` property can be updated in a similar way.

### Change DisplayName Example

```csharp
[VisualStudioContribution]
public class MyCommand : Command
{
    /// <inheritdoc />
    public override CommandConfiguration CommandConfiguration => new("Initial Display Name");

    public MyCommand(VisualStudioExtensibility extensibility)
     : base(extensibility)
    {
    }

    public override Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        // Update the command's Display Name
        this.DisplayName = "Updated Display Name";
        return Task.CompletedTask;
    }
}
```

## Next steps

- Follow the [create the project](../../getting-started/create-your-first-extension.md) section in Getting Started section.
- Explore the documentation for configuring [Menus and Toolbars](menus-and-toolbars.md)
- Next, see the [InsertGuidSample](./../../../../New_Extensibility_Model/Samples/InsertGuid) sample for a more complete look at creating an extension with a command.
- See an example of parenting a command at [CommandParentingSample](./../../../../New_Extensibility_Model/Samples/CommandParentingSample/).
