---
title: Adding a Menu to the Visual Studio Menu Bar | Microsoft Docs
description: Learn how to add a menu to the menu bar of the Visual Studio integrated development environment (IDE).
ms.custom: SEO-VS-2020
ms.date: 3/16/2019
ms.topic: how-to
helpviewer_keywords:
- menus, creating top level
- top-level menus
ms.assetid: 58fc1a31-2aeb-441c-8e48-c7d5cbcfe501
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Add a menu to the Visual Studio menu bar

This walkthrough shows how to add a menu to the menu bar of the Visual Studio integrated development environment (IDE). The IDE menu bar contains menu categories such as **File**, **Edit**, **View**, **Window**, and **Help**.

Before adding a new menu to the Visual Studio menu bar, consider whether your commands should be placed within an existing menu. For more information about command placement, see [Menus and commands for Visual Studio](../extensibility/ux-guidelines/menus-and-commands-for-visual-studio.md).

Menus are declared in the *.vsct* file of the project. For more information about menus and *.vsct* files, see [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md).

By completing this walkthrough, you can create a menu named **Test Menu** that contains one command.

:::moniker range=">=vs-2019"
> [!NOTE]
> Starting in Visual Studio 2019, top level menus contributed by extensions are placed under the **Extensions** menu.
:::moniker-end

## Prerequisites

Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## Create a VSIX project that has a custom command item template

1. Create a VSIX project named `TopLevelMenu`. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".  For more information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

::: moniker range="vs-2017"

2. When the project opens, add a custom command item template named **TestCommand**. In the **Solution Explorer**, right-click the project node and select **Add** >  **New Item**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Custom Command**. In the **Name** field at the bottom of the window, change the command file name to *TestCommand.cs*.

::: moniker-end

::: moniker range=">=vs-2019"

2. When the project opens, add a custom command item template named **TestCommand**. In the **Solution Explorer**, right-click the project node and select **Add** >  **New Item**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Command**. In the **Name** field at the bottom of the window, change the command file name to *TestCommand.cs*.

::: moniker-end

## Create a menu on the IDE menu bar

::: moniker range="vs-2017"

1. In **Solution Explorer**, open *TestCommandPackage.vsct*.

    At the end of the file, there is a `<Symbols>` node that contains several `<GuidSymbol>` nodes. In the node named `guidTestCommandPackageCmdSet`, add a new symbol, as follows:

   ```xml
   <IDSymbol name="TopLevelMenu" value="0x1021"/>
   ```

2. Create an empty `<Menus>` node in the `<Commands>` node, just before `<Groups>`. In the `<Menus>` node, add a `<Menu>` node, as follows:

   ```xml
   <Menus>
         <Menu guid="guidTestCommandPackageCmdSet" id="TopLevelMenu" priority="0x700" type="Menu">
           <Parent guid="guidSHLMainMenu"
                   id="IDG_VS_MM_TOOLSADDINS" />
           <Strings>
             <ButtonText>Test Menu</ButtonText>
           </Strings>
       </Menu>
   </Menus>
   ```

    The `guid` and `id` values of the menu specify the command set and the specific menu in the command set.

    The `guid` and `id` values of the parent position the menu on the section of the Visual Studio menu bar that contains the Tools and Add-ins menus.

    The `<ButtonText>` element specifies that the text should appear in the menu item.

3. In the `<Groups>` section, find the `<Group>` and change the `<Parent>` element to point to the menu we just added:

   ```xml
   <Groups>
       <Group guid="guidTestCommandPackageCmdSet" id="MyMenuGroup" priority="0x0600">
           <Parent guid="guidTestCommandPackageCmdSet" id="TopLevelMenu"/>
       </Group>
   </Groups>
   ```

    This makes the group part of the new menu.

::: moniker-end

::: moniker range=">=vs-2019"

1. In **Solution Explorer**, open *TopLevelMenuPackage.vsct*.

    At the end of the file, there is a `<Symbols>` node that contains several `<GuidSymbol>` nodes. In the node named `guidTopLevelMenuPackageCmdSet`, add a new symbol, as follows:

   ```xml
   <IDSymbol name="TopLevelMenu" value="0x1021"/>
   ```

2. Create an empty `<Menus>` node in the `<Commands>` node, just before `<Groups>`. In the `<Menus>` node, add a `<Menu>` node, as follows:

   ```xml
   <Menus>
         <Menu guid="guidTopLevelMenuPackageCmdSet" id="TopLevelMenu" priority="0x700" type="Menu">
           <Parent guid="guidSHLMainMenu"
                   id="IDG_VS_MM_TOOLSADDINS" />
           <Strings>
             <ButtonText>Test Menu</ButtonText>
           </Strings>
       </Menu>
   </Menus>
   ```

    The `guid` and `id` values of the menu specify the command set and the specific menu in the command set.

    The `guid` and `id` values of the parent position the menu on the section of the Visual Studio menu bar that contains the Tools and Add-ins menus.

    The `<ButtonText>` element specifies that the text should appear in the menu item.

3. In the `<Groups>` section, find the `<Group>` and change the `<Parent>` element to point to the menu we just added:

   ```xml
   <Groups>
       <Group guid="guidTopLevelMenuPackageCmdSet" id="MyMenuGroup" priority="0x0600">
           <Parent guid="guidTopLevelMenuPackageCmdSet" id="TopLevelMenu"/>
       </Group>
   </Groups>
   ```

    This makes the group part of the new menu.

::: moniker-end

4. In the `<Buttons>` section, find the `<Button>` node. Then, in the `<Strings>` node, change the `<ButtonText>` element to `Test Command`.

    Notice that the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Package template has generated a `Button` element that has its parent set to `MyMenuGroup`. As a result, this command appears on your menu.

## Build and test the extension

1. Build the project and start debugging. An instance of the experimental instance should appear.

::: moniker range="vs-2017"

2. The menu bar in the experimental instance should contain a **Test Menu** menu.

::: moniker-end

::: moniker range=">=vs-2019"

2. The **Extensions** menu in the experimental instance should contain a **Test Menu** menu.

::: moniker-end

3. On the **Test Menu** menu, select **Test Command**.

    A message box should appear and display the message "TestCommand Inside TopLevelMenu.TestCommand.MenuItemCallback()".

## See also

- [Commands, menus, and toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
