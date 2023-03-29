---
title: Advanced Remote UI concepts
description: A tutorial demonstrating more advanced Remote UI concepts
date: 2022-2-6
---

# Tutorial: Advanced remote UI

In this tutorial, we will go over advanced *Remote UI* concepts by incrementally modifying a tool window that shows a list of random colors:

![Random colors tool window](colors-tool-window.png "Random colors tool window")

You'll learn about:

- How multiple *async commands* executions can run in parallel and how to disable UI elements when a command is running.
- How to bind multiple buttons to the same *async command*.
- How reference types are handled in the *Remote UI* data context and its proxy.
- How to use an *async command* as an event handler.
- How to disable a single button when its *async command*'s callback is executing if multiple buttons are bound to the same command.
- How to use WPF types, like complex brushes, in the *Remote UI* data context.
- How *Remote UI* handles threading.

This tutorial is based on the introductory [*Remote UI*](remote-ui.md) article and expects that you have a working VisualStudio.Extensibility extension including:

1. a `.cs` file for the command which opens the tool window,
1. a `MyToolWindow.cs` file for the `ToolWindow` class,
1. a `MyToolWindowContent.cs` file for the `RemoteUserControl` class,
1. a `MyToolWindowContent.xaml` embedded resource file for the `RemoteUserControl` xaml definition,
1. a `MyToolWindowData.cs` file for the data context of the `RemoteUserControl`.

To start, update `MyToolWindowContent.xaml` to show a list view and a button":

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vs="http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml"
              xmlns:styles="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
              xmlns:colors="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.15.0">
    <Grid x:Name="RootGrid">
        <Grid.Resources>
            <Style TargetType="ListView" BasedOn="{StaticResource {x:Static styles:VsResourceKeys.ThemedDialogListViewStyleKey}}" />
            <Style TargetType="Button" BasedOn="{StaticResource {x:Static styles:VsResourceKeys.ButtonStyleKey}}" />
            <Style TargetType="TextBlock">
                <Setter Property="Foreground" Value="{DynamicResource {x:Static styles:VsBrushes.WindowTextKey}}" />
            </Style>
        </Grid.Resources>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>
        <ListView ItemsSource="{Binding Colors}" HorizontalContentAlignment="Stretch">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <Grid>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="Auto" />
                            <ColumnDefinition Width="Auto" />
                        </Grid.ColumnDefinitions>
                        <TextBlock Text="{Binding ColorText}" />
                        <Rectangle Fill="{Binding Color}" Width="50px" Grid.Column="1" />
                        <Button Content="Remove" Grid.Column="2" />
                    </Grid>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>        
        <Button Content="Add color" Command="{Binding AddColorCommand}" Grid.Row="1" />
    </Grid>
</DataTemplate>
```

Then, update the data context class `MyToolWindowData.cs`:

```CSharp
using Microsoft.VisualStudio.Extensibility.UI;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Media;

namespace MyToolWindowExtension;

[DataContract]
internal class MyToolWindowData
{
    private Random random = new();

    public MyToolWindowData()
    {
        AddColorCommand = new AsyncCommand(async (parameter, cancellationToken) =>
        {
            await Task.Delay(TimeSpan.FromSeconds(2));

            var color = new byte[3];
            random.NextBytes(color);
            Colors.Add(new MyColor(color[0], color[1], color[2]));
        });
    }

    [DataMember]
    public ObservableCollection<MyColor> Colors { get; } = new();

    [DataMember]
    public AsyncCommand AddColorCommand { get; }

    [DataContract]
    public class MyColor
    {
        public MyColor(byte r, byte g, byte b)
        {
            ColorText = Color = $"#{r:X2}{g:X2}{b:X2}";
        }

        [DataMember]
        public string ColorText { get; }

