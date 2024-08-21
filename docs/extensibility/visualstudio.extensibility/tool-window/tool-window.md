---
title: Tool Windows overview
description: An overview of extensibility tool windows
ms.topic: overview
ms.date: 3/31/2023
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Create Visual Studio tool windows

Tool windows are a way to add complex UI and interactions to Visual Studio. They typically provide a user-friendly way to interact with various APIs and features. For example, the Solution Explorer tool window provides a tree-based view of the current project/solution/folder and provides simple gestures for the opening, renaming, and creating of files.

Tool windows are single-instance, meaning that only one instance of the Tool Window can be open at a time. When a Tool Window is closed in the IDE, it's visibly hidden and is not fully closed and disposed of like documents.

## Get started

To get started, follow the [create your first extension](./../get-started/create-your-first-extension.md) tutorial.

## Working with Tool Windows

This guide is designed to cover the top user scenarios when working with Tool Windows:

- [Create a tool window](#create-a-tool-window)
- [Add content to a tool window](#add-content-to-a-tool-window)
- [Create a command to show a tool window](#create-a-command-to-show-a-tool-window)
- [Control the visibility of a tool window](#control-the-visibility-of-a-tool-window)

## Create a tool window

Creating a tool window with the new Extensibility Model is as simple as extending the base class [`ToolWindow`](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindow) and adorning your class with the attribute [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute).

```csharp
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
```

### ToolWindow attribute

The [`ToolWindow`](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindow) abstract class requires the implementation of the [`ToolWindowConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowconfiguration) configuration, which has a few properties that you should become familiar with:

| Parameter | Type | Required | Description | Default Value |
| --------- |----- | -------- | ----------- | ------------- |
| [Placement](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowconfiguration.placement#microsoft-visualstudio-extensibility-toolwindows-toolwindowconfiguration-placement) | ToolWindowPlacement | No | The location in Visual Studio where the tool window should be opened the first time. [`ToolWindowPlacement.DockedTo`](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowplacement.dockedto) allows docking the tool window to a GUID matching an old VSIX-style tool window ID. See more about [ToolWindowPlacement](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowplacement). | ToolWindowPlacement.Floating |
| [DockDirection](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowconfiguration.dockdirection#microsoft-visualstudio-extensibility-toolwindows-toolwindowconfiguration-dockdirection) | Dock | No | The direction relative to the placement where the tool window should be docked when opened the first time. See [Dock](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.dock). | Dock.None |
| [AllowAutoCreation](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowconfiguration.allowautocreation#microsoft-visualstudio-extensibility-toolwindows-toolwindowconfiguration-allowautocreation) | Bool | No | Specifies whether or not the tool window can be created automatically. Setting this paramater to false means that tool windows that are open when Visual Studio closes don't automatically restore when Visual Studio is opened again. | `true` |

### Example

```csharp
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
    public MyToolWindow(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
        this.Title = "My Tool Window";
    }

    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.Floating,
        DockDirection = Dock.Right,
        AllowAutoCreation = true,
    };

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        // Create and return a RemoteUserControl
    }
}
```

## Add content to a tool window

Because extensions in VisualStudio.Extensibility might be out-of-process from the IDE, we can't directly use WPF (Windows Presentation Foundation) as a presentation layer for content in Tool Windows. Instead, adding content to a tool window requires creating a [RemoteUserControl](./../inside-the-sdk/remote-ui.md) and the corresponding data template for that control. While there are some simple examples below, we recommend reading the [Remote UI documentation](./../inside-the-sdk/remote-ui.md) when adding tool window content.

```csharp
[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
    public MyToolWindow(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
        this.Title = "My Tool Window";
    }

    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.DocumentWell,
    };

    public override async Task InitializeAsync(CancellationToken cancellationToken)
    {
        // Do any work here that is needed before creating the control.
    }

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new MyToolWindowControl());
    }
}
```

*MyToolWindowControl.cs*: (This is an example file name and should have the same name as the data template file)

```csharp
internal class MyToolWindowControl : RemoteUserControl
{
    public MyToolWindowControl()
        : base(dataContext: null)
    {
    }
}
```

*MyToolWindowControl.xaml*: (This is an example file name and should have the same name as the class that derives from RemoteUserControl)

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vs="http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml">
    <Label></Label>
</DataTemplate>
```

