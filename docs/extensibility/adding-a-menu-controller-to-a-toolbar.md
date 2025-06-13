---
title: Adding a Menu Controller to a Toolbar
description: Learn how to create a menu controller and add it to a tool window toolbar in Visual Studio, then implement the menu controller commands and test it.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- toolbars [Visual Studio], adding menu controllers
- menus, adding menu controllers to toolbars
- menu controllers, adding to toolbars
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add a menu controller to a toolbar

This walkthrough builds on the [Add a toolbar to a tool window](../extensibility/adding-a-toolbar-to-a-tool-window.md) walkthrough and shows how to add a menu controller to the tool window toolbar. The steps shown here also can be applied to the toolbar that is created in the [Add a toolbar](../extensibility/adding-a-toolbar.md) walkthrough.

A menu controller is a split control. The left side of the menu controller shows the last-used command, and you can run it by clicking it. The right side of the menu controller is an arrow that, when clicked, opens a list of additional commands. When you click a command on the list, the command runs, and it replaces the command on the left side of the menu controller. In this way, the menu controller operates like a command button that always shows the last-used command from a list.

Menu controllers can appear on menus but they are most often used on toolbars.

## Create a menu controller

1. Follow the procedures described in [Add a toolbar to a tool window](../extensibility/adding-a-toolbar-to-a-tool-window.md) to create a tool window that has a toolbar.

2. In *TWTestCommandPackage.vsct*, go to the Symbols section. In the GuidSymbol element named **guidTWTestCommandPackageCmdSet**, declare your menu controller, menu controller group, and three menu items.

    ```xml
    <IDSymbol name="TestMenuController" value="0x1300" /><IDSymbol name="TestMenuControllerGroup" value="0x1060" /><IDSymbol name="cmdidMCItem1" value="0x0130" /><IDSymbol name="cmdidMCItem2" value="0x0131" /><IDSymbol name="cmdidMCItem3" value="0x0132" />
    ```

3. In the Menus section, after the last menu entry, define the menu controller as a menu.

    ```xml
    <Menu guid="guidTWTestCommandPackageCmdSet" id="TestMenuController" priority="0x0100" type="MenuController">
        <Parent guid="guidTWTestCommandPackageCmdSet" id="TWToolbarGroup" />
        <CommandFlag>IconAndText</CommandFlag>
        <CommandFlag>TextChanges</CommandFlag>
        <CommandFlag>TextIsAnchorCommand</CommandFlag>
        <Strings>
            <ButtonText>Test Menu Controller</ButtonText>
            <CommandName>Test Menu Controller</CommandName>
        </Strings>
    </Menu>
    ```

    The `TextChanges` and `TextIsAnchorCommand` flags must be included to enable the menu controller to reflect the last selected command.

4. In the Groups section, after the last group entry, add the menu controller group.

    ```xml
    <Group guid="guidTWTestCommandPackageCmdSet" id="TestMenuControllerGroup" priority="0x000">
        <Parent guid="guidTWTestCommandPackageCmdSet" id="TestMenuController" />
    </Group>
    ```

    By setting the menu controller as the parent, any commands placed in this group appear in the menu controller. The `priority` attribute is omitted, which sets it to the default value of 0, because it is the only group on the menu controller.

5. In the Buttons section, after the last button entry, add a Button element for each of your menu items.

    ```xml
    <Button guid="guidTWTestCommandPackageCmdSet" id="cmdidMCItem1" priority="0x0000" type="Button">
        <Parent guid="guidTWTestCommandPackageCmdSet" id="TestMenuControllerGroup" />
        <Icon guid="guidImages" id="bmpPic1" />
        <CommandFlag>IconAndText</CommandFlag>
        <Strings>
            <ButtonText>MC Item 1</ButtonText>
            <CommandName>MC Item 1</CommandName>
        </Strings>
    </Button>
    <Button guid="guidTWTestCommandPackageCmdSet" id="cmdidMCItem2" priority="0x0100" type="Button">
        <Parent guid="guidTWTestCommandPackageCmdSet" id="TestMenuControllerGroup" />
        <Icon guid="guidImages" id="bmpPic2" />
        <CommandFlag>IconAndText</CommandFlag>
        <Strings>
            <ButtonText>MC Item 2</ButtonText>
            <CommandName>MC Item 2</CommandName>
        </Strings>
    </Button>
    <Button guid="guidTWTestCommandPackageCmdSet" id="cmdidMCItem3" priority="0x0200" type="Button">
        <Parent guid="guidTWTestCommandPackageCmdSet" id="TestMenuControllerGroup" />
        <Icon guid="guidImages" id="bmpPicSearch" />
        <CommandFlag>IconAndText</CommandFlag>
        <Strings>
            <ButtonText>MC Item 3</ButtonText>
            <CommandName>MC Item 3</CommandName>
        </Strings>
    </Button>
    ```

