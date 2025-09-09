---
title: Use Design Time Data with the XAML Designer
description: Mock data in the XAML Designer in Visual Studio and quickly add design-time data to your pages or controls without the need to create a full mock ViewModel.
ms.date: 09/30/2021
ms.topic: overview
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
monikerRange: ">=vs-2019"
---
# Use Design Time Data with the XAML Designer in Visual Studio

Some layouts are hard to visualize without data. In this document, we'll be reviewing one of the approaches developers working on desktop projects can use to mock data in the XAML designer. This approach is done using the existing Ignorable “d:” namespace. With this approach you can quickly add design-time data to your pages or controls without the need to create a full mock ViewModel, or just test how a property change might affect your application without worrying that these changes will impact your release builds. All d: data is used only by the XAML Designer and no ignorable namespace values are compiled into the application.

> [!NOTE]
> if you are using Xamarin.Forms, see [Xamarin.Forms Design Time Data](/xamarin/xamarin-forms/xaml/xaml-previewer/design-time-data)

## Design Time Data basics

Design-time data is mock data you set to make your controls easier to visualize in the XAML Designer. To get started, add the following lines of code to the header of your XAML document if they aren't already present:

```xml
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
mc:Ignorable="d"
```

After adding the namespaces, you can put `d:` in front of any attribute or control to show it only in the XAML Designer but not at runtime.

For example, you can add text to a TextBlock that usually has data bound to it.

```xml
<TextBlock Text="{Binding Name}" d:Text="Name!" />
```

:::image type="content" alt-text="Design-time data with text in a TextBlock" source="media\xaml-design-time-textblock.png" lightbox="media\xaml-design-time-textblock.png":::

In this example, without `d:Text`, the XAML Designer would show nothing for the TextBlock. Instead, it shows "Name!" where the TextBlock will have real data at runtime.

You can use `d:` with attributes for any UWP or WPF .NET Core control, like colors, font sizes, and spacing. You can even add it to the control itself.

```xml
<d:Button Content="Design Time Button" />
```

:::image type="content" alt-text="Design-time data with a Button control" source="media\xaml-design-time-button.png" lightbox="media\xaml-design-time-button.png":::

In this example, the button only appears at design time. Use this method to put a placeholder in for a custom control or to try out different controls. All `d:` attributes and controls will be ignored during runtime.

## Preview images at design time

You can set a design-time Source for images that are bound to the page or loaded in dynamically. Add the image you want to show in the XAML Designer to your project. You can then show that image in the XAML Designer at design time:

```xml
<Image Source={Binding ProfilePicture} d:Source="DesignTimePicture.jpg" />
```

> [!NOTE]
> The image in this example must exist in the solution.

## Design-time data for ListViews

ListViews are a popular way to display data in your Desktop app. However, they're difficult to visualize without any data. You can use this feature to create an inline design-time data ItemSource or Items. The XAML Designer displays what is in that array in your ListView at design time.

### WPF .NET Core example
To use the system:String type, make sure you include
`xmlns:system="clr-namespace:System;assembly=mscorlib` in your XAML header.

```xml
<StackPanel>
    <ListView ItemsSource="{Binding Items}">
        <d:ListView.ItemsSource>
            <x:Array Type="{x:Type system:String}">
                <system:String>Item One</system:String>
                <system:String>Item Two</system:String>
                <system:String>Item Three</system:String>
            </x:Array>
        </d:ListView.ItemsSource>
    <ListView.ItemTemplate>
        <DataTemplate>
            <TextBlock Text="{Binding ItemName}" d:Text="{Binding .}" />
        </DataTemplate>
    </ListView.ItemTemplate>
   </ListView>
</StackPanel>
```

:::image type="content" alt-text="Design-time data with a ListView" source="media\xaml-design-time-listview-strings.png" lightbox="media\xaml-design-time-listview-strings.png":::

This previous example shows a ListView with three TextBlocks in the XAML Designer.

You can also create an array of data objects. For example, public properties of a `City` data object can be constructed as design-time data.

```csharp
namespace Cities.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
```

To use the class in XAML, you must import the namespace in the root node.

