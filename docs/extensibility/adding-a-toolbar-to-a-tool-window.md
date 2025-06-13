---
title: Adding a Toolbar to a Tool Window
description: Learn how to add a toolbar containing buttons that are bound to commands to a tool window in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- tool windows, adding toolbars
- toolbars [Visual Studio], adding to tool windows
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add a toolbar to a tool window

This walkthrough shows how to add a toolbar to a tool window.

 A toolbar is a horizontal or vertical strip that contains buttons bound to commands. The length of a toolbar in a tool window is always the same as the width or height of the tool window, depending on where the toolbar is docked.

 Unlike toolbars in the IDE, a toolbar in a tool window must be docked and cannot be moved or customized. If the VSPackage is written in unmanaged code, the toolbar can be docked on any edge.

 For more information about how to add a toolbar, see [Adding a toolbar](../extensibility/adding-a-toolbar.md).

## Create a toolbar for a tool window

1. Create a VSIX project named `TWToolbar` that has both a menu command named **TWTestCommand** and a tool window named **TestToolWindow**. For more information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md) and [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md). You need to add the command item template before adding the tool window template.

2. In *TWTestCommandPackage.vsct*, look for the Symbols section. In the GuidSymbol node named guidTWTestCommandPackageCmdSet declare a toolbar and a toolbar group, as follows.

    ```xml
    <IDSymbol name="TWToolbar" value="0x1000" />
    <IDSymbol name="TWToolbarGroup" value="0x1050" />
    ```

3. At the top of the `Commands` section, create a `Menus` section. Add a `Menu` element to define the toolbar.

    ```xml
    <Menus>
        <Menu guid="guidTWTestCommandPackageCmdSet" id="TWToolbar" type="ToolWindowToolbar">
            <CommandFlag>DefaultDocked</CommandFlag>
            <Strings>
                <ButtonText>Test Toolbar</ButtonText>
                <CommandName>Test Toolbar</CommandName>
            </Strings>
        </Menu>
    </Menus>
    ```

     Toolbars can't be nested like submenus. Therefore, you don't have to assign a parent. Also, you don't have to set a priority, because the user can move toolbars. Typically, initial placement of a toolbar is defined programmatically, but subsequent changes by the user are persisted.

4. In the Groups section, define a group to contain the commands for the toolbar.

    ```xml

    <Group guid="guidTWTestCommandPackageCmdSet" id="TWToolbarGroup" priority="0x0000">
        <Parent guid="guidTWTestCommandPackageCmdSet" id="TWToolbar" />
    </Group>
    ```

5. In the Buttons section, change the parent of the existing Button element to the toolbar group so that the toolbar will be displayed.

    ```xml
    <Button guid="guidTWTestCommandPackageCmdSet" id="TWTestCommandId" priority="0x0100" type="Button">
        <Parent guid="guidTWTestCommandPackageCmdSet" id="TWToolbarGroup" />
        <Icon guid="guidImages" id="bmpPic1" />
        <Strings>
            <ButtonText>Invoke TWTestCommand</ButtonText>
        </Strings>
    </Button>
    ```

     By default, if a toolbar has no commands, it does not appear.

     Because the new toolbar is not automatically added to the tool window, the toolbar must be added explicitly. This is discussed in the next section.

## Add the toolbar to the tool window

1. In *TWTestCommandPackageGuids.cs* add the following lines.

    ```csharp
    public const string guidTWTestCommandPackageCmdSet = "00000000-0000-0000-0000-0000";  // get the GUID from the .vsct file
    public const int TWToolbar = 0x1000;
    ```

2. In *TestToolWindow.cs* add the following using statement.

    ```csharp
    using System.ComponentModel.Design;
    ```

3. In the TestToolWindow constructor add the following line.

    ```csharp
    this.ToolBar = new CommandID(new Guid(TWTestCommandPackageGuids.guidTWTestCommandPackageCmdSet), TWTestCommandPackageGuids.TWToolbar);
    ```

## Test the toolbar in the tool window

1. Build the project and start debugging. The Visual Studio experimental instance should appear.

2. On the **View / Other Windows** menu, click **Test ToolWindow** to display the tool window.

     You should see a toolbar (it looks like the default icon) at the top left of the tool window, just below the title.

3. On the toolbar, click the icon to display the message **TWTestCommandPackage Inside TWToolbar.TWTestCommand.MenuItemCallback()**.

## Related content
- [Add a toolbar](../extensibility/adding-a-toolbar.md)