6. At this point, you can look at the menu controller. Build the project and start debugging. You should see the experimental instance.

   1. On the **View / Other Windows** menu, open **Test ToolWindow**.

   2. The menu controller appears on the toolbar in the tool window.

   3. Click the arrow on the right-hand side of the menu controller to see the three possible commands.

      Notice that when you click a command, the title of the menu controller changes to display that command. In the next section, we will add the code to activate these commands.

## Implement the menu controller commands

1. In *TWTestCommandPackageGuids.cs*, add command IDs for your three menu items after the existing command IDs.

    ```csharp
    public const int cmdidMCItem1 = 0x130;
    public const int cmdidMCItem2 = 0x131;
    public const int cmdidMCItem3 = 0x132;
    ```

2. In *TWTestCommand.cs*, add the following code at the top of the `TWTestCommand` class.

    ```csharp
    private int currentMCCommand; // The currently selected menu controller command
    ```

3. In the TWTestCommand constructor, after the last call to the `AddCommand` method, add code to route the events for each command through the same handlers.

    ```csharp
    for (int i = TWTestCommandPackageGuids.cmdidMCItem1; i <=
        TWTestCommandPackageGuids.cmdidMCItem3; i++)
    {
        CommandID cmdID = new
        CommandID(new Guid(TWTestCommandPackageGuids.guidTWTestCommandPackageCmdSet), i);
        OleMenuCommand mc = new OleMenuCommand(new
          EventHandler(OnMCItemClicked), cmdID);
        mc.BeforeQueryStatus += new EventHandler(OnMCItemQueryStatus);
        commandService.AddCommand(mc);
        // The first item is, by default, checked. 
        if (TWTestCommandPackageGuids.cmdidMCItem1 == i)
        {
            mc.Checked = true;
            this.currentMCCommand = i;
        }
    }
    ```

4. Add an event handler to the **TWTestCommand** class to mark the selected command as checked.

    ```csharp
    private void OnMCItemQueryStatus(object sender, EventArgs e)
    {
        OleMenuCommand mc = sender as OleMenuCommand;
        if (null != mc)
        {
            mc.Checked = (mc.CommandID.ID == this.currentMCCommand);
        }
    }
    ```

5. Add an event handler that displays a MessageBox when the user selects a command on the menu controller:

    ```csharp
    private void OnMCItemClicked(object sender, EventArgs e)
    {
        OleMenuCommand mc = sender as OleMenuCommand;
        if (null != mc)
        {
            string selection;
            switch (mc.CommandID.ID)
            {
                case c.cmdidMCItem1:
                    selection = "Menu controller Item 1";
                    break;

                case TWTestCommandPackageGuids.cmdidMCItem2:
                    selection = "Menu controller Item 2";
                    break;

                case TWTestCommandPackageGuids.cmdidMCItem3:
                    selection = "Menu controller Item 3";
                    break;

                default:
                    selection = "Unknown command";
                    break;
            }
            this.currentMCCommand = mc.CommandID.ID;

            IVsUIShell uiShell =
              (IVsUIShell) ServiceProvider.GetService(typeof(SVsUIShell));
            Guid clsid = Guid.Empty;
            int result;
            uiShell.ShowMessageBox(
                    0,
                    ref clsid,
                    "Test Tool Window Toolbar Package",
                    string.Format(CultureInfo.CurrentCulture,
                                 "You selected {0}", selection),
                    string.Empty,
                    0,
                    OLEMSGBUTTON.OLEMSGBUTTON_OK,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
                    OLEMSGICON.OLEMSGICON_INFO,
                    0,
                    out result);
        }
    }
    ```

## Testing the menu controller

1. Build the project and start debugging. You should see the experimental instance.

2. Open the **Test ToolWindow** on the **View / Other Windows** menu.

    The menu controller appears in the toolbar in the tool window and displays **MC Item 1**.

3. Click the menu controller button to the left of the arrow.

    You should see three items, the first of which is selected and has a highlight box around its icon. Click **MC Item 3**.

    A dialog box appears with the message **You selected Menu controller Item 3**. Notice that the message corresponds to the text on the menu controller button. The menu controller button now displays **MC Item 3**.

## Related content
- [Adding a toolbar to a tool window](../extensibility/adding-a-toolbar-to-a-tool-window.md)
- [Adding a toolbar](../extensibility/adding-a-toolbar.md)
