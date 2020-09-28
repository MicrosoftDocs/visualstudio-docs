---
title: Use Design Time Data with the XAML Previewer in Visual Studio
ms.date: 08/05/2020
ms.topic: overview
author: TerryGLee
ms.author: tglee
manager: jillfra
---

# Use Design Time Data with the XAML Previewer in Visual Studio

Some layouts are hard to visualize without data. Use these tips to make the most out of previewing your data-heavy pages in the XAML Previewer.

## Design time data basics

Design time data is fake data you set to make your controls easier to visualize in the XAML Previewer. To get started, add the following lines of code to the header of your XAML page:

```xaml
xmlns:d="http://xamarin.com/schemas/2014/forms/design"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
mc:Ignorable="d"
```

After adding the namespaces, you can put `d:` in front of any attribute or control to show it in the XAML Previewer. Elements with `d:` aren't shown at runtime.

For example, you can add text to a label that usually has data bound to it.

```xaml
<Label Text="{Binding Name}" d:Text="Name!" />
```

[![Design time data with text in a Label](xaml-previewer-images/designtimedata-label-sm.png "Design time data with text a Label")](/xamarin/xamarin-forms/xaml-previewer-images/designtimedata-label-lg.png#lightbox)

In this example, without `d:Text`, the XAML Previewer would show nothing for the label. Instead, it shows "Name!" where the label will have real data at runtime.

You can use `d:` with any attribute for a Xamarin.Forms control, like colors, font sizes, and spacing. You can even add it to the control itself:

```xaml
<d:Button Text="Design Time Button" />
```

[![Design time data with a Button control](/xamarin/xamarin-forms/xaml-previewer-images/designtimedata-controls-sm.png "Design time data with a Button control")](xaml-previewer-images/designtimedata-controls-lg.png#lightbox)

In this example, the button only appears at design time. Use this method to put a placeholder in for a [custom control not supported by the XAML Previewer](/xamarin/xamarin-forms/render-custom-controls/).

## Preview images at design time

You can set a design time Source for images that are bound to the page or loaded in dynamically. In your Android project, add the image you want to show in the XAML Previewer to the **Resources > Drawable** folder. In your iOS project, add the image to the **Resources** folder. You can then show that image in the XAML Previewer at design time:

```xaml
<Image Source={Binding ProfilePicture} d:Source="DesignTimePicture.jpg" />
```

[![Design time data with images](xaml-previewer-images/designtimedata-image-sm.png "Design time data with iamges")](xaml-previewer-images/designtimedata-image-lg.png#lightbox)

## Design time data for ListViews

ListViews are a popular way to display data in a mobile app. However, they're difficult to visualize without real data. To use design time data with them, you have to create a design time array to use as an ItemsSource. The XAML Previewer displays what is in that array in your ListView at design time.

```xaml
<StackLayout>
    <ListView ItemsSource="{Binding Items}">
        <d:ListView.ItemsSource>
            <x:Array Type="{x:Type x:String}">
                <x:String>Item One</x:String>
                <x:String>Item Two</x:String>
                <x:String>Item Three</x:String>
            </x:Array>
        </d:ListView.ItemsSource>
        <ListView.ItemTemplate>
            <DataTemplate>
                <TextCell Text="{Binding ItemName}"
                          d:Text="{Binding .}" />
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</StackLayout>
```

[![Design time data with a ListView](xaml-previewer-images/designtimedata-itemssource-sm.png "Design time data with a ListView")](xaml-previewer-images/designtimedata-itemssource-lg.png#lightbox)

This example will show a ListView of three TextCells in the XAML Previewer. You can change `x:String` to an existing data model in your project.

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
<StackLayout>
    <ListView ItemsSource="{Binding Items}">
        <d:ListView.ItemsSource>
            <x:Array Type="{x:Type models:Monkey}">
                <models:Monkey Name="Baboon" Location="Africa and Asia"/>
                <models:Monkey Name="Capuchin Monkey" Location="Central and South America"/>
                <models:Monkey Name="Blue Monkey" Location="Central and East Africa"/>
            </x:Array>
        </d:ListView.ItemsSource>
        <ListView.ItemTemplate>
            <DataTemplate x:DataType="models:Monkey">
                <TextCell Text="{Binding Name}"
                          Detail="{Binding Location}" />
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</StackLayout>
```

The benefit here is that you can bind to the actual model that you plan to use.

## Alternative: Hardcode a static ViewModel

If you don't want to add design time data to individual controls, you can set up a mock data store to bind to your page. Refer to James Montemagno's [blog post on adding design-time data](https://montemagno.com/xamarin-forms-design-time-data-tips-best-practices/) to see how to bind to a static ViewModel in XAML.

## Troubleshooting

### Requirements

Design time data requires the 16.7 release of Visual Studio 2019.

### IntelliSense shows squiggly lines under my design time data

This is a known issue and will be fixed in an upcoming version of Visual Studio. The project will still build without errors.

### The XAML Previewer stopped working

Try closing and reopening the XAML file, and cleaning and rebuilding your project.

## See also

- [Design Time Data with the XAML Previewer](/xamarin/xamarin-forms/xaml/xaml-previewer/design-time-data/)
- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)