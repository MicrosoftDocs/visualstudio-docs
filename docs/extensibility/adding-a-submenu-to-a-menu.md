---
title: Adding a Submenu to a Menu
description: Create a submenu, add it to the Visual Studio menu bar, and add commands to the submenu in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- context menus
- submenus, cascading
- cascading submenus
- menus, creating cascading submenus
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add a Submenu to a Menu

This walkthrough builds on the demonstration in [Add a Menu to the Visual Studio Menu Bar](../extensibility/adding-a-menu-to-the-visual-studio-menu-bar.md) by showing how to add a submenu to the **TestMenu** menu.

 A submenu is a secondary menu that appears in another menu. A submenu can be identified by the arrow that follows its name. Clicking the name causes the submenu and its commands to be displayed.

 This walkthrough creates a submenu in a menu on the Visual Studio menu bar and puts a new command on the submenu. The walkthrough also implements the new command.

## Add a Submenu to a Menu

1. Follow the steps in [Add a Menu to the Visual Studio Menu Bar](../extensibility/adding-a-menu-to-the-visual-studio-menu-bar.md) to create the project and menu item. The steps in this walkthrough assume that the name of the VSIX project is `TopLevelMenu`.

2. Open *TestCommandPackage.vsct*. In the `<Symbols>` section, add an `<IDSymbol>` element for the submenu, one for the submenu group, and one for the command, all in the `<GuidSymbol>` node named "guidTopLevelMenuCmdSet." This is the same node that contains the `<IDSymbol>` element for the top-level menu.

    ```xml
    <IDSymbol name="SubMenu" value="0x1100"/>
    <IDSymbol name="SubMenuGroup" value="0x1150"/>
    <IDSymbol name="cmdidTestSubCommand" value="0x0105"/>
    ```

3. Add the newly created submenu to the `<Menus>` section.

    ```xml
    <Menu guid="guidTestCommandPackageCmdSet" id="SubMenu" priority="0x0100" type="Menu">
        <Parent guid="guidTestCommandPackageCmdSet" id="MyMenuGroup"/>
        <Strings>
            <ButtonText>Sub Menu</ButtonText>
            <CommandName>Sub Menu</CommandName>
        </Strings>
    </Menu>
    ```

     The GUID/ID pair of the parent specifies the menu group that was generated in [Add a Menu to the Visual Studio Menu Bar](../extensibility/adding-a-menu-to-the-visual-studio-menu-bar.md), and is a child of the top-level menu.

4. Add the menu group defined in step 2 to the `<Groups>` section and make it a child of the submenu.

    ```xml
    <Group guid="guidTestCommandPackageCmdSet" id="SubMenuGroup" priority="0x0000">
        <Parent guid="guidTestCommandPackageCmdSet" id="SubMenu"/>
    </Group>
    ```

5. Add a new `<Button>` element to the `<Buttons>` section to define the command created in step 2 as an item on the submenu.

    ```xml
    <Button guid="guidTestCommandPackageCmdSet" id="cmdidTestSubCommand" priority="0x0000" type="Button">
        <Parent guid="guidTestCommandPackageCmdSet" id="SubMenuGroup" />
        <Icon guid="guidImages" id="bmpPic2" />
        <Strings>
           <CommandName>cmdidTestSubCommand</CommandName>
           <ButtonText>Test Sub Command</ButtonText>
        </Strings>
    </Button>
    ```

6. Build the solution and start debugging. You should see the experimental instance.

7. Click **TestMenu** to see a new submenu named **Sub Menu**. Click **Sub Menu** to open the submenu and see a new command, **Test Sub Command**. Notice that clicking **Test Sub Command** does nothing.

## Add a Command

1. Open *TestCommand.cs* and add the following command ID after the existing command ID.

    ```csharp
    public const int cmdidTestSubCmd = 0x0105;
    ```

2. Add the sub-command. Find the command constructor. Add the following lines just after the call to the `AddCommand` method.

    ```csharp
    CommandID subCommandID = new CommandID(CommandSet, cmdidTestSubCmd);
    MenuCommand subItem = new MenuCommand(new EventHandler(SubItemCallback), subCommandID);
    commandService.AddCommand(subItem);
    ```

    The `SubItemCallback` command handler will be defined later. The constructor should now look like this:

    ```csharp
    private TestCommand(Package package)
    {
        if (package == null)
        {
            throw new ArgumentNullException("package");
        }

        this.package = package;

        OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
        if (commandService != null)
        {
            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new MenuCommand(this.MenuItemCallback, menuCommandID);
            commandService.AddCommand(menuItem);

            CommandID subCommandID = new CommandID(CommandSet, cmdidTestSubCmd);
            MenuCommand subItem = new MenuCommand(new EventHandler(SubItemCallback), subCommandID);
            commandService.AddCommand(subItem);
        }
    }
    ```

3. Add `SubItemCallback()`. This is the method that is called when the new command in the submenu is clicked.

    ```csharp
    private void SubItemCallback(object sender, EventArgs e)
    {
        ThreadHelper.ThrowIfNotOnUIThread();
        IVsUIShell uiShell = this.package.GetService<SVsUIShell, IVsUIShell>();
        Guid clsid = Guid.Empty;
        int result;
        uiShell.ShowMessageBox(
            0,
            ref clsid,
            "TestCommand",
            string.Format(CultureInfo.CurrentCulture,
            "Inside TestCommand.SubItemCallback()",
            this.ToString()),
            string.Empty,
            0,
            OLEMSGBUTTON.OLEMSGBUTTON_OK,
            OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
            OLEMSGICON.OLEMSGICON_INFO,
            0,
            out result);
    }
    ```

4. Build the project and start debugging. The experimental instance should appear.

5. On the **TestMenu** menu, click **Sub Menu** and then click **Test Sub Command**. A message box should appear and display the text, "Test Command Inside TestCommand.SubItemCallback()".

## Related content

- [Add a menu to the Visual Studio menu bar](../extensibility/adding-a-menu-to-the-visual-studio-menu-bar.md)
- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
