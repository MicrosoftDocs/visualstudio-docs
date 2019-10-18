---
title: "L2DBForm.xaml Source Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 624e96d4-6d27-4195-8ac2-2f3835f6c57e
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# L2DBForm.xaml Source Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic contains and describes the XAML source file for the [WPF Data Binding Using LINQ to XML Example](../designers/wpf-data-binding-using-linq-to-xml-example.md), L2DBForm.xaml.

## Overall UI Structure
 As is typical for a WPF project, this file contains one parent element, a <xref:System.Windows.Window> XML element associated with the derived class `L2XDBFrom` in the `LinqToXmlDataBinding` namespace.

 The client area is contained within a <xref:System.Windows.Controls.StackPanel> that is given a light blue background. This panel contains four <xref:System.Windows.Controls.DockPanel> UI sections separated by <xref:System.Windows.Controls.Separator> bars. The purpose of these sections is described in the **Remarks** in the [previous topic](../designers/walkthrough-linqtoxmldatabinding-example.md).

 Each section contains a label that identifies it. In the first two sections, this label is rotated 90 degrees through the use of a <xref:System.Windows.FrameworkElement.LayoutTransform%2A>. The remainder of the section contains UI elements appropriate to the purpose of that section: text blocks, text boxes, buttons, and so on. Sometimes a child <xref:System.Windows.Controls.StackPanel> is used to align these child controls.

## Window Resource Section
 The opening `<Window.Resources>` tag on line 9 indicates the start of the window resource section. It ends with the closing tag on line 35.

 The `<ObjectDataProvider>` tag, which spans lines 11 through 25, declares a <xref:System.Windows.Data.ObjectDataProvider>, named `LoadedBooks`, that uses an <xref:System.Xml.Linq.XElement> as the source. This <xref:System.Xml.Linq.XElement> is initialized by parsing an embedded XML document (a `CDATA` element). Notice that white space is preserved when declaring the embedded XML document and also when it is parsed. This was done because the <xref:System.Windows.Controls.TextBlock> control, which is used to display the raw XML, has no special XML formatting capabilities.

 Lastly, a <xref:System.Windows.DataTemplate> named `BookTemplate` is defined on lines 28 through 34. This template will be used to display the entries in the **Book List** UI section. It uses data binding and LINQ to XML dynamic properties to retrieve the book ID and book name through the following assignments:

```
Text="{Binding Path=Attribute[id].Value}"Text="{Binding Path=Value}"
```

## Data Binding Code
 In addition to the <xref:System.Windows.DataTemplate> element, data binding is used in a number of other places in this file.

 In the opening `<StackPanel>` tag on line 38, the <xref:System.Windows.FrameworkElement.DataContext%2A> property of this panel is set to the `LoadedBooks` data provider.

```
DataContext="{Binding Source={StaticResource LoadedBooks}}
```

 This makes it possible (on line 46) for the <xref:System.Windows.Controls.TextBlock> named `tbRawXml` to display the raw XML by binding to this data provider's `Xml` property:

```
Text="{Binding Path=Xml}"
```

 The <xref:System.Windows.Controls.ListBox> in the **Book List** UI section, on lines 58 through 62, sets the template for its display items to the `BookTemplate` defined in the window resource section:

```
ItemTemplate ="{StaticResource BookTemplate}"
```

 Then, on lines 59 through 62, the actual values of the books are bound to this list box:

```
<ListBox.ItemsSource>
    <Binding Path="Elements[{http://www.mybooks.com}book]"/>
</ListBox.ItemsSource>
```

 The third UI section, **Edit Selected Book**, first binds the <xref:System.Windows.FrameworkElement.DataContext%2A> of the parent <xref:System.Windows.Controls.StackPanel> to the currently selected item in from the **Book List** UI section (line 82):

