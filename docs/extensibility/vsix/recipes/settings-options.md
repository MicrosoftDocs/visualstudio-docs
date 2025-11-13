---
title: Settings & options
description: A recipe for how to handle custom settings and options.
ms.date: 12/01/2021
ms.topic: article
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Custom settings and options in Visual Studio extensions

Storing and retrieving settings is a must-have for many extensions. Let's explore how to work with settings with these goals in mind:

* A simple way to provide custom options.
* Expose the options in the **Tools > Options** dialog.
* Thread-safe way to access and modify the settings.
* Both synchronous and asynchronous support.
* No need to load the package for the settings to initialize.

The following video shows you ho to add options to an extension.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=5e1d8c37-2f54-4ab1-82e1-a66d075064fd]

Here's what it should look like in the **Tools > Options** dialog.

## Add an Options page
Right-click your project and select **Add > New Item...** to show the available templates. Then select the **Extensibility** category on the left side and then **Options Page (Community)** template. In the **name** field below, write **General**.

:::image type="content" source="../media/add-new-item-options.png" alt-text="Adding an options page from the Add New Item dialog.":::

This will create */Options/General.cs* in the root of the project.

:::image type="content" source="../media/options-folder.png" alt-text="The Options Page C# file added to the project.":::

Here's the content of the General.cs file:

```csharp
internal partial class OptionsProvider
{
    // Register the options with these attributes on your package class:
    // [ProvideOptionPage(typeof(OptionsProvider.GeneralOptions), "MyExtension", "General", 0, 0, true)]
    // [ProvideProfile(typeof(OptionsProvider.GeneralOptions), "MyExtension", "General", 0, 0, true)]
    public class GeneralOptions : BaseOptionPage<General> { }
}

public class General : BaseOptionModel<General>
{
    [Category("My category")]
    [DisplayName("My Option")]
    [Description("An informative description.")]
    [DefaultValue(true)]
    public bool MyOption { get; set; } = true;
}
```

It's short and simple and we'll go over the details. But first, we must register the Options page.

## Register the Options page
In a code comment in the *General.cs* file are instructions how to register the Options page.

All we have to do is to copy those two attributes into our Package class. That might look something like this:

```csharp
[ProvideOptionPage(typeof(OptionsProvider.GeneralOptions), "MyExtension", "General", 0, 0, true)]
[ProvideProfile(typeof(OptionsProvider.GeneralOptions), "MyExtension", "General", 0, 0, true)]
public sealed class OptionsPackage : ToolkitPackage
{
    ...
}
```

Running the extension, we should now see the **MyExtension/General** options page showing up in the **Tools > Options** dialog.

:::image type="content" source="../media/tools-options.png" alt-text="Custom options page registered.":::

The two attributes are very similar but handles different scenarios.

The `ProvideOptionsPage` attribute is what makes the Options page show up in the **Tools > Options** dialog. You can omit this attribute if you don't want the options page visible to your users.

`ProvideProfile` registers the options on the roaming profile, which means the individual settings will roam with the user's account across instances and installs of Visual Studio. It also enables the import/export settings feature of Visual Studio. This attribute is optional.

## The individual options
In the General.cs file, you can see how individual options are nothing more than simple C# properties decorated with attributes.

```csharp
    [Category("My category")]
    [DisplayName("My Option")]
    [Description("An informative description.")]
    [DefaultValue(true)]
    public bool MyOption { get; set; } = true;
```

Simple data types such as `string`, `bool`, `int`, are all supported out of the box and that covers most use cases. For other data types we must use type converters. Some are built in to Visual Studio, such as the `EnumConverter`.

Consider this enum:

```csharp
public enum Numbers
{
    First,
    Second,
    Third,
}
```

We can expose those values as options in a dropdown by declaring the `TypeConverter` like so:

```csharp
[Category("My category")]
[DisplayName("My Enum")]
[Description("Select the value you want from the list.")]
[DefaultValue(Numbers.First)]
[TypeConverter(typeof(EnumConverter))]
public Numbers MyEnum { get; set; } = Numbers.First;
```

:::image type="content" source="../media/tools-options-enum.png" alt-text="Dropdown with enum values on the options page.":::

## Reading and writing options
Now that you've registered the options to let your users change their values, it's time to read those values to use in our extension.

You can work with settings from both synchronous and asynchronous contexts. Let's start with the synchronous:

```csharp
// read settings
var number = General.Instance.MyEnum;

// write settings
General.Instance.MyEnum = Numbers.Second;
General.Instance.Save();
```

The API for reading and writing to the settings are very simple and straight forward.

When working in an asynchronous context, the API looks very similar.

```csharp
// read settings
var general = await General.GetLiveInstanceAsync();
var number = general.MyEnum;

// write settings
general.MyEnum = Numbers.Second;
await general.SaveAsync();
```

## Events
When the settings are saved, the static event `General.Saved` is fired. You can subscribe to that event like any other event in .NET and it looks like this:

```csharp
General.Saved += OnSettingsSaved;

...

private void OnSettingsSaved(object sender, General e)
{
   
}
```

## Get the source code
You can find the source code for this extension in the [samples repository](https://github.com/VsixCommunity/Samples).

## Related content
Read the docs for all the details surrounding these scenarios, but notice that while they do provide more detailed documentation, they don't follow the best practices outlined in this sample. They also don't use the Community Toolkit that makes working with settings so much easier.

* [Creating an Options Page](../../creating-an-options-page.md)
* [Using the Settings Store](../../using-the-settings-store.md)
* [Writing to the User Settings Store](../../writing-to-the-user-settings-store.md)
