---
title: Creating Reusable Groups of Buttons
description: Learn how to create a command group, which is a collection of commands that appear together on a menu or toolbar.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- button groups, creating in VSPackages
- VSPackages, creating reusable button groups
- buttons, creating reusable groups
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create reusable groups of buttons

A command group is a collection of commands that always appear together on a menu or toolbar. Any command group can be re-used by assigning it to different parent menus in the CommandPlacements section of the *.vsct* file.

 Command groups typically contain buttons, but they can also contain other menus or combo boxes.

## To create a reusable group of buttons

1. Create a VSIX project named `ReusableButtons`. For more information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

2. When the project opens, add a custom command item template named **ReusableCommand**. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item** dialog, go to **Visual C#** > **Extensibility** and select **Custom Command**. In the **Name** field at the bottom of the window, change the command file name to *ReusableCommand.cs*.

3. In the *.vsct* file, go to the Symbols section and find the GuidSymbol element that contains groups and commands for the project. It should be named guidReusableCommandPackageCmdSet.

4. Add an IDSymbol for each button that you will add to the group, as in the following example.

    ```xml
    <GuidSymbol name="guidReusableCommandPackageCmdSet" value="{7f383b2a-c6b9-4c1d-b4b8-a26dc5b60ca1}">
        <IDSymbol name="MyMenuGroup" value="0x1020" />
        <IDSymbol name="ReusableCommandId" value="0x0100" />
        <IDSymbol name="SecondReusableCommandId" value="0x0200" />
    </GuidSymbol>
    ```

     By default, the command item template creates a group named **MyMenuGroup** and a button that has the name that you provided, together with an IDSymbol entry for each.

5. In the Groups section, create a Group element that has the same GUID and ID attributes as the ones given in the Symbols section. You can also use an existing group, or use the entry that is provided by the command template, as in the following example. This group appears on the **Tools** menu

    ```xml
    <Groups>
        <Group guid="guidReusableCommandPackageCmdSet" id="MyMenuGroup" priority="0x0600">
              <Parent guid="guidSHLMainMenu" id="IDM_VS_MENU_TOOLS"/>
        </Group>
    </Groups>
    ```

## To create a group of buttons for reuse

1. You can put a command or menu in a group either by using the group as a parent in the definition of the command or menu, or by putting the command or menu in the group by using the CommandPlacements section.

     In the Buttons section define a button that has your group as its parent, or use the button that is provided by the package template, as shown in the following example.

    ```xml
    <Button guid="guidReusableCommandPackageCmdSet" id="ReusableCommandId" priority="0x0100" type="Button">
        <Parent guid="guidReusableCommandPackageCmdSet" id="MyMenuGroup" />
        <Icon guid="guidImages" id="bmpPic1" />
        <Strings>
            <ButtonText>Invoke ReusableCommand</ButtonText>
        </Strings>
    </Button>
    ```

2. If a button must appear in more than one group, create an entry for it in the CommandPlacements section, which must be placed after the Commands section. Set the GUID and ID attributes of the CommandPlacement element to match those of the button you want to position, and then set the GUID and ID of its Parent element to those of the target group, as shown in the following example.

    ```xml
    <CommandPlacements>
        <CommandPlacement guid="guidReusableCommandPackageCmdSet" id="SecondReusableCommandId" priority="0x105">
          <Parent guid="guidReusableCommandPackageCmdSet" id="MyMenuGroup" />
        </CommandPlacement>
    </CommandPlacements>
    ```

    > [!NOTE]
    > The value of the Priority field determines the position of the command in the new command group. Priorities set in the CommandPlacement element override those set in the item definition. Commands that have lower priority values are displayed before commands that have higher priority values. Duplicate priority values are permitted, but the relative position of commands that have the same priority value cannot be guaranteed because the order in which the **devenv /setup** command creates the final interface from the registry may not be consistent.

## To put a reusable group of buttons on a menu

1. Create an entry in the `CommandPlacements` section. Set the GUID and ID of the `CommandPlacement` element to those of your group, and set the parent GUID and ID to those of the target location.

    The CommandPlacements section should be placed just after the Commands section:

   ```xml
   <CommandTable>
   ...
     <Commands>... </Commands>
     <CommandPlacements>... </CommandPlacements>
   ...
   </CommandTable>
   ```

    A command group can be included on more than one menu. The parent menu can be one that you created, one that is supplied by Visual Studio (as described in *ShellCmdDef.vsct* or *SharedCmdDef.vsct*), or one that is defined in another VSPackage. The number of parenting layers is unlimited as long as the parent menu is eventually connected to Visual Studio or to a shortcut menu that is displayed by a VSPackage.

    The following example puts the group on the **Solution Explorer** toolbar, to the right of the other buttons.

   ```xml
   <CommandPlacements>
       <CommandPlacement guid="guidReusableCommandPackageCmdSet" id="MyMenuGroup" priority="0xF00">
         <Parent guid="guidSHLMainMenu" id="IDM_VS_TOOL_PROJWIN"/>
       </CommandPlacement>
   </CommandPlacements>
   ```

   ```xml
   <CommandPlacements>
     <CommandPlacement guid="guidButtonGroupCmdSet" id="MyMenuGroup"
         priority="0x605">
       <Parent guid="guidSHLMainMenu" id="IDM_VS_MENU_TOOLS" />
     </CommandPlacement>
   </CommandPlacements>

   ```
