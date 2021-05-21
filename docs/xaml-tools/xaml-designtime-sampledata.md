---
title: Use Design-time Sample Data with the XAML Designer in Visual Studio
description: Learn how to use Sample design-time data in XAML.
ms.date: 05/20/2021
ms.topic: overview
author: alihamie
ms.author: tglee
manager: jmartens
monikerRange: vs-2019
---

# Use Design-time Sample Data with the XAML Designer in Visual Studio

Some data reliant controls such as ListView, ListBox or DataGrid are hard to visualize without data. In this document we'll be reviewing a new approach that allows developers working on **WPF .NET Core**  projects to enable sample data in these controls.

> [!NOTE]
> Visit [XAML design-time properties](/xaml/xaml-tools/xaml/xaml-designtime-data.md) to learn more about design-time properties in XAML. 

## Sample data basics

Sample data is **design-time only** and needs the design-time namespace to work. To get started, add the following lines of code to the header of your XAML document if they aren't already present:

```xml
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
mc:Ignorable="d"
```

After adding the namespaces, you can use `d:ItemsSource="{d:SampleData}"` to enable sample data in your ListView, Listbox or DataGrid. For example:

```xml
<DataGrid d:ItemsSource="{d:SampleData}"/>
```

[![Sample data with DataGrid](media\xaml-sampleData-EmptyDataGrid.png "Sample data enabled on a DataGrid")](media\xaml-sampleData-EmptyDataGrid.png#lightbox)

In this example, without `d:ItemsSource="{d:SampleData}"` the XAML Designer would be empty for the DataGrid. Instead, it shows some default sample data.

You can use the **ItemCount** property to specify how many items you would like to display, for example: `d:ItemsSource="{d:SampleData ItemCount=2}"`

## Sample data works with DataTemplates

Sample data also works if your ListBox, ListView or DataGrid use a DataTemplate. Sample data will analyze the DataTemplate and try to come up with data matching the types. **It is important that elements in the DataTemplate have bindings in them for sample data to work**. It will work even if the bindings don't have a source yet.
For example:

```xml
<ListView d:ItemsSource="{d:SampleData ItemCount=3}">
     <ListView.ItemTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal">
                <Image Width="50" Source="{Binding ProfilePicture}"/>
                <StackPanel Orientation="Vertical">
                    <TextBlock Text="{Binding FirstName}" Margin="5"/>
                    <Label Content="{Binding LastName}"/>
                </StackPanel>
            </StackPanel>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```

[![Sample data ListView with a DataTemplate](media\xaml-sampleData-TemplatedListView.png "Sample data used in a ListView with a DataTemplate")](media\xaml-sampleData-TemplatedListView.png#lightbox)

## Enable sample data with suggested actions

Another quick way to enable sample data can be done using the suggested actions feature. Suggested actions is a lightbulb on the designer that shows up on the top right when you select a control. You can enable sample data by selecting your control, clicking on the light bulb and then clicking on `Show Sample Data`. For example:

[![Sample data suggested actions](media\xaml-sampleData-SuggestedActions.png "Enable sample data with suggested actions")](media\xaml-sampleData-SuggestedActions.png#lightbox)

## Sample data with converters

Converters are not supported with the sample data feature. However you can get it to work by doing **one** of the following:
- Making sure that your convert function can handle a scenario where the type is already the target type.

- Implement the ConvertBack function that will convert your target type back to the actual type. 

## Troubleshooting

If your sample data is not showing anything or fails to show the correct type, you can try refreshing the designer or closing and re-opening the page.

If you experience a problem that isn't listed in this section, or can't be fixed by refreshing the page please let us know by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool.

### Requirements

- Sample data requires Visual Studio 2019 version [16.10](/visualstudio/releases/2019/release-notes-v16.10) or later.

- Supports Windows desktop projects that target Windows Presentation Foundation (WPF) for .NET Core only.

## See also

- [XAML design-time properties](/xaml/xaml-tools/xaml/xaml-designtime-data.md)
- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)