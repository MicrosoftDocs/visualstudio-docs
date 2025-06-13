---
title: Creating a WPF Toolbox Control
description: Learn how to use the WPF Toolbox Control template to create a Toolbox control that you can distribute to other users.
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- toolbox control
- toolbox
- wpf
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create a WPF Toolbox Control

The WPF (Windows Presentation Framework) Toolbox Control template lets you create WPF controls that are automatically added to the **Toolbox** when the extension is installed. This walkthrough shows how to use the template to create a **Toolbox** control that you can distribute to other users.

## Create the Toolbox Control

### Create an extension with a WPF Toolbox Control

1. Create a VSIX project named `MyToolboxControl`. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. When the project opens, add a **WPF Toolbox Control** item template named `MyToolboxControl`. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item** dialog, go to **Visual C#** > **Extensibility** and select **WPF Toolbox Control**. In the **Name** field at the bottom of the window, change the command file name to *MyToolboxControl.cs*.

    The solution now contains a user control, a `ProvideToolboxControlAttribute` <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute> that adds the control to the **Toolbox**, and a **Microsoft.VisualStudio.ToolboxControl** Asset entry in the VSIX manifest for  deployment.

#### To create the control UI

1. Open *MyToolboxControl.xaml* in the designer.

    The designer shows a <xref:System.Windows.Controls.Grid> control that contains a <xref:System.Windows.Controls.Button> control.

2. Arrange the grid layout. When you select the <xref:System.Windows.Controls.Grid> control, blue control bars appear on the top and left edges of the grid. You can add rows and columns to the grid by clicking the bars.

3. Add child controls to the grid. You can position a child control by dragging it from the **Toolbox** to a section of the grid, or by setting its `Grid.Row` and `Grid.Column` attributes in the XAML. The following example adds two labels on the top row of the grid and a button on the second row.

    ```xaml
    <Grid>
        <Label Grid.Row="0" Grid.Column="0" Name="label1" />
        <Label Grid.Row="0" Grid.Column="1" Name="label2" />
        <Button Name="button1" Click="button1_Click" Grid.Row="1" Grid.ColumnSpan="2" />
    </Grid>
    ```

## Renaming the control

 By default, your control will appear in the **Toolbox** as **MyToolboxControl** in a group named **MyToolboxControl.MyToolboxControl**. You can change these names in the *MyToolboxControl.xaml.cs* file.

1. Open *MyToolboxControl.xaml.cs* in the code view.

2. Find the `MyToolboxControl` class and rename it to TestControl. (The fastest way to do this is to rename the class, then select **Rename** from the context menu and complete the steps. (For more information about the **Rename** command, see [Rename refactoring (C#)](../ide/reference/rename.md).)

3. Go to the `ProvideToolboxControl` attribute and change the value of the first parameter to **Test**. This is the name of the group that will contain the control in the **Toolbox**.

    The resulting code should look like this:

    ```csharp
    [ProvideToolboxControl("Test", true)]
    public partial class TestControl : UserControl
    {
        public TestControl()
        {
            InitializeComponent();
        }
    }
    ```

## Build, test, and deployment

 When you debug the project, you should find the control installed in the **Toolbox** of the experimental instance of Visual Studio.

### To build and test the control

1. Rebuild the project and start debugging.

2. In the new instance of Visual Studio, create a WPF Application project. Make sure the XAML Designer is open.

3. Find your control in the **Toolbox** and drag it to the design surface.

4. Start debugging the WPF application.

5. Verify that your control appears.

### To deploy the control

1. After you build the tested project, you can find the *.vsix* file in the *\bin\debug\* folder of the project.

2. You can install it on a local computer by double-clicking the *.vsix* file and following the installation procedure. To uninstall the control, go to **Tools** > **Extensions and Updates** and look for the control extension, then click **Uninstall**.

3. Upload the *.vsix* file to a network or to a Web site.

    If you upload the file to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) Web site, other users can use **Tools** > **Extensions and Updates** in Visual Studio to find the control online and install it.