For more information on creating a `RemoteUserControl`, see [Remote UI](./../inside-the-sdk/remote-ui.md).

## Create a command to show a tool window

A common mechanism for showing a tool window is to add a [command](./../command/command.md) that, when invoked, shows the tool window by calling [`ShellExtensibility.ShowToolWindowAsync()`](/dotnet/api/microsoft.visualstudio.extensibility.shell.shellextensibility.showtoolwindowasync).

`ShowToolWindowAsync()` has a boolean parameter, `activate`:

- When `true`, the tool window is both visible in the IDE *and* given focus.
- When `false`, the tool window is visible in the IDE, but may be visible only as a tab in a tab group if other tool windows are active.

### Example

```csharp
[VisualStudioContribution]
public class MyToolWindowCommand : Command
{
    public MyToolWindowCommand(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }
    
    public override CommandConfiguration CommandConfiguration => new("My Tool Window")
    {
        Placements = new[] { CommandPlacement.KnownPlacements.ToolsMenu },
        Icon = new(ImageMoniker.KnownValues.ToolWindow, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await this.Extensibility.Shell().ShowToolWindowAsync<MyToolWindow>(activate: true, cancellationToken);
    }
}
```

See the [Commands](./../command/command.md) docs to learn more about creating and using commands.

## Control the visibility of a tool window

Another way of controlling the visibility of a tool window, besides using commands, is to use rule-based activation constraints. These constraints allow tool windows to automatically open when certain conditions are met, and hidden again when those conditions are no longer applicable.

### ToolWindowVisibleWhenAttribute

The [`VisibleWhen`](/dotnet/api/microsoft.visualstudio.extensibility.toolwindows.toolwindowconfiguration.visiblewhen) attribute has a few parameters that you should become familiar with:

| Parameter | Type | Required | Description |
| --------- |----- | -------- | ----------- |
| Expression | String | Yes | A boolean expression string that, when true, means the context is active and the tool window will show. |
| TermNames | String[] | Yes | The names of the terms used in the expression. |
| TermValues | String[] | Yes | The values of each term. The term values must be in the same order as term names array. |

### Example

```csharp
// The tool window will be shown if the active document is a .cs file, and
// will be hidden if the active document is any any other type of file.
public override ToolWindowConfiguration ToolWindowConfiguration => new()
{
    VisibleWhen = ActivationConstraint.ClientContext(ClientContextKey.Shell.ActiveSelectionFileName, @"\.cs$"),
};
```

For more information on valid term values, see [Rule-based activation constraints](../inside-the-sdk/activation-constraints.md#rule-based-activation-constraints).

## Add a toolbar to a tool window

A toolbar can be added to a tool window. First, define a toolbar as described in the [Menus and Toolbars documentation](../command/menus-and-toolbars.md#create-a-toolbar):

```cs
[VisualStudioContribution]
public static ToolbarConfiguration MyToolbar => new("%MyToolbar.DisplayName%")
{
    Children = [
        ToolbarChild.Command<MyCommand1>(), // Assuming there is a `Command` defined in the extension called `MyCommand1`
        ToolbarChild.Separator,
        ToolbarChild.Command<MyCommand2>(), // Assuming there is a `Command` defined in the extension called `MyCommand2`
    ],
};
```

Then reference the toolbar from the tool window configuration:

```cs
public override ToolWindowConfiguration ToolWindowConfiguration => new()
{
    ...
    Toolbar = new(MyToolbar),
};
```

## Next steps

Be sure to read about how [Remote UI](./../inside-the-sdk/remote-ui.md) works in the VisualStudio.Extensibility framework.

Tool window content is created using WPF, so refer to the [WPF documentation](/dotnet/desktop/wpf/overview/) for guidance.

See the [ToolWindow](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ToolWindowSample) sample for a full example of creating an extension with a tool window.
