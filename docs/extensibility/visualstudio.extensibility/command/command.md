---
title: Commands reference
description: An overview of extensibility commands
author: ghogen
ms.author: ghogen
monikerRange: ">=vs-2022"
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
ms.topic: overview
ms.date: 02/02/2023
---

# Add Visual Studio commands

A command represented by the [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) class is some action that can be initiated by a user, such as when the user chooses a menu item, presses a toolbar button, or types a keyboard shortcut. Commands have a display name, an execution method ([`ExecuteCommandAsync`](/dotnet/api/microsoft.visualstudio.extensibility.commands.dynamiccommand.executecommandasync)) that performs the action, an icon for display in the toolbar to identify the command, and a tooltip to explain the command to the user. Commands can be enabled or disabled depending on various conditions.

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

Creating a command with the new Extensibility Model begins with extending the base class [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command), adorning the class with the [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute, and implementing the [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration) property.

```csharp
[VisualStudioContribution]
public class MyCommand : Command
{
  /// <inheritdoc />
  public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%");
}
```

### CommandConfiguration class

The [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration) class has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| [`DisplayName`](/dotnet/api/microsoft.visualstudio.extensibility.commands.placeholdercommand.displayname) | String | Yes | The default display name of your command. Surround this string with the '%' character to enable localizing this string. See at [Localize metadata](localize-metadata.md). |
| [`ToolTipText`](/dotnet/api/microsoft.visualstudio.extensibility.commands.placeholdercommand.tooltiptext) | String | No | The text to display as the tooltip when the command is hovered or focused. Surround this string with the '%' character to enable localizing this string. See at [Localize metadata](localize-metadata.md) |
| Flags | CommandFlags | No | Flags to set additional properties on the command. Some options include CanToggle and CanSelect. See at [Command Flags](#command-flags). |
| Placements | CommandPlacement[] | No | Specifies the existing groups within Visual Studio that the Command will be parented to. See at [Place a command in the IDE](#place-a-command-in-the-ide). Even without a placement, your command will still be available via the Visual Studio Search feature. Commands can also be placed onto [Menus, Toolbars, and Groups](menus-and-toolbars.md) defined in your extension. |
| Icon | CommandIconConfiguration | No | Commands can be displayed in the UI as either just an Icon, an Icon with text, or just text. This property configures what that icon should be, if any, and how it should be displayed. |
| Shortcuts | CommandShortcutConfiguration[] | No | Defines the set of key combinations that can be used to execute the command. Shortcuts can be scoped down to only be applicable to specific IDE contexts. See at [Shortcuts](#shortcuts). |
| ClientContexts[] | String | No | Client contexts requested by the command. By default the Shell and Editor contexts are returned. A client context is a snapshot of specific IDE states at the time a command was originally executed. Since these commands are executed asynchronously this state could change between the time the user executed the command and the command handler running. See at [Client contexts](./../inside-the-sdk/activation-constraints.md#client-context-keys). |

### Example

The [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) also needs a constructor that takes the [`VisualStudioExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudioextensibility) object (which allows communication with the IDE), and an execution method [`ExecuteCommandAsync`](/dotnet/api/microsoft.visualstudio.extensibility.commands.dynamiccommand.executecommandasync). The following example provides a minimal implementation of a generic command that doesn't do anything:

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

There's a set of well-defined places in Visual Studio where commands can be placed. These placements are defined by the property [`KnownPlacements`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement.knownplacements) on the class [`CommandPlacement`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement). The current set of `KnownPlacements` is:

- [`ToolsMenu`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement.knownplacements.toolsmenu) - The command will be placed in a group under the top-level "Tools" menu in Visual Studio.
- [`ViewOtherWindowsMenu`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement.knownplacements.viewotherwindowsmenu) - The command will be placed in a group under the top-level "View" -> "Other Windows" menu in Visual Studio.
- [`ExtensionsMenu`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement.knownplacements.extensionsmenu) - The command will be placed in a group under the top-level "Extensions" menu in Visual Studio.

Commands can also be placed using the [`CommandPlacement.VsctParent`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement.vsctparent) method by the specifying the [`Guid`](/dotnet/api/microsoft.visualstudio.extensibility.commands.vsctid.guid) and [`Id`](/dotnet/api/microsoft.visualstudio.extensibility.commands.vsctid.id) of group defined via VSCT.

Commands parented to the same group are sorted based on their placement's [`Priority`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement.priority) property, relative to other commands or menus with the same placement. The default `Priority` value for a [`CommandPlacement`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement) is `0` and can be modified by calling the [`CommandPlacement.WithPriority`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandplacement.withpriority) method, passing in the desired `Priority` value.

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    // The command will be parented to a group inside of the "Tools" top level menu,
    // a group inside of the "Extensions" top level menu, and the "About" group inside of the "Help" top level menu
    Placements = new CommandPlacement[]
    {
        CommandPlacement.KnownPlacements.ToolsMenu,
        CommandPlacement.KnownPlacements.ExtensionsMenu.WithPriority(0x0100),
        CommandPlacement.VsctParent(new Guid("{d309f791-903f-11d0-9efc-00a0c911004f}"), id: 0x016B, priority: 0x0801),
    },
};
```

## Add an icon to a command

Commands support adding icons to their menu item, either in addition to or instead of the display name of the command. To add an icon to your command, set the [`Icon`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.icon) property on your command's [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration).

### CommandIconConfiguration

The [`CommandIconConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandiconconfiguration) has two parameters:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| IconName | ImageMoniker | Yes | You can either use a custom moniker for an image that you added following the [Adding custom images](#use-a-custom-image-for-the-command-icon) section or reference a Visual Studio [ImageMoniker](/dotnet/api/microsoft.visualstudio.extensibility.imagemoniker) like `ImageMonikers.KnownValues.AddItem` |
| IconSettings | IconSettings | Yes | Configures how the command will be displayed. For example [`IconSettings.IconAndText`](/dotnet/api/microsoft.visualstudio.extensibility.commands.iconsettings#microsoft-visualstudio-extensibility-commands-iconsettings-iconandtext) displays the icon alongside the command's display name, whereas [`IconSettings.IconOnly`](/dotnet/api/microsoft.visualstudio.extensibility.commands.iconsettings#microsoft-visualstudio-extensibility-commands-iconsettings-icononly) will only show the command's icon and not its DisplayName if parented to a toolbar. |

### ImageMoniker.KnownValues example

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    Icon = new CommandIconConfiguration(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
};
```

### Use a custom image for the command icon

You can add custom images, which you can then reference with custom monikers by following these steps:

1. Rename the image source files to follow the `%Custom Moniker%.*` pattern (for example, *MyImage.1.png*). Files prefixed with the same moniker will all be used as backing sources for the same custom moniker. Different source will be used based on the requested icon size.
    - For example, *MyImage.16.16.png* (a 16\*16 png), *MyImage.20.20.png* (a 20\*20 png) and *MyImage.xaml* are all considered as sources for `MyImage`.
    - When the requested icon size is 16*16, *MyImage.16.16.png* will be used, when requested size is 20\*20, *MyImage.20.20.png* will be used, in all other cases, *MyImage.xaml* will be used.
2. Put all of the image source files under `Images` folder.
    - The default image assets folder is `Images`, but you can also customize it by adding `<ImageAssetsPath>%YourFolder%</ImageAssetsPath>`
  
### ImageMoniker.Custom example

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyCommand.DisplayName%")
{
    Icon = new CommandIconConfiguration(ImageMoniker.Custom("MyImage"), IconSettings.IconAndText),
};
```

## Shortcuts

Commands can be configured to be executed when a specific key combination is used. A Shortcut consists of one or two chords, where each chord consists of a [`ModifierKey`](/dotnet/api/microsoft.visualstudio.extensibility.commands.modifierkey) and one [`Key`](/dotnet/api/microsoft.visualstudio.extensibility.commands.key). Possible values for `ModifierKey` are `LeftAlt`, `Shift`, `Control`, `ControlShift`, `ControlShiftLeftAlt`, and `None`, where `None` is only valid when used in the second chord of a shortcut. The same `ModifierKey` doesn't need to be used for both chords in a Shortcut. The `Key` used in a chord can be almost any other keyboard key.

Many keyboard shortcuts are already used in Visual Studio. You shouldn't assign the same shortcut to more than one command because duplicate bindings are hard to detect and may also cause unpredictable results. Therefore, it's a good idea to verify the availability of a shortcut before you assign it.

### Shortcut activation constraint

An activation constraint can be included in the configuration to have the shortcut available in different contexts. These activation constraints are defined in the form of a `Guid`, and usually relate to an editor. When a shortcut is given an activation constraint, it will only be available in that specific context. For example, use the `Guid` "{5EFC7975-14BC-11CF-9B2B-00AA00573819}" to make the shortcut available in the Visual Studio editor. In this case the shortcut would only be available when the Visual Studio editor is focused.

### Shortcut sample

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

The visibility of a command can be controlled by setting the [`VisibleWhen`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.visiblewhen) property on your command's [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration).

The attribute supports specifying a condition through a number of individual parameters that together specify the condition and all its logic and inputs. To specify the condition, you specify an expression in one parameter, define a set of terms (strings) used in the expression in another parameter, and what values those terms should be replaced with upon evaluation in a third parameter. The combination of the expression, terms, and values is called a *rule-based activation constraint* and is fully described at [Rule-based activation constraints](../inside-the-sdk/activation-constraints.md#rule-based-activation-constraints).

If this property is omitted from your configuration, the default is for the command to always be visible.

### Visibility example

```csharp
public override CommandConfiguration CommandConfiguration => new("My command")
{
    VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.(jpg|jpeg|txt)$"),
};
```

### Enabled/disabled state

The enabled/disabled state of a command can be controlled by setting the [`EnabledWhen`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.enabledwhen) property on your command's [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration).

This type of configuration is called a *rule-based activation constraint* and is fully described at [Using rule based activation constraints](../inside-the-sdk/activation-constraints.md#rule-based-activation-constraints).

If this configuration is omitted from your command, the default is for the command to always be enabled. You can also automatically have your command be disabled if it's currently executing by setting `this.DisableDuringExecution = true;` in the constructor of your command class. Setting this property overrides the enabled/disabled state defined by the [`EnabledWhen`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration.enabledwhen) configuration while the command is being executed.

### Enabled/disabled state example

```csharp
public override CommandConfiguration CommandConfiguration => new("My command")
{
    EnabledWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.(jpg|jpeg|txt)$"),
};
```

For more information on valid term values, see [Rule-based activation constraints](./../inside-the-sdk/activation-constraints.md#rule-based-activation-constraints).

### Command flags

Command flags help define additional properties on your commands that are used at runtime to define special behaviors that your command can have. The flags that are currently supported are:

- [`CanToggle`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandflags#microsoft-visualstudio-extensibility-commands-commandflags-cantoggle) - Indicates that the [`IsChecked`](/dotnet/api/microsoft.visualstudio.extensibility.commands.togglecommand.ischecked#microsoft-visualstudio-extensibility-commands-togglecommand-ischecked) property of the command can change so that screen readers can announce the command properly. Functionally, it ensures that the automation property `IsTogglePatternAvailable` returns true for the UI element.
- [`CanSelect`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandflags#microsoft-visualstudio-extensibility-commands-commandflags-canselect) - Indicates that the [`IsChecked`](/dotnet/api/microsoft.visualstudio.extensibility.commands.togglecommand.ischecked#microsoft-visualstudio-extensibility-commands-togglecommand-ischecked) property of the command can change so that screen readers can announce the command properly. Functionally, it ensures that the automation property `IsSelectionPatternAvailable` returns true for the UI element.

## Change the display name of a command

While the display name for a command is initially set in the [`CommandConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.commands.commandconfiguration) (see [Creating a Command](#create-a-command)), it can be changed at runtime by setting the [`DisplayName`](/dotnet/api/microsoft.visualstudio.extensibility.commands.placeholdercommand.displayname) property in your command. The [`ToolTipText`](/dotnet/api/microsoft.visualstudio.extensibility.commands.placeholdercommand.tooltiptext) property can be updated in a similar way.

### Change DisplayName example

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

- Follow the [create the project](../get-started/create-your-first-extension.md) section in Getting Started section.
- Explore the documentation for configuring [Menus and Toolbars](menus-and-toolbars.md)
- Next, see the [InsertGuidSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuid) sample for a more complete look at creating an extension with a command.
- See an example of parenting a command at [CommandParentingSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CommandParentingSample/).
