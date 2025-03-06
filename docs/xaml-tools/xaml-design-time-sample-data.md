---
title: Use design-time sample data with the XAML Designer
description: Develop Windows Presentation Foundation (WPF) .NET projects with the XAML Designer in Visual Studio to enable sample data in data-reliant controls.
ms.date: 06/01/2021
ms.topic: conceptual
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
monikerRange: ">=vs-2019"
---
# Use design-time sample data with the XAML Designer in Visual Studio

Some data-reliant controls, such as `ListView`, `ListBox`, and `DataGrid`, are hard to visualize without data. In this article, we'll review a new approach that allows developers who are working on Windows Presentation Foundation (WPF) .NET Core projects or WPF .NET Framework projects with the XAML Designer in Visual Studio to enable sample data in these controls.

## Requirements

The Sample Data feature requires Visual Studio 2019 version [16.10](/visualstudio/releases/2019/release-notes-v16.10) or later.

The feature supports Windows desktop projects that target WPF for .NET Core or .NET Framework when you're using the new designer. To enable the new designer for .NET Framework:

1. Go to **Tools** > **Options** > **Environment** > **Preview Features**.
2. Select **New WPF XAML Designer for .NET Framework**, and then restart Visual Studio.

## Basics of the Sample Data feature

The Sample Data feature is for design-time visualization only. It appears only in the XAML designer, not in the running app. As such, it's applied to the design-time version of the `ItemsSource` property `d:ItemsSource`.
Sample data needs the design-time namespace to work.

> [!NOTE]
> To learn more about design-time properties in XAML, see [XAML design-time properties](../xaml-tools/xaml-designtime-data.md).

To get started, add the following lines of code to the header of your XAML document if they aren't already present:

```xml
xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
mc:Ignorable="d"
```

After you add the namespaces, you can use `d:ItemsSource="{d:SampleData}"` to enable sample data in your `ListView`, `Listbox`, or `DataGrid` control. For example:

```xml
<DataGrid d:ItemsSource="{d:SampleData}"/>
```

[![Screenshot that shows sample data on a data grid.](media\xaml-sample-data-empty-datagrid.png "Sample data enabled on a data grid")](media\xaml-sample-data-empty-datagrid.png#lightbox)

In this example, without `d:ItemsSource="{d:SampleData}"`, the XAML Designer would show an empty data grid. Instead, with `d:SampleData`, it now shows generated default sample data.

By default, five items are displayed. However, you can use the `ItemCount` property to specify how many items you want to display. For example: `d:ItemsSource="{d:SampleData ItemCount=2}"`.

## Sample data with data templates

The Sample Data feature works for `ListBox`, `ListView`, or `DataGrid` controls when you use data templates. The feature will analyze the `DataTemplate` control and try to generate the appropriate data for it.

Sample data will be generated only for elements in data templates that use bindings. Sample data will be generated even if the bindings don't have a source yet. For example:

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

[![Screenshot that shows sample data in a list view with a data template.](media\xaml-sample-data-templated-listview.png "Sample data used in a list view with a data template")](media\xaml-sample-data-templated-listview.png#lightbox)

## Sample data with Suggested Actions

To easily enable or disable sample data for a control from the designer, you can use the Suggested Actions feature. Suggested Actions is a lightbulb on the designer that appears on the upper right when you select a control. You can enable sample data by selecting your control, selecting the lightbulb, and then selecting **Show Sample Data**. For example:

[![Screenshot that shows sample data with Suggested Actions.](media\xaml-sample-data-suggested-actions.png "Enable sample data with Suggested Actions")](media\xaml-sample-data-suggested-actions.png#lightbox)

## Sample data with the IValueConverter interface

The Sample Data feature doesn't fully support converters or the `IValueConverter` interface. However, you can get it to work by doing one or both of the following:

- Make sure that your `Convert` function can handle a scenario where the value is already your target type.
- Implement the `ConvertBack` function that will convert your value back to the original type.

## Troubleshooting

If your sample data is not showing anything or fails to show the correct type, you can try refreshing the designer or closing and reopening the page.

If you experience a problem that isn't listed in this section or that can't be fixed by refreshing the page, please let us know by using the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool.

## Related content

- [XAML design-time properties](../xaml-tools/xaml-designtime-data.md)
- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)
- [XAML in .NET MAUI apps](/dotnet/maui/xaml/)
