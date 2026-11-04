---
title: "Tool windows"
description: "Create custom tool windows with data-bound UI in Visual Studio using the VisualStudio.Extensibility SDK."
ms.date: 05/04/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# Tool windows

Create a dockable tool window with data-bound UI using Remote UI and the VisualStudio.Extensibility SDK.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete implementation:

The tool window definition:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/ToolWindowSample/MyToolWindow.cs":::

The command to open the tool window:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/ToolWindowSample/MyToolWindowCommand.cs":::

> [!TIP]
> See the full working sample: [ToolWindowSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ToolWindowSample)

**Related concepts:** [Remote UI](../how-it-works/remote-ui.md) — the data-binding model used for tool window content, [Contributions and configurations](../how-it-works/contributions-and-configurations.md) — how tool window contributions are declared

## Understand the example

### Step 1: Define the tool window class

Extend `ToolWindow` and mark it with `[VisualStudioContribution]`:

```csharp
[VisualStudioContribution]
internal class MyToolWindow : ToolWindow
{
    private MyDataModel? dataModel;

    public MyToolWindow(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
        Title = "My Tool Window";
    }

    public override ToolWindowConfiguration ToolWindowConfiguration => new()
    {
        Placement = ToolWindowPlacement.DocumentWell,
        AllowAutoCreation = true,
    };

    public override async Task InitializeAsync(CancellationToken cancellationToken)
    {
        dataModel = new MyDataModel();
        await dataModel.LoadAsync(cancellationToken);
    }

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new MyToolWindowControl(dataModel!));
    }
}
```

### Step 2: Create the data model

Use `NotifyPropertyChangedObject` with `[DataContract]` and `[DataMember]` for Remote UI data binding:

```csharp
[DataContract]
internal class MyDataModel : NotifyPropertyChangedObject
{
    private string message = "Hello from the tool window!";

    [DataMember]
    public string Message
    {
        get => message;
        set => SetProperty(ref message, value);
    }

    public async Task LoadAsync(CancellationToken cancellationToken)
    {
        // Load data asynchronously
    }
}
```

### Step 3: Create the Remote UI control

Add a `RemoteUserControl` class and a matching XAML data template.

*MyToolWindowControl.cs*:

```csharp
internal class MyToolWindowControl : RemoteUserControl
{
    public MyToolWindowControl(MyDataModel dataModel)
        : base(dataContext: dataModel)
    {
    }
}
```

*MyToolWindowControl.xaml* — set build action to **EmbeddedResource** (not Page):

```xml
<DataTemplate xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
              xmlns:vs="http://schemas.microsoft.com/visualstudio/extensibility/2022/xaml">
    <StackPanel Margin="10">
        <TextBlock Text="{Binding Message}" FontSize="14" />
    </StackPanel>
</DataTemplate>
```

> [!IMPORTANT]
> The XAML file **must** use the `EmbeddedResource` build action. Setting it to `Page` will cause the tool window to render empty.

### Step 4: Add a command to show the tool window

```csharp
[VisualStudioContribution]
internal class ShowMyToolWindowCommand : Command
{
    public ShowMyToolWindowCommand(VisualStudioExtensibility extensibility)
        : base(extensibility)
    {
    }

    public override CommandConfiguration CommandConfiguration => new("My Tool Window")
    {
        Placements = [CommandPlacement.KnownPlacements.ViewOtherWindowsMenu],
        Icon = new(ImageMoniker.KnownValues.ToolWindow, IconSettings.IconAndText),
    };

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        await Extensibility.Shell().ShowToolWindowAsync<MyToolWindow>(activate: true, cancellationToken);
    }
}
```

### Step 5 (optional): Add a toolbar

Define a toolbar and reference it in `ToolWindowConfiguration`:

```csharp
[VisualStudioContribution]
public static ToolbarConfiguration MyToolbar => new("%MyToolbar.DisplayName%")
{
    Children = [
        ToolbarChild.Command<RefreshCommand>(),
        ToolbarChild.Separator,
        ToolbarChild.Command<ClearCommand>(),
    ],
};

public override ToolWindowConfiguration ToolWindowConfiguration => new()
{
    Placement = ToolWindowPlacement.DocumentWell,
    Toolbar = new(MyToolbar),
};
```

## Tips

### ✅ DO

- Mark XAML files as **EmbeddedResource** build action (not Page).
- Use `[DataContract]` and `[DataMember]` on ViewModel properties for Remote UI.
- Use `NotifyPropertyChangedObject` as base for data models.
- Initialize data in `InitializeAsync()`, create UI in `GetContentAsync()`.
- Use `ShowToolWindowAsync<T>(activate: true)` to show from commands.

### ❌ DON'T

- Don't use WPF directly — Remote UI is required for out-of-process extensions.
- Don't set XAML build action to `Page` (the tool window will not render).
- Don't create expensive resources in the constructor — use `InitializeAsync`.

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Tool window is empty | Verify XAML build action is `EmbeddedResource` |
| Data binding doesn't update | Ensure ViewModel inherits `NotifyPropertyChangedObject` and properties have `[DataMember]` |
| Window doesn't appear | Check command calls `ShowToolWindowAsync` correctly |
| Toolbar not showing | Verify `ToolWindowConfiguration.Toolbar` is set |

## Next steps

- [Remote UI overview](../how-it-works/remote-ui.md) — understand the rendering model
- [Add a command](commands/commands.md) — to open the tool window
- [Themes and colors](themes-colors-fonts.md) — style your UI
