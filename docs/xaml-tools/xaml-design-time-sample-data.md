---
title: Use design-time sample data with the XAML Designer in Visual Studio
description: Learn how to use design-time sample data in XAML.
ms.date: 06/01/2021
ms.topic: conceptual
author: alihamie
ms.author: tglee
manager: jmartens
monikerRange: ">=vs-2019"
---

# Use design-time sample data with the XAML Designer in Visual Studio

Some data reliant controls, such as ListView, ListBox or DataGrid, are hard to visualize without data. In this document we'll review a new approach that allows developers working on **WPF .NET Core** projects or **WPF .NET Framework** projects with the new designer to enable sample data in these controls. 

## Sample data feature basics

Sample data is for design-time visualization only, meaning it only appears in the XAML designer, not the running app. As such, it is applied to the design-time version of the ItemsSource property `d:ItemsSource`. Sample Data needs the design-time namespace to work. To get started, add the following lines of code to the header of your XAML document if they aren't already present:

> [!NOTE]
> Visit [XAML design-time properties](../xaml-tools/xaml-designtime-data.md) to learn more about design-time properties in XAML.

```xml
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
mc:Ignorable="d"
```

After adding the namespaces, you can use `d:ItemsSource="{d:SampleData}"` to enable sample data in your ListView, Listbox or DataGrid. For example:

```xml
<DataGrid d:ItemsSource="{d:SampleData}"/>
```

[![Sample data with DataGrid](media\xaml-sample-data-empty-datagrid.png "Sample data enabled on a DataGrid")](media\xaml-sample-data-empty-datagrid.png#lightbox)

In this example, without `d:ItemsSource="{d:SampleData}"` the XAML Designer would show an empty DataGrid. Instead, with `d:SampleData` it now shows generated default sample data.

By default you get 5 items displayed. However, you can use the **ItemCount** property to specify how many items you would like to display. for example: `d:ItemsSource="{d:SampleData ItemCount=2}"`

## Sample data works with datatemplates

Sample Data works for ListBox, ListView or DataGrid controls when you use data templates. The Sample Data feature will analyze the DataTemplate and try to generate the appropriate data for it. Sample Data will only be generated for elements in DataTemplates that use bindings. Sample data will be generated even if the bindings don't have a source yet.
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

[![Sample Data ListView with a DataTemplate](media\xaml-sample-data-templated-listview.png "Sample Data used in a ListView with a DataTemplate")](media\xaml-sample-data-templated-listview.png#lightbox)

## Enable sample data with suggested actions

To easily enable or disable Sample Data for a control from the designer you can use the Suggested Actions feature. Suggested Actions is a lightbulb on the designer that shows up on the top right when you select a control. You can enable Sample Data by selecting your control, clicking on the light bulb and then clicking on `Show Sample Data`. For example:

[![Sample Data Suggested Actions](media\xaml-sample-data-suggested-actions.png "Enable Sample Data with Suggested Actions")](media\xaml-sample-data-suggested-actions.png#lightbox)

## Sample data with IValueConverters 

Converters are not fully supported by the Sample Data feature. However you can get it to work by doing one or both of the following:
- Make sure that your `Convert` function can handle a scenario where the value is already your targetType.

- Implement the `ConvertBack` function that will convert your value back to the original type. 

## Troubleshooting

If your Sample Data is not showing anything or fails to show the correct type, you can try refreshing the designer or closing and re-opening the page.

If you experience a problem that isn't listed in this section, or can't be fixed by refreshing the page please let us know by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool.

### Requirements

- Sample Data requires Visual Studio 2019 version [16.10](/visualstudio/releases/2019/release-notes-v16.10) or later.

- Supports Windows desktop projects that target Windows Presentation Foundation (WPF) for .NET Core or .NET Framework when using the new designer. To enable the new designer for .NET Framework go to Tools > Options > Environment > Preview Features, select New WPF XAML Designer for .NET Framework and then restart Visual Studio.

## See also

- [XAML design-time properties](../xaml-tools/xaml-designtime-data.md)
- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)