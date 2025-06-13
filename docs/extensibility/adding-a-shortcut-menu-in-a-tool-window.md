---
title: Adding a Shortcut Menu in a Tool Window
description: Learn how to add a shortcut menu to a tool window in Visual Studio that appears when a button, text box, or window background is right-clicked.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- context menus, adding to tool windows
- menus, context menus
- shortcut menus, adding to tool windows
- tool windows, adding context menus
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add a shortcut menu in a tool window

This walkthrough puts a shortcut menu in a tool window. A shortcut menu is a menu that appears when a user right-clicks a button, text box, or window background. Commands on a shortcut menu behave the same as commands on other menus or toolbars. To support a shortcut menu, specify it in the *.vsct* file and display it in response to the right-click of the mouse.

A tool window consists of a WPF user control in a custom tool window class that inherits from <xref:Microsoft.VisualStudio.Shell.ToolWindowPane>.

This walkthrough shows how to create a shortcut menu as a Visual Studio menu, by declaring menu items in the *.vsct* file, and then using the Managed Package Framework to implement them in the class that defines the tool window. This approach facilitates access to Visual Studio commands, UI elements, and the Automation object model.

Alternatively, if your shortcut menu will not access Visual Studio functionality, you can use the <xref:System.Windows.FrameworkElement.ContextMenu%2A> property of a XAML element in the user control. For more information, see [ContextMenu](/dotnet/framework/wpf/controls/contextmenu).

## Create the tool window shortcut menu package

1. Create a VSIX project named `TWShortcutMenu` and add a tool window template named **ShortcutMenu** to it. For more information about creating a tool window, see [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md).

## Specifying the shortcut menu
A shortcut menu such as the one shown in this walkthrough lets the user select from a list of colors that are used to fill the background of the tool window.

1. In *ShortcutMenuPackage.vsct*, find in the GuidSymbol element named guidShortcutMenuPackageCmdSet, and declare the shortcut menu, shortcut menu group, and menu options. The GuidSymbol element should now look like this:

    ```xml
    <GuidSymbol name="guidShortcutMenuPackageCmdSet" value="{00000000-0000-0000-0000-0000}"> // your GUID here
        <IDSymbol name="ShortcutMenuCommandId" value="0x0100" />
        <IDSymbol name="ColorMenu" value="0x1000"/>
        <IDSymbol name="ColorGroup" value="0x1100"/>
        <IDSymbol name="cmdidRed" value="0x102"/>
        <IDSymbol name="cmdidYellow" value="0x103"/>
        <IDSymbol name="cmdidBlue" value="0x104"/>
    </GuidSymbol>
    ```

2. Just before the Buttons element, create a Menus element and then define the shortcut menu in it.

    ```vb
    <Menus>
      <Menu guid="guidShortcutMenuPackageCmdSet" id="ColorMenu" type="Context">
        <Strings>
          <ButtonText>Color change</ButtonText>
          <CommandName>ColorChange</CommandName>
        </Strings>
      </Menu>
    </Menus>
    ```

    A shortcut menu does not have a parent because it is not part of a menu or toolbar.

3. Create a Groups element with a Group element that contains the shortcut menu items, and associate the group with the shortcut menu.

    ```xml
    <Groups>
        <Group guid="guidShortcutMenuPackageCmdSet" id="ColorGroup">
            <Parent guid="guidShortcutMenuPackageCmdSet" id="ColorMenu"/>
        </Group>
    </Groups>
    ```

4. In the Buttons element, define the individual commands that will appear on the shortcut menu. The Buttons element should look like this:

    ```xml
    <Buttons>
        <Button guid="guidShortcutMenuPackageCmdSet" id="ShortcutMenuCommandId" priority="0x0100" type="Button">
            <Parent guid="guidSHLMainMenu" id="IDG_VS_WNDO_OTRWNDWS1"/>
            <Icon guid="guidImages" id="bmpPic1" />
            <Strings>
                <ButtonText>ShortcutMenu</ButtonText>
            </Strings>
        </Button>

        <Button guid="guidShortcutMenuPackageCmdSet" id="cmdidRed" priority="1" type="Button">
            <Parent guid="guidShortcutMenuPackageCmdSet" id="ColorGroup" />
            <Strings>
                <ButtonText>Red</ButtonText>
            </Strings>
        </Button>

        <Button guid="guidShortcutMenuPackageCmdSet" id="cmdidYellow" priority="3" type="Button">
            <Parent guid="guidShortcutMenuPackageCmdSet" id="ColorGroup" />
            <Strings>
                <ButtonText>Yellow</ButtonText>
            </Strings>
        </Button>

        <Button guid="guidShortcutMenuPackageCmdSet" id="cmdidBlue" priority="5" type="Button">
            <Parent guid="guidShortcutMenuPackageCmdSet" id="ColorGroup" />
            <Strings>
                <ButtonText>Blue</ButtonText>
            </Strings>
        </Button>
    </Buttons>
    ```

5. In *ShortcutMenuCommand.cs*, add the definitions for the command set GUID, the shortcut menu, and the menu items.

    ```csharp
    public const string guidShortcutMenuPackageCmdSet = "00000000-0000-0000-0000-00000000"; // your GUID will differ
    public const int ColorMenu = 0x1000;
    public const int cmdidRed = 0x102;
    public const int cmdidYellow = 0x103;
    public const int cmdidBlue = 0x104;
    ```

    These are the same command IDs that are defined in the Symbols section of the *ShortcutMenuPackage.vsct* file. The context group is not included here because it is required only in the *.vsct* file.

## Implementing the shortcut menu
 This section implements the shortcut menu and its commands.

1. In *ShortcutMenu.cs*, the tool window can get the menu command service, but the control it contains cannot. The following steps show how to make the menu command service available to the user control.

2. In *ShortcutMenu.cs*, add the following using directives:

    ```csharp
    using Microsoft.VisualStudio.Shell;
    using System.ComponentModel.Design;
    ```

3. Override the tool window's Initialize() method to get the menu command service and add the control, passing the menu command service to the constructor:

    ```csharp
    protected override void Initialize()
    {
        var commandService = (OleMenuCommandService)GetService(typeof(IMenuCommandService));
        Content = new ShortcutMenuControl(commandService);
    }
    ```

4. In the ShortcutMenu tool window constructor, remove the line that adds the control. The constructor should now look like this:

    ```csharp
    public ShortcutMenu() : base(null)
    {
        this.Caption = "ShortcutMenu";
        this.BitmapResourceID = 301;
        this.BitmapIndex = 1;
    }
    ```

5. In *ShortcutMenuControl.xaml.cs*, add a private field for the menu command service and change the control constructor to take the menu command service. Then use the menu command service to add the context menu commands. The ShortcutMenuControl constructor should now look like the following code. The command handler will be defined later.

    ```csharp
    public ShortcutMenuControl(OleMenuCommandService service)
    {
        this.InitializeComponent();
        commandService = service;

        if (null !=commandService)
        {
            // Create an alias for the command set guid.
            Guid guid = new Guid(ShortcutMenuCommand.guidShortcutMenuPackageCmdSet);

            // Create the command IDs.
            var red = new CommandID(guid, ShortcutMenuCommand.cmdidRed);
            var yellow = new CommandID(guid, ShortcutMenuCommand.cmdidYellow);
            var blue = new CommandID(guid, ShortcutMenuCommand.cmdidBlue);

            // Add a command for each command ID.
            commandService.AddCommand(new MenuCommand(ChangeColor, red));
            commandService.AddCommand(new MenuCommand(ChangeColor, yellow));
            commandService.AddCommand(new MenuCommand(ChangeColor, blue));
        }
    }
    ```

6. In *ShortcutMenuControl.xaml*, add a <xref:System.Windows.UIElement.MouseRightButtonDown> event to the top level <xref:System.Windows.Controls.UserControl> element. The XAML file should now look like this:

    ```vb
    <UserControl x:Class="TWShortcutMenu.ShortcutMenuControl"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
            Background="{DynamicResource VsBrush.Window}"
            Foreground="{DynamicResource VsBrush.WindowText}"
            mc:Ignorable="d"
            d:DesignHeight="300" d:DesignWidth="300"
            Name="MyToolWindow"
            MouseRightButtonDown="MyToolWindow_MouseRightButtonDown">
        <Grid>
            <StackPanel Orientation="Vertical">
                <TextBlock Margin="10" HorizontalAlignment="Center">ShortcutMenu</TextBlock>
            </StackPanel>
        </Grid>
    </UserControl>
    ```

7. In *ShortcutMenuControl.xaml.cs*, add a stub for the event handler.

    ```csharp
    private void MyToolWindow_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
    . . .
    }
    ```

8. Add the following using directives to the same file:

    ```csharp
    using Microsoft.VisualStudio.Shell;
    using System.ComponentModel.Design;
    using System;
    using System.Windows.Input;
    using System.Windows.Media;
    ```

9. Implement the `MyToolWindowMouseRightButtonDown` event as follows.

    ```csharp
    private void MyToolWindow_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (null != commandService)
        {
            CommandID menuID = new CommandID(
                new Guid(ShortcutMenuCommand.guidShortcutMenuPackageCmdSet),
                ShortcutMenuCommand.ColorMenu);
            Point p = this.PointToScreen(e.GetPosition(this));
            commandService.ShowContextMenu(menuID, (int)p.X, (int)p.Y);
        }
    }
    ```

    This creates a <xref:System.ComponentModel.Design.CommandID> object for the shortcut menu, identifies the location of the mouse click, and opens the shortcut menu in that location by using the <xref:Microsoft.VisualStudio.Shell.OleMenuCommandService.ShowContextMenu%2A> method.

10. Implement the command handler.

    ```csharp
    private void ChangeColor(object sender, EventArgs e)
    {
        var mc = sender as MenuCommand;

        switch (mc.CommandID.ID)
        {
            case ShortcutMenuCommand.cmdidRed:
                MyToolWindow.Background = Brushes.Red;
                break;
            case ShortcutMenuCommand.cmdidYellow:
                MyToolWindow.Background = Brushes.Yellow;
                break;
            case ShortcutMenuCommand.cmdidBlue:
                MyToolWindow.Background = Brushes.Blue;
                break;
        }
    }
    ```

    In this case, just one method handles events for all of the menu items by identifying the <xref:System.ComponentModel.Design.CommandID> and setting the background color accordingly. If the menu items had contained unrelated commands, you would have created a separate event handler for each command.

## Test the tool window features

1. Build the project and start debugging. The experimental instance appears.

2. In the experimental instance, click **View / Other Windows**, and then click **ShortcutMenu**. Doing this should display your tool window.

3. Right-click in the body of the tool window. A shortcut menu that has a list of colors should be displayed.

4. Click a color on the shortcut menu. The tool window background color should be changed to the selected color.

## Related content
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
- [Using and providing services](../extensibility/using-and-providing-services.md)