        [DataMember]
        public string Color { get; }
    }
}
```

There are just a few noteworthy things in this code:

1. `MyColor.Color` is a `string` but it is used as a `Brush` when data bound in XAML, this is a capability provided by WPF.
1. The `AddColorCommand` async callback contains a 2 seconds delay to simulate a long-running operation.
1. We use [ObservableCollection\<T\>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1), which is supported by *Remote UI*, to dynamically update the list view.
1. `MyToolWindowData` and `MyColor` don't implement [INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged) because, at the moment, all properties are readonly.

## Handle long-running async commands

One of the most important differences between *Remote UI* and normal WPF is that all operations that involve communication between the UI and the extension are async.

*Async commands* like `AddColorCommand` make this explicit by providing an async callback.

We can notice the effect of this if we click the "Add color" button multiple times in a short time: since each command execution takes 2 seconds, multiple executions will happen in parallel and multiple colors will appear in the list together when the 2 second delay is over. This may give the impression to the user that the "Add color" button is not working.

![Overlapped async command execution](overlapped-async-commands.gif "Overlapped async command execution")

To address this, we will disable the button while the *async command* is executing. The most straightforward way to do this is to simply set `CanExecute` for the command to false:

```CSharp
AddColorCommand = new AsyncCommand(async (parameter, ancellationToken) =>
{
    AddColorCommand!.CanExecute = false;
    try
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        var color = new byte[3];
        random.NextBytes(color);
        Colors.Add(new MyColor(color[0], color[1], color[2]));
    }
    finally
    {
        AddColorCommand.CanExecute = true;
    }
});
```

This solution still has imperfect synchronization since, when the user clicks the button, the command callback is executed asynchronously in the extension, the callback sets `CanExecute` to `false` which is then propagated asynchronously to the proxy data context in the Visual Studio process resulting in the button being disabled. The user could click the button twice in rapid succession before the button is disabled.

A better solution is to leverage the `RunningCommandsCount` property of *async commands*:

```xml
<Button Content="Add color" Command="{Binding AddColorCommand}" IsEnabled="{Binding AddColorCommand.RunningCommandsCount.IsZero}" Grid.Row="1" />
```

`RunningCommandsCount` is a counter of how many concurrent async executions of the command are currently underway. This counter is incremented on the UI thread as soon as the button is clicked, which allows to synchronously disable the button by binding `IsEnabled` to `RunningCommandsCount.IsZero`.

Because all *Remote UI* commands execute asynchronously, the best practice is to always use `RunningCommandsCount.IsZero` to disable controls when appropriate, even if the command is expected to complete quickly.

## *Async commands* and data templates

In this section, you'll implement the "Remove" button which allows the user to delete an entry from the list. We can either create one *async command* for each `MyColor` object or we can have a single *async command* in `MyToolWindowData` and use a parameter to identify which color should be removed. The latter option is a cleaner design, so let's implement that.

1. Update the button XAML in the data template:

```xml
<Button Content="Remove" Grid.Column="2"
        Command="{Binding DataContext.RemoveColorCommand,
            RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type ListView}}}"
        CommandParameter="{Binding}"
        IsEnabled="{Binding DataContext.RemoveColorCommand.RunningCommandsCount.IsZero,
            RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type ListView}}}" />
```

2. Add the corresponding `AsyncCommand` to `MyToolWindowData`:

```CSharp
[DataMember]
public AsyncCommand RemoveColorCommand { get; }
```

3. Set the command's async callback in the constructor of `MyToolWindowData`:

```CSharp
RemoveColorCommand = new AsyncCommand(async (parameter, ancellationToken) =>
{
    await Task.Delay(TimeSpan.FromSeconds(2));

    Colors.Remove((MyColor)parameter!);
});
```

This code uses a `Task.Delay` to simulate a long running *async command* execution.

## Reference types in the data context

In the previous code, a `MyColor` object is received as the parameter of an *async command* and used as parameter of a `List<T>.Remove` call which employs reference equality (since `MyColor` is a rererence type that doesn't override `Equals`) to identify the element to remove. This is possible because, even if the parameter is received from the UI, the exact instance of `MyColor` that is currently part of the data context is received, not a copy.

The processes of

- proxying the data context of a *remote user control*;
- sending `INotifyPropertyChanged` updates from the extension to Visual Studio or vice versa;
- sending observable collection updates from the extension to Visual Studio, or vice versa;
- sending *async command* parameters

all honor the identity of reference type objects. With the exception of strings, reference type objects are never duplicated when transferred back to the extension.

![Remote UI data binding reference types](remote-ui-databinding-references.png "Remote UI data binding reference types")

In the picture above, you can see how every reference type object in the data context (the commands, the collection, each `MyColor` and even the entire data context) is assigned a unique identifier by the *Remote UI* infrastructure. When the user clicks the "Remove" button for the proxy color object *#5*, the unique indentifier (*#5*), not the value of the object, is sent back to the extension. The *Remote UI* infrastructure takes care of retrieving the corresponding `MyColor` object and passing it as parameter to the *async command*'s callback.

## RunningCommandsCount with multiple bindings and event handling

If you test the extension at this point, you'll notice that when one of the "Remove" buttons is clicked, all "Remove" buttons are disabled:

![Async Command with multiple bindings](async-commands-multiple-bindings.gif "Async Command with multiple bindings")

This may be the desired behavior. But, suppose you want only the current button to be disabled and you'll allow the user to queue multiple colors for removal: we cannot use the *async command*'s `RunningCommandsCount` property because we have a single command shared between all the buttons.

We can achieve our goal by attaching a `RunningCommandsCount` property to each button so that we have a separate counter for each color. These features are provided by the `http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml` namespace which allows to consume *Remote UI* types from XAML:

We change the "Remove" button to the following:

```xml
<Button Content="Remove" Grid.Column="2"
        IsEnabled="{Binding Path=(vs:ExtensibilityUICommands.RunningCommandsCount).IsZero, RelativeSource={RelativeSource Self}}">
    <vs:ExtensibilityUICommands.EventHandlers>
        <vs:EventHandlerCollection>
            <vs:EventHandler Event="Click"
                             Command="{Binding DataContext.RemoveColorCommand, ElementName=RootGrid}"
                             CommandParameter="{Binding}"
                             CounterTarget="{Binding RelativeSource={RelativeSource Self}}" />
        </vs:EventHandlerCollection>
    </vs:ExtensibilityUICommands.EventHandlers>
