---
title: "Settings and options"
description: "Define, read, write, and monitor extension settings using the VisualStudio.Extensibility settings API."
ms.date: 09/29/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# Settings and options

Define configurable settings that users can change to affect your extension's behavior. Settings integrate automatically with the Visual Studio Unified Settings experience.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete settings registration:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/SettingsSample/SettingDefinitions.cs":::

> [!TIP]
> See the full working sample: [SettingsSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SettingsSample/)

**Related concepts:** [Contributions and configurations](../how-it-works/contributions-and-configurations.md) — how settings are registered as contributions

## Understand the example

### Define a setting

```csharp
internal static class SettingDefinitions
{
    [VisualStudioContribution]
    internal static SettingCategory MyCategory { get; } = new("myCategory", "My Extension")
    {
        GenerateObserverClass = true,
    };

    [VisualStudioContribution]
    internal static Setting.Boolean EnableFeature { get; } = new(
        "enableFeature", "Enable feature", MyCategory, defaultValue: true);

    [VisualStudioContribution]
    internal static Setting.String OutputFormat { get; } = new(
        "outputFormat", "Output format", MyCategory, defaultValue: "json")
    {
        MaxStringLength = 50,
    };
}
```

### Read a setting value

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    var result = await Extensibility.Settings()
        .ReadEffectiveValueAsync(SettingDefinitions.EnableFeature, ct);
    if (!result.Succeeded)
    {
        throw new InvalidOperationException("Could not read EnableFeature.", result.Error);
    }

    bool isEnabled = result.Value;
}
```

`ReadEffectiveValueAsync` returns the configured value, or the setting's declared default if no value has been assigned. A read failure is different: `result.Error` describes it. `ValueOrDefault(fallback)` returns the fallback on a read error, so use it only when that fallback is intentional; check `Succeeded` or use `Value` when failure must be surfaced.

### Monitor settings with an observer

Set `GenerateObserverClass = true` on the category, then register and inject the observer:

```csharp
// In your Extension class:
protected override void InitializeServices(IServiceCollection serviceCollection)
{
    serviceCollection.AddSettingsObservers();
    base.InitializeServices(serviceCollection);
}

// In a command:
private readonly Settings.MyCategoryObserver settingsObserver;

public MyCommand(Settings.MyCategoryObserver settingsObserver)
{
    this.settingsObserver = settingsObserver;
    this.settingsObserver.Changed += this.OnSettingsChangedAsync;
}

private Task OnSettingsChangedAsync(Settings.MyCategorySnapshot snapshot)
{
    if (!snapshot.EnableFeature.Succeeded)
    {
        System.Diagnostics.Trace.TraceError("Could not read EnableFeature: {0}", snapshot.EnableFeature.Error);
        return Task.CompletedTask;
    }

    bool isEnabled = snapshot.EnableFeature.ValueOrDefault(defaultValue: true);
    // React to change
    return Task.CompletedTask;
}

protected override void Dispose(bool isDisposing)
{
    if (isDisposing)
    {
        this.settingsObserver.Changed -= this.OnSettingsChangedAsync;
    }

    base.Dispose(isDisposing);
}
```

The generated observer is in the `Settings` child namespace. Its `Changed` handler runs at least once with the current snapshot, so you don't need a separate initial read. Unsubscribe when the consuming component is disposed; use `GetSnapshotAsync(cancellationToken)` if you only need a one-time snapshot.

### Write settings

```csharp
var writeResult = await Extensibility.Settings().WriteAsync(
    batch =>
    {
        batch.WriteSetting(SettingDefinitions.EnableFeature, value: false);
        batch.WriteSetting(SettingDefinitions.OutputFormat, value: "xml");
    },
    description: "Updated extension settings",
    cancellationToken);

if (writeResult.Result != SettingsWriteResponse.ResultCode.Success)
{
    throw new InvalidOperationException($"Settings were not applied: {writeResult.Result}");
}
```

`PendingApproval` means the write hasn't been applied yet; `ChangeError` means one or more changes failed. Check `ChangeResults` for per-setting failures, and localize the write description shown to users.

### Subscribe to a single setting (without observer)

For cases where you don't need a full observer class, subscribe directly:

```csharp
IDisposable subscription = await Extensibility.Settings().SubscribeAsync(
    SettingDefinitions.EnableFeature,
    cancellationToken,
    changeHandler: result =>
    {
        if (!result.Succeeded)
        {
            System.Diagnostics.Trace.TraceError("Could not read EnableFeature: {0}", result.Error);
            return;
        }

        bool isEnabled = result.Value;
        // React to the change
    });
```

The `SubscribeAsync` handler fires at least once with the current value. Keep the returned `IDisposable` for as long as updates are needed, and dispose it when the owning component is disposed.

### Read multiple settings at once

```csharp
var results = await Extensibility.Settings().ReadEffectiveValuesAsync(
    [SettingDefinitions.EnableFeature, SettingDefinitions.OutputFormat],
    cancellationToken);
