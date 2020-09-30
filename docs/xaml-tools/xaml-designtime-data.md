---
title: Use Design Time Data with the XAML Designer in Visual Studio
ms.date: 09/29/2020
ms.topic: overview
author: alihamie
ms.author: tglee
manager: jillfra
monikerRange: vs-2019
---

# Use Design Time Data with the XAML Designer in Visual Studio

Some layouts are hard to visualize without data. Use these tips to make the most out of previewing your data-heavy pages in the XAML Designer.

## Design time data basics

Design time data is mock data you set to make your controls easier to visualize in the XAML Designer. To get started, add the following lines of code to the header of your XAML document if they aren't already present:

```xaml
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
mc:Ignorable="d"
```

After adding the namespaces, you can put `d:` in front of any attribute or control to show it only in the XAML Designer but not at runtime.

For example, you can add text to a TextBlock that usually has data bound to it.

```xaml
<TextBlock Text="{Binding Name}" d:Text="Name!" />
```

[![Design time data with text in a TextBlock](media\xaml-designtime-TextBlock.png "Design time data with text a Label")](media\xaml-designtime-TextBlock.png#lightbox)

In this example, without `d:Text`, the XAML Designer would show nothing for the TextBlock. Instead, it shows "Name!" where the TextBlock will have real data at runtime.

You can use `d:` with attributes for any UWP or WPF .NetCore control, like colors, font sizes, and spacing. You can even add it to the control itself:

```xaml
<d:Button Content="Design Time Button" />
```

[![Design time data with a Button control](media\xaml-designtime-Button.png "Design time data with a Button control")](media\xaml-designtime-Button.png#lightbox)

In this example, the button only appears at design time. Use this method to put a placeholder in for a custom control or to try out different controls. All `d:` attributes and controls will be ignored during runtime.

## Preview images at design time

You can set a design time Source for images that are bound to the page or loaded in dynamically. Add the image you want to show in the XAML Designer to your project. You can then show that image in the XAML Designer at design time:

```xaml
<Image Source={Binding ProfilePicture} d:Source="DesignTimePicture.jpg" />
```

## Design time data for ListViews

ListViews are a popular way to display data in your Desktop app. However, they're difficult to visualize without any data. You can use this feature to create an inline design time data ItemSource. The XAML Designer displays what is in that array in your ListView at design time. This is an example for WPF .NetCore, to use the system:String type make sure you include 
`xmlns:system="clr-namespace:System;assembly=mscorlib` in your XAML header.

```xaml
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

[![Design time data with a ListView](media\xaml-designtime-ListViewStrings.png "Design time data with a ListView")](media\xaml-designtime-ListViewStrings.png#lightbox)

This example shows a ListView with three TextBlocks in the XAML Designer.

You can also create an array of data objects. For example, public properties of a `Monkey` data object can be constructed as design time data:

```csharp
namespace Monkeys.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
```

To use the class in XAML you will need to import the namespace in the root node:

```xaml
xmlns:models="clr-namespace:Monkeys.Models"
```

```xaml
<StackPanel>
    <ListView ItemsSource="{Binding Items}">
        <d:ListView.ItemsSource>
            <x:Array Type="{x:Type models:Monkey}">
                <models:Monkey Name="Baboon" Location="Africa and Asia"/>
                <models:Monkey Name="Capuchin Monkey" Location="Central and South America"/>
                <models:Monkey Name="Blue Monkey" Location="Central and East Africa"/>
            </x:Array>
        </d:ListView.ItemsSource>
        <ListView.ItemTemplate>
            <DataTemplate>
                 <StackPanel Orientation="Horizontal" >
                    <TextBlock Text="{Binding Name}" Margin="0,0,5,0" />
                    <TextBlock Text="{Binding Location}" />
                 </StackPanel>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</StackPanel>
```

[![Actual model in Design time data with a ListView](media\xaml-designtime-ListViewModels.png "Actual model Design time data with a ListView")](media\xaml-designtime-ListViewModels.png#lightbox)

The benefit here is that you can bind your controls to a design time static version of your model.

## Troubleshooting

If you experience a problem that isn't listed in this section, please let us know by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool.

### Requirements

Design time data requires the [16.7 release](/visualstudio/releases/2019/release-notes) of Visual Studio 2019.

### The XAML Designer stopped working

Try closing and reopening the XAML file, and cleaning and rebuilding your project.

## See also

- [Design Time Data with the XAML Designer](/xamarin/xamarin-forms/xaml/xaml-Designer/design-time-data/)
- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)