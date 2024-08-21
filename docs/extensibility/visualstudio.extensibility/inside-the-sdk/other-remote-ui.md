---
title: Other Remote UI concepts
description: Additional topics related to working with the remote UI model.
ms.topic: conceptual
ms.date: 8/9/2024
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Other Remote UI concepts

This article expands on the foundational concepts covered in the introductory [Remote UI](remote-ui.md) tutorial and explores the following additional topics:

- How to create a [context menu](#context-menus).
- How to show [images](#images).

## Context menus

You can add a context menu to a Remote UI control from XAML (Extensible Application Markup Language) by assigning the `FrameworkElement`'s [ContextMenu](/dotnet/api/system.windows.frameworkelement.contextmenu) property. This process mirrors the way you'd add a context menu in standard WPF (Windows Presentation Foundation).

```xml
<TextBox Text="Some text">
    <TextBox.ContextMenu>
      <ContextMenu Style="{DynamicResource {x:Static styles:VsResourceKeys.ContextMenuStyleKey}}">
        <MenuItem Header="Do something" Command="{Binding FirstCommand}" />
        <MenuItem Header="Do something else" Command="{Binding SecondCommand}">
          <MenuItem.Icon>
            <vs:Image Source="KnownMonikers.ClearWindowContent" />
          </MenuItem.Icon>
        </MenuItem>
      </ContextMenu>
    </TextBox.ContextMenu>
</TextBox>
```

In the previous sample, the `vs:Image` control is used to add an image to the context menu item's header (more details in the [images section that follows](#images)). Ensure you reference the `vs` and `styles` namespaces in the XAML file:

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vs="http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml"
              xmlns:styles="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
              xmlns:colors="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.15.0">
```

The command for each menu item is bound to an `AsyncCommand` (for more information, see the [Remote UI tutorial](remote-ui.md)):

```cs
[DataContract]
internal class MyToolWindowData : NotifyPropertyChangedObject
{
    public MyToolWindowData()
    {
        FirstCommand = new(async (commandParameter, cancellationToken) => ...);
        SecondCommand = new(async (commandParameter, cancellationToken) => ...);
    }

    [DataMember]
    public IAsyncCommand FirstCommand { get; }

    [DataMember]
    public IAsyncCommand SecondCommand { get; }
}
```

## Images

You can use Remote UI XAML to show either custom images or images from the Visual Studio image catalog.

The following sample demonstrates how you can show the `ClearWindowContent` image provided by the Visual Studio image catalog. It also details the addition of a custom image to the extension project (a file named `Images\MyCustomImage.16.16.png`). For more information on adding images to an extension, see the [Commands article](../command/command.md#add-an-icon-to-a-command).

```xml
<StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
    <Border>
        <vs:Image Source="KnownMonikers.ClearWindowContent" />
    </Border>
    <Border>
        <vs:Image Source="MyCustomImage" />
    </Border>
</StackPanel>
```

As always, be sure to reference the `vs` and `styles` namespaces in the XAML file:

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vs="http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml"
              xmlns:styles="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
              xmlns:colors="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.15.0">
```

You could also data bind the `Source` property to either a string or an `ImageMoniker`:

```xml
<StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
    <Border BorderThickness="2" BorderBrush="Red" Margin="2">
        <vs:Image Source="{Binding StringImage}" />
    </Border>
    <Border BorderThickness="2" BorderBrush="Red" Margin="2">
        <vs:Image Source="{Binding StringImageFromCatalog}" />
    </Border>
    <Border BorderThickness="2" BorderBrush="Red" Margin="2">
        <vs:Image Source="{Binding MonikerImage}" />
    </Border>
    <Border BorderThickness="2" BorderBrush="Red" Margin="2">
        <vs:Image Source="{Binding MonikerImageFromCatalog}" />
    </Border>
</StackPanel>
```

The corresponding data context would be:

```cs
[DataContract]
internal class MyToolWindowData
{
    [DataMember]
    public string StringImage { get; } = "MyCustomImage";

    [DataMember]
    public string StringImageFromCatalog { get; } = "KnownMonikers.ClearWindowContent";

    [DataMember]
    public ImageMoniker MonikerImage { get; } = ImageMoniker.Custom("MyCustomImage");

    [DataMember]
    public ImageMoniker MonikerImageFromCatalog { get; } = ImageMoniker.KnownValues.ClearWindowContent;
}
```

## Related content

For Remote UI basics, see the [Remote UI tutorial](remote-ui.md). For more advanced scenarios, see [Advanced Remote UI concepts](advanced-remote-ui.md).