</Button>
```

The `vs:ExtensibilityUICommands.EventHandlers` attached property allows assigning *async commands* to any event (for example, `MouseRightButtonUp`) and can be useful in more advanced scenarios.

`vs:EventHandler` can also have a `CounterTarget`: a `UIElement` to which a `vs:ExtensibilityUICommands.RunningCommandsCount` property should be attached, counting the active executions related to that specific event. Make sure to use parentheses (for example `Path=(vs:ExtensibilityUICommands.RunningCommandsCount).IsZero`) when binding to an attached property.

In this case, we use `vs:EventHandler` to attach to each button its own separate counter of active command executions. By binding `IsEnabled` to the attached property, only that specific button is disabled when the corresponding color is being removed:

![Async Command with targeted RunningCommandsCount](targeted-counter.gif "Async Command with targeted RunningCommandsCount")

## Use WPF types in the data context

Until now, the data context of our *remote user control* has been composed of primitives (numbers, strings, etc.), observable collections and our own classes marked with `DataContract`. It is sometimes useful to include simple WPF types in the data context like complex brushes.

Because a *VisualStudio.Extensibility* extension may not even run in the Visual Studio process, it cannot share WPF objects directly with its UI. The extension may not even have access to WPF types since it can target `netstandard2.0` or `net6.0` (not the `-windows` variant).

*Remote UI* provides the `XamlFragment` type which allows including a XAML definition of a WPF object in the data context of a *remote user control*:

```CSharp
[DataContract]
public class MyColor
{
    public MyColor(byte r, byte g, byte b)
    {
        ColorText = $"#{r:X2}{g:X2}{b:X2}";
        Color = new(@$"<LinearGradientBrush xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                               StartPoint=""0,0"" EndPoint=""1,1"">
                           <GradientStop Color=""Black"" Offset=""0.0"" />
                           <GradientStop Color=""{ColorText}"" Offset=""0.7"" />
                       </LinearGradientBrush>");
    }

    [DataMember]
    public string ColorText { get; }

    [DataMember]
    public XamlFragment Color { get; }
}
```

With the code above, the `Color` property value is converted to a `LinearGradientBrush` object in the data context proxy:
![WPF types in data context](wpf-types-in-data-context.png "WPF types in data context")

## *Remote UI* and threads

*Async command* callbacks (and `INotifyPropertyChanged` callbacks for values updated by the UI through data biding) are raised on random threadpool threads. Callbacks are raised one at a time and won't overlap until the code yields control (using an `await` expression).

This behavior can be changed by passing a [NonConcurrentSynchronizationContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.threading.nonconcurrentsynchronizationcontext) to the `RemoteUserControl` constructor. In that case, the provided synchronization context will be used for all *async command* and `INotifyPropertyChanged` callbacks related to that control.
