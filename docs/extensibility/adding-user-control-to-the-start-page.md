---
title: "Adding User Control to the Start Page | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "start page dll"
  - "custom start page"
  - "start page assembly"
ms.assetid: 5b7997db-af6f-4fa9-a128-bceb42bddaf1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
monikerRange: vs-2017
---
# Add user control to the Start Page

This walkthrough shows how to add a DLL reference to a custom Start Page. The example adds a user control to the solution, builds the user control, and then references the built assembly from the Start Page *.xaml* file. A new tab hosts the user control, which functions as a basic Web browser.

You can use the same process to add any assembly that can be called from a *.xaml* file.

## Add a WPF user control to the solution

First, add a Windows Presentation Foundation (WPF) user control to the Start Page solution.

1. Create a Start Page by using we created in [Create a custom Start Page](../extensibility/creating-a-custom-start-page.md).

2. In **Solution Explorer**, right-click the solution, click **Add**, and then click **New Project**.

3. In the left pane of the **New Project** dialog box, expand either the **Visual Basic** or **Visual C#** node, and click **Windows**. In the middle pane, select **WPF User Control Library**.

4. Name the control `WebUserControl` and then click **OK**.

## Implement the user control

To implement a WPF user control, build the user interface (UI) in XAML and then write the code-behind events in C# or another .NET language.

### To write the XAML for the user control

1. Open the XAML file for the user control. In the `<Grid>` element, add the following row definitions to the control.

    ```vb
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="*" />
    </Grid.RowDefinitions>

    ```

2. In the main `<Grid>` element, add the following new `<Grid>` element, which contains a text box for typing Web addresses and a button for setting the new address.

    ```xml
    <Grid Grid.Row="0">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="Auto" />
        </Grid.ColumnDefinitions>
        <TextBox x:Name="UserSource" Grid.Column="0" />
        <Button Grid.Column="1" x:Name="SetButton" Content="Set Address" Click="SetButton_Click" />
    </Grid>
    ```

3. Add the following frame to the top-level `<Grid>` element just after the `<Grid>` element that contains the button and textbox.

    ```vb
    <Frame Grid.Row="1" x:Name="WebFrame" Source="http://www.bing.com" Navigated="WebFrame_Navigated" />
    ```

4. The following example shows the completed XAML for the user control.

    ```xml
    <UserControl x:Class="WebUserControl.UserControl1"
                 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                 xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
                 xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
                 mc:Ignorable="d"
                 d:DesignHeight="300" d:DesignWidth="300">
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto"/>
                <RowDefinition Height="*" />
            </Grid.RowDefinitions>
            <Grid Grid.Row="0">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="Auto" />
                </Grid.ColumnDefinitions>
                <TextBox x:Name="UserSource" Grid.Column="0" />
                <Button Grid.Column="1" x:Name="SetButton" Content="Set Address" Click="SetButton_Click" />
            </Grid>
            <Frame Grid.Row="1" x:Name="WebFrame" Source="http://www.bing.com" Navigated="WebFrame_Navigated" />
        </Grid>
    </UserControl>

    ```

### To write the code-behind events for the user control

1. In the XAML designer, double-click the **Set Address** button you added to the control.

    The *UserControl1.cs* file opens in the code editor.

2. Fill in the SetButton_Click Event Handler as follows.

    ```csharp
    private void SetButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            this.WebFrame.Source = new Uri(this.UserSource.Text, UriKind.Absolute);
        }
        catch (Exception error)
        {
            MessageBox.Show(error.Message);
        }
    }
    ```

    This code sets the Web address that is typed in the text box as the target for the Web browser. If the address is not valid, the code throws an error.

3. You must also handle the WebFrame_Navigated event:

    ```csharp
    private void WebFrame_Navigated(object sender, EventArgs e)
    { }
    ```

4. Build the solution.

## Add the user control to the Start Page

To make this control available to the Start Page project, in the Start Page project file, add a reference to the new control library. Then you can add the control to the Start Page XAML markup.

1. In **Solution Explorer**, in the Start Page project, right-click **References** and then click **Add Reference**.

2. On the **Projects** tab, select **WebUserControl** and then click **OK**.

3. On the **Build** menu, click **Build Solution**.

    Building the solution makes the user control available to IntelliSense for other files in the solution.

    To add the control to the Start Page XAML markup, add a namespace reference to the assembly, then put the control on the page.

### To add the control to the markup

1. In **Solution Explorer**, open the Start Page *.xaml* file.

2. In the **XAML** pane, add the following namespace declaration to the top-level <xref:System.Windows.Controls.Grid> element.

   ```xml
   xmlns:vsc="clr-namespace:WebUserControl;assembly=WebUserControl"
   ```

3. In the **XAML** pane, scroll to the \<Grid> section.

    The section contains a <xref:System.Windows.Controls.TabControl> element in a <xref:System.Windows.Controls.Grid> element.

4. Add a \<TabControl> element containing a \<TabItem> that contains a reference to your user control.

    ```xml

    <TabItem Header="Web" Height="Auto">
        <vsc:UserControl1 />
    </TabItem>

    ```

    Now you can test the control.

## Test a manually created custom Start Page

1. Copy your XAML file, and any supporting text files or markup files, to the *%USERPROFILE%\My Documents\Visual Studio 2015\StartPages\\* folder.

2. If your start page references any controls or types in assemblies that are not installed by Visual Studio, copy the assemblies and then paste them in _Visual Studio installation folder_**\Common7\IDE\PrivateAssemblies\\**.

3. At a Visual Studio command prompt, type **devenv /rootsuffix Exp** to open an experimental instance of Visual Studio.

4. In the experimental instance, go to the **Tools** > **Options** > **Environment** > **Startup** page and select your XAML file from the **Customize Start Page** dropdown.

5. On the **View** menu, click **Start Page**.

    Your custom start page should be displayed. If you want to change any files, you must close the experimental instance, make the changes, copy and paste the changed files, and then re-open the experimental instance to view the changes.

## See also

- [WPF container controls](https://msdn.microsoft.com/library/a0177167-d7db-4205-9607-8ae316952566)
- [Walkthrough: Add custom XAML to the Start Page](../extensibility/walkthrough-adding-custom-xaml-to-the-start-page.md)