```xaml
xmlns:models="clr-namespace:Cities.Models"
```

```xml
<StackPanel>
    <ListView ItemsSource="{Binding Items}">
        <d:ListView.ItemsSource>
            <x:Array Type="{x:Type models:City}">
                <models:City Name="Seattle" Country="United States"/>
                <models:City Name="London" Country="United Kingdom"/>
                <models:City Name="Panama City" Country="Panama"/>
            </x:Array>
        </d:ListView.ItemsSource>
        <ListView.ItemTemplate>
            <DataTemplate>
                 <StackPanel Orientation="Horizontal" >
                    <TextBlock Text="{Binding Name}" Margin="0,0,5,0" />
                    <TextBlock Text="{Binding Country}" />
                 </StackPanel>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</StackPanel>
```

:::image type="content" alt-text="Actual model in design-time data with a ListView" source="media\xaml-design-time-listview-models.png" lightbox="media\xaml-design-time-listview-models.png":::

The benefit here is that you can bind your controls to a design-time static version of your model.

### UWP example

x:Array is not supported in UWP. Therefore we can use `<d:ListView.Items>` instead. To use the system:String type, make sure you include
`http://schemas.microsoft.com/winfx/2009/xaml` in your XAML header.

```xml
    <StackPanel>
        <ListView>
            <d:ListView.Items>
                <system:String>Item One</system:String>
                <system:String>Item Two</system:String>
                <system:String>Item Three</system:String>
            </d:ListView.Items>
        </ListView>
    </StackPanel>
```

## Use design-time data with custom types and properties

This feature by default works only with platform controls and properties. In this section we go over the steps needed to enable you to use your own custom controls as design-time controls, a new capability available to customers using Visual Studio 2019 version [16.8](/visualstudio/releases/2019/release-notes/) or later. There are three requirements to enable this:

- A custom xmlns namespace

    ```xml
    xmlns:myControls="http://MyCustomControls"
    ```

- A design-time version of your namespace. This can be achieved by simply appending /design at the end.

     ```xml
    xmlns:myDesignTimeControls="http://MyCustomControls/design"
    ```

- Adding your design-time prefix to the mc:Ignorable

    ```xml
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d myDesignTimeControls"
    ```

After you have taken all these steps, you can use your `myDesignTimeControls` prefix to create your design-time controls.

```xml
<myDesignTimeControls:MyButton>I am a design time Button</myDesignTimeControls:MyButton>
```

### Creating a custom xmlns namespace

To create a custom xmlns namespace in WPF .NET Core, you need to map your custom XML namespace to the CLR namespace your controls are in. You can do that by adding the `XmlnsDefinition` assembly-level attribute in your `AssemblyInfo.cs` file. The file is found in the root hierarchy of your project.

   ```csharp
   [assembly: XmlnsDefinition("http://MyCustomControls", "MyViews.MyButtons")]
   ```

## Troubleshooting

If you experience a problem that isn't listed in this section, please let us know by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool.

:::moniker range="vs-2019"

### Requirements

- Design-time data requires Visual Studio 2019 version [16.7](/visualstudio/releases/2019/release-notes-v16.7) or later.

- Supports Windows desktop projects that target Windows Presentation Foundation (WPF) for .NET Core and UWP. This feature is also available for .NET Framework in the [Preview channel](/visualstudio/releases/2019/release-notes-preview). To enable it, go to **Tools** > **Options** > **Environment** > **Preview Features**, select **New WPF XAML Designer for .NET Framework** and then restart Visual Studio.

- Starting with Visual Studio 2019 version 16.7, this feature works with all in-the-box controls from WPF and UWP frameworks. Support for third-party controls is now available in the [16.8 release](/visualstudio/releases/2019/release-notes/).

:::moniker-end

### The XAML Designer stopped working

Try closing and reopening the XAML file, and cleaning and rebuilding your project.

## See also

- [Design Time Data with the Xamarin.Forms Previewer](/xamarin/xamarin-forms/xaml/xaml-previewer/design-time-data)
- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)
- [XAML in .NET MAUI apps](/dotnet/maui/xaml)
