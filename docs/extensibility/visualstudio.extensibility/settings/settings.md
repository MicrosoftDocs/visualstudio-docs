---
title: Settings overview
description: An overview of VisualStudio.Extensibility settings
ms.topic: overview
ms.date: 08/09/2024
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# VisualStudio.Extensibility settings

Settings allow an extension author to define values that end users can configure to affect the behavior of the extension.

An extension can read, write, or observe setting values. Settings are organized in a hierarchy of categories and have rich support for documentation and validation.

## Define a setting

To get started, follow the [create your first extension](./../get-started/create-your-first-extension.md) tutorial.

Once you have an extension created, you can add the setting definition to any class in the extension:

```cs
#pragma warning disable VSEXTPREVIEW_SETTINGS // The settings API is currently in preview and marked as experimental

private static class SettingDefinitions
{
    [VisualStudioContribution]
    private static SettingCategory MyCategory { get; } = new("myCategory", "My Category");

    [VisualStudioContribution]
    private static Setting.Boolean MySetting { get; } = new("mySetting", "My Setting", MyCategory, defaultValue: false);
}
```

The code above defines a true/false (boolean) setting named `mySetting` under the `myCategory` category with a default value of false. Note that both the setting and the category have the `VisualStudioContribution` attribute.

As the display names of settings and categories are shown to the user, it's recommended that you use localized strings (refer to the [localization documentation](../command/localize-metadata.md)):

```cs
[VisualStudioContribution]
private static SettingCategory MyCategory { get; } = new("myCategory", "%MyExtension.SettingDefinitions.MyCategory%");

[VisualStudioContribution]
private static Setting.Boolean MySetting { get; } = new("mySetting", "%MyExtension.SettingDefinitions.MySetting%", MyCategory, defaultValue: false);
```

You can also nest categories:

```cs
[VisualStudioContribution]
private static SettingCategory ParentCategory { get; } = new("parentCategory", "Parent Category");

[VisualStudioContribution]
private static SettingCategory ChildCategory { get; } = new("childCategory", "Child Category", ParentCategory);

[VisualStudioContribution]
private static Setting.Boolean MySetting { get; } = new("mySetting", "My Setting", ChildCategory, defaultValue: false);
```

## Read a setting

You can access a setting's value from anywhere in your extension. While it's preferable to continuously monitor setting values, situations may arise where your extension needs the current value for a point-in-time operation. The code below demonstrates how to read the setting defined above from a command's handler.

```cs
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    var result = await Extensibility.Settings().ReadEffectiveValueAsync(SettingDefinitions.MySetting, cancellationToken);
    bool value = result.ValueOrDefault(defaultValue: false);
    ...
}
```

Note that the `ReadEffectiveValueAsync` returns a `SettingValue<>` which represents one of the following:
- the current value of the setting
- the default value declared for the setting, if the setting was never assigned a value
- an error that occurred during while reading.

You'll generally leverage the `ValueOrDefault()` method to either get the retrieved setting value or the fallback value provided to the call.

You may also leverage the `ReadEffectiveValuesAsync` method to read multiple setting with a single call.

```cs
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    var results = await Extensibility.Settings().ReadEffectiveValuesAsync(
        [ExtensionEntrypoint.MySetting1, ExtensionEntrypoint.MySetting2],
        cancellationToken);
    var value = results.ValueOrDefault(ExtensionEntrypoint.MySetting1, defaultValue: false);
    ...
}
```

## Monitor a setting

You can also monitor a setting's value from anywhere in your extension code. As the end user may change the value of a setting at any time, it's best practice to continuously monitor the value instead of reading it:

```cs
IDisposable disposeToEndSubscription =
    await Extensibility.Settings().SubscribeAsync(
        ExtensionEntrypoint.MySetting,
        cancellationToken,
        changeHandler: result =>
        {
            var value = result.ValueOrDefault(defaultValue: false);
            ...
        });
```

The `SubscribeAsync` change handler is guaranteed to always be invoked at least once with the current value of the setting.

## Write a setting

In certain circumstances, the extension may need to change the value of a setting. You can achieve this through a batch write operation which allows updating multiple settings at the same time.

```cs
var writeResult = await Extensibility.Settings().WriteAsync(
    batch =>
    {
        batch.WriteSetting(ExtensionEntrypoint.MySetting1, value: true);
        batch.WriteSetting(ExtensionEntrypoint.MySetting2, value: "foo");
    },
    description: "Updating the settings' value to true and `foo`",
    cancellationToken);
```

The description passed to the `WriteAsync` call should be localized.

## Types of setting values and settings metadata

Settings aren't limited to boolean types. You can define them with multiple types that include:
- `Setting.Boolean`
- `Setting.Decimal` (for floating point values)
- `Setting.Enum` (for multiple options, each represented by a localized string)
- `Setting.FormattedString` (dates, times, IP addresses, emails, URIs, file and directory paths)
- `Setting.Integer`
- `Setting.String`
- `Setting.EnumArray`
- `Setting.FormattedStringArray`
- `Setting.StringArray`
- `Setting.ObjectArray` (a sequence of items, each having multiple typed properties)

Each type allows the definition of appropriate validation rules as well as other metadata, such as documentation to be shown to the end user. This is a sample of a more complete definition for a setting of type string:

```cs
[VisualStudioContribution]
private static Setting.String MyStringSetting { get; } = new(
    "myStringSetting",
    "%MyExtension.SettingDefinitions.MyStringSetting%",
    MyCategory,
    defaultValue: "")
{
    MaxStringLength = 100,
    Description = "%MyExtension.SettingDefinitions.MyStringSetting.Description%",
};
```

This is a sample of the definition of an enum setting:

```cs
[VisualStudioContribution]
private static Setting.Enum MyEnumSetting { get; } = new(
    "myEnumSetting",
    "%MyExtension.SettingDefinitions.MyEnumSetting%",
    MyCategory,
    [
        new("true", "%MyExtension.SettingDefinitions.MyEnumSetting.True%"),
        new("false", "%MyExtension.SettingDefinitions.MyEnumSetting.False%"),
        new("disabled", "%MyExtension.SettingDefinitions.MyEnumSetting.Disabled%"),
    ],
    defaultValue: "disabled")
{
    Description = "%MyExtension.SettingDefinitions.MyEnumSetting.Description%",
};
```

## Related content
More information can be found in the [Settings API documentation](/dotnet/api/microsoft.visualstudio.extensibility.settings).