```
DataContext="{Binding ElementName=lbBooks, Path=SelectedItem}"
```

 It then uses two-way data binding, so that the current values of the book elements are displayed to and updated from the two text boxes in this panel. Data binding to dynamic properties is similar to that used in the `BookTemplate` data template:

```
Text="{Binding Path=Attribute[id].Value}"...Text="{Binding Path=Value}"
```

 The last UI section, **Add New Book**, does not use data binding in its XAML code; instead, such code can be found in its event handling code in the file L2DBForm.xaml.cs.

## Example

### Description

> [!NOTE]
> We recommend that you copy the following code below into a code editor, such as the C# source code editor in Visual Studio, so that line numbers will be easier to track.

### Code

```xml
<Window x:Class="LinqToXmlDataBinding.L2XDBForm"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:system="clr-namespace:System;assembly=mscorlib"
    xmlns:xlinq="clr-namespace:System.Xml.Linq;assembly=System.Xml.Linq"
    xmlns:local="clr-namespace:LinqToXmlDataBinding"
    Title="WPF Data Binding using LINQ-to-XML" Height="665" Width="500" ResizeMode="NoResize">

    <Window.Resources>
        <!-- Books provider and inline data -->
        <ObjectDataProvider x:Key="LoadedBooks" ObjectType="{x:Type xlinq:XElement}" MethodName="Parse">
            <ObjectDataProvider.MethodParameters>
                <system:String xml:space="preserve">
<![CDATA[
<books xmlns="http://www.mybooks.com">
  <book id="0">book zero</book>
  <book id="1">book one</book>
  <book id="2">book two</book>
  <book id="3">book three</book>
</books>
]]>
                </system:String>
                <xlinq:LoadOptions>PreserveWhitespace</xlinq:LoadOptions>
            </ObjectDataProvider.MethodParameters>
        </ObjectDataProvider>

        <!-- Template for use in Books List listbox. -->
        <DataTemplate x:Key="BookTemplate">
            <StackPanel Orientation="Horizontal">
                <TextBlock Margin="3" Text="{Binding Path=Attribute[id].Value}"/>
                <TextBlock Margin="3" Text="-"/>
                <TextBlock Margin="3" Text="{Binding Path=Value}"/>
            </StackPanel>
        </DataTemplate>
    </Window.Resources>

    <!-- Main visual content container -->
    <StackPanel Background="lightblue" DataContext="{Binding Source={StaticResource LoadedBooks}}">
        <!-- Raw XML display section -->
        <DockPanel Margin="5">
            <Label  Background="Gray" FontSize="12" BorderBrush="Black" BorderThickness="1" FontWeight="Bold">XML
            <Label.LayoutTransform>
                <RotateTransform Angle="90"/>
            </Label.LayoutTransform>
            </Label>
            <TextBlock Name="tbRawXml" Height="200" Background="LightGray" Text="{Binding Path=Xml}" TextTrimming="CharacterEllipsis" />
        </DockPanel>

        <Separator Height="4" Margin="5" />

        <!-- List box to display all books section -->
        <DockPanel Margin="5">
            <Label  Background="Gray" FontSize="12" BorderBrush="Black" BorderThickness="1" FontWeight="Bold">Book List
                <Label.LayoutTransform>
                    <RotateTransform Angle="90"/>
                </Label.LayoutTransform>
            </Label>
            <ListBox Name="lbBooks" Height="200" Width="415" ItemTemplate ="{StaticResource BookTemplate}">
                <ListBox.ItemsSource>
                    <Binding Path="Elements[{http://www.mybooks.com}book]"/>
                </ListBox.ItemsSource>
            </ListBox>
            <Button Margin="5" DockPanel.Dock="Right" Height="30" Width ="130" Content="Remove Selected Book" Click="OnRemoveBook">
            <Button.LayoutTransform>
                <RotateTransform Angle="90"/>
            </Button.LayoutTransform>
            </Button>
        </DockPanel>

        <Separator Height="4" Margin="5" />

        <!-- Edit current selection section -->
        <DockPanel Margin="5">
            <TextBlock Margin="5" Height="30" Width="65" DockPanel.Dock="Right" Background="LightGray" TextWrapping="Wrap" TextAlignment="Center">
                    Changes are live!
                <TextBlock.LayoutTransform>
                    <RotateTransform Angle="90"/>
                </TextBlock.LayoutTransform>
            </TextBlock>
            <StackPanel>
                <Label Width="450" Background="Gray" FontSize="12" BorderBrush="Black" BorderThickness="1" HorizontalAlignment="Left" FontWeight="Bold">Edit Selected Book</Label>
                <StackPanel Margin="1" DataContext="{Binding ElementName=lbBooks, Path=SelectedItem}">
                    <StackPanel Orientation="Horizontal">
                        <Label Width="40">ID:</Label>
                        <TextBox Name="editAttributeTextBox" Width="410" Text="{Binding Path=Attribute[id].Value}">
                            <TextBox.ToolTip>
                                <TextBlock FontWeight="Bold" TextAlignment="Center">
                                    <Label>Edit the selected book ID and see it changed.</Label>
                                </TextBlock>
                            </TextBox.ToolTip>
                        </TextBox>
                    </StackPanel>
                    <StackPanel Orientation="Horizontal">
                        <Label Width="40">Value:</Label>
                        <TextBox Name="editValueTextBox" Width="410" Text="{Binding Path=Value}" Height="25">
                            <TextBox.ToolTip>
                                <TextBlock FontWeight="Bold" TextAlignment="Center">
                                    <Label>Edit the selected book Value and see it changed.</Label>
                                </TextBlock>
                            </TextBox.ToolTip>
                        </TextBox>
                    </StackPanel>
                </StackPanel>
            </StackPanel>
        </DockPanel>

        <Separator Height="4" Margin="5" />

        <!-- Add new book section -->
        <DockPanel Margin="5">
            <Button Margin="5" Height="30" DockPanel.Dock="Right" Click ="OnAddBook">Add Book
                <Button.LayoutTransform>
                    <RotateTransform Angle="90"/>
                </Button.LayoutTransform>
            </Button>
            <StackPanel>
                <Label Width="450" Background="Gray" FontSize="12" BorderBrush="Black" BorderThickness="1" HorizontalAlignment="Left" FontWeight="Bold">Add New Book</Label>
                <StackPanel Margin="1">
                    <StackPanel Orientation="Horizontal">
                        <Label Width="40">ID:</Label>
                        <TextBox Name="tbAddID" Width="410">
                            <TextBox.ToolTip>
                                <TextBlock FontWeight="Bold" TextAlignment="Center">
                                    <Label>Enter a book ID and Value pair, then click Add Book.</Label>
                                </TextBlock>
                            </TextBox.ToolTip>
                        </TextBox>
                    </StackPanel>
                    <StackPanel Orientation="Horizontal">
                        <Label Width="40">Value:</Label>
                        <TextBox Name="tbAddValue" Width="410" Height="25">
                            <TextBox.ToolTip>
                                <TextBlock FontWeight="UltraBold" TextAlignment="Center">
                                    <Label>Enter a book ID and Value pair, then click Add Book.</Label>
                                </TextBlock>
                            </TextBox.ToolTip>
                        </TextBox>
                    </StackPanel>
                </StackPanel>
            </StackPanel>
        </DockPanel>
    </StackPanel>
</Window>

```

### Comments
 For the C# source code for the event handlers associated with the WPF UI elements, see [L2DBForm.xaml.cs Source Code](../designers/l2dbform-xaml-cs-source-code.md).

## See Also
 [Walkthrough: LinqToXmlDataBinding Example](../designers/walkthrough-linqtoxmldatabinding-example.md)
 [L2DBForm.xaml.cs Source Code](../designers/l2dbform-xaml-cs-source-code.md)