bool isEnabled = results.Value(SettingDefinitions.EnableFeature);
```

`Value(setting)` throws if that setting couldn't be read; `results.Succeeded` indicates whether **all** requested settings were read successfully.

### Common setting types

| Type | Use for |
|------|---------|
| `Setting.Boolean` | On/off toggles |
| `Setting.String` | Free-text values |
| `Setting.Integer` | Numeric values |
| `Setting.Decimal` | Floating-point values |
| `Setting.Enum` | Dropdown selection from fixed options |
| `Setting.FormattedString` | Dates, URIs, emails, file paths |
| `Setting.StringArray` | List of strings |
| `Setting.ObjectArray` | Complex structured items |

For example, the [SettingsSample ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/SettingsSample/SettingDefinitions.cs) lets users edit a list of sample words:

```csharp
[VisualStudioContribution]
internal static Setting.StringArray SampleWords { get; } = new(
    "sampleWords", "Sample words", MyCategory, ["Lorem", "ipsum"])
{
    UniqueItems = true,
    AllowAdditions = true,
    AllowRemovals = true,
};
```

For a file path, use a formatted string and the `SettingStringFormat.Path` factory:

```csharp
[VisualStudioContribution]
internal static Setting.FormattedString LogFile { get; } = new(
    "logFile", "Log file", MyCategory,
    SettingStringFormat.Path(SettingPathKind.File),
    defaultValue: "");
```

These definitions belong inside `SettingDefinitions` alongside `MyCategory`. Other formats include `SettingStringFormat.Email()` and `SettingStringFormat.Uri()`.

### Add an action and a live preview to a category

The [SettingsSample category ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/SettingsSample/SettingDefinitions.cs) offers an **Open Sample Text Tool Window** action.

The same category provides a live preview of its sample text:

```csharp
[VisualStudioContribution]
internal static SettingCategory SettingsSampleCategory { get; } = new(
    "settingsSample", "%SettingsSample.Settings.Category.DisplayName%")
{
    GenerateObserverClass = true,
    Actions =
    [
        new("%SettingsSample.Settings.Category.OpenToolWindow%")
        {
            Execute = (setting, context, cancellationToken) =>
                context.Extensibility.Shell().ShowToolWindowAsync<MyToolWindow>(
                    activate: true, cancellationToken),
        },
    ],
    Preview = new()
    {
        Factory = SettingPreviewFactory.Create(SettingsPreviewControl.CreateAsync),
    },
};
```

The `Execute` delegate runs only when the user clicks the action; the action alone would not load the extension just to be displayed. Localize the action title as you would a setting display name.

Selecting the category loads the extension to create its preview. `SettingPreviewFactory.Create` calls `SettingsPreviewControl.CreateAsync`, which returns a [Remote UI](../how-it-works/remote-ui.md) control. The [sample preview control ↗](https://github.com/microsoft/VSExtensibility/blob/preview_18.12/New_Extensibility_Model/Samples/SettingsSample/SettingsPreviewControl.cs) subscribes to `TextLengthSetting` and displays a read-only text preview that updates as the setting changes. It shows an error message if the setting cannot be read and disposes its subscription when the control is disposed. Keep the factory asynchronous and release any subscriptions or other resources when the preview closes.

## Tips

### ✅ DO

- Set `GenerateObserverClass = true` on categories you want to observe
- Check `Succeeded` and `Error` when read failures must be reported; use `ValueOrDefault()` only for an intentional fallback
- Use localized strings (`%key%`) for display names and descriptions
- Batch multiple writes in a single `WriteAsync` call
- Call `serviceCollection.AddSettingsObservers()` in `InitializeServices`

### ❌ DON'T

- Don't change setting monikers (names) after release — they're part of the roaming profile
- Don't read settings in tight loops — use observers for change notification
- Don't keep a subscription after its owner is disposed
- Don't forget `[VisualStudioContribution]` on both categories and settings

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Setting not appearing in UI | Verify `[VisualStudioContribution]` on both category and setting |
| Observer not firing | Ensure `AddSettingsObservers()` is called in `InitializeServices` |
| `ReadEffectiveValueAsync` returns an error | Inspect `result.Error` instead of treating a fallback as a successful read |
| Generated observer class not found | Rebuild after setting `GenerateObserverClass = true`; check namespace (`Settings.MyCategoryObserver`) |

## Next steps

- [External settings providers](external-settings.md) — back settings with your own store
- [Add a command](commands/commands.md) — use settings to control command behavior
- [Dependency injection](../how-it-works/dependency-injection.md) — how observers are injected
- [Localize metadata](../ship/localize-extensions.md) — localize setting display names
