---
title: Customize menus and toolbars
description: Learn how to customize Visual Studio menus and toolbars, and also learn how to customize any commands included in the menus and toolbars.
ms.custom: SEO-VS-2020
ms.date: 11/24/2021
ms.topic: how-to
f1_keywords:
- vs.renametoolbar
- vs.customize.toolbars
- vs.buttoneditor
- vs.customize.commands
- vs.newtoolbar
helpviewer_keywords:
- captions, customizing toolbar
- custom toolbars [Visual Studio]
- command buttons, customizing toolbar
- labels, customizing toolbar
- images [Visual Studio], toolbar buttons
- buttons [Visual Studio], custom toolbars
- toolbars [Visual Studio], creating in the IDE
- icons [Visual Studio], customizing toolbar
- commands [Visual Studio], customizing environment
- customizing toolbars
- toolbars [Visual Studio], customizing
- toolbars [Visual Studio], customizing in the IDE
ms.assetid: b570ae2f-5302-45dc-9cc9-8d4d1ad50603
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# How to: Customize menus and toolbars in Visual Studio

You can customize Visual Studio not only by adding and removing toolbars and menus on the menu bar, but also by adding and removing commands on any given toolbar or menu.

> [!TIP]
> To learn more about how to personalize the toolbar so that you can make it yours, see our recent blog post, [**Optimizing toolbars for your workflow**](https://devblogs.microsoft.com/visualstudio/optimizing-toolbars-for-your-workflow/).

## Add, remove, or move a menu on the menu bar

1. On the menu bar, choose **Tools** > **Customize**.

     The **Customize** dialog box opens.

2. On the **Commands** tab, leave the **Menu bar** option button selected, leave **Menu Bar** selected in the list next to that option, and then perform one of the following sets of steps:

    - To add a menu, choose the **Add New Menu** button, choose the **Modify Selection** button, and then name the menu that you want to add.

        ::: moniker range="vs-2017"
        ![Customize dialog box showing how to add a menu](../ide/media/addmenu.png)
        ::: moniker-end

    - To remove a menu, choose it in the **Controls** list, and then choose the **Delete** button.

    - To move a menu within the menu bar, choose the menu in the **Controls** list, and then choose the **Move Up** or **Move Down** button.

## Add, remove, or move a toolbar

1. On the menu bar, choose **Tools** > **Customize**.

     The **Customize** dialog box opens.

2. On the **Toolbar** tab, perform one of the following sets of steps:

    - To add a toolbar, choose the **New** button, specify a name for the toolbar that you want to add, and then choose the **OK** button.

        ::: moniker range="vs-2017"
        ![Customize dialog box showing how to add a toolbar](../ide/media/addtoolbar.png)
        ::: moniker-end

    - To remove a custom toolbar, choose it in the **Toolbars** list, and then choose the **Delete** button.

        > [!IMPORTANT]
        > You can delete toolbars that you create but not default toolbars.

    - To move a toolbar to a different docking location, choose it in the **Toolbars** list, choose the **Modify Selection** button, and then choose a location in the list that appears.

        You can also drag a toolbar by its left edge to move it anywhere in the main docking area.

        > [!NOTE]
        > For more information about how to improve the usability and accessibility of toolbars, see [How to: Set IDE accessibility options](../ide/reference/how-to-set-ide-accessibility-options.md).

## <a name="customizing_menu">Customize a menu or a toolbar</a>

> [!WARNING]
> After you customize a toolbar or menu, make sure that its check box remains selected in the **Customize** dialog box. Otherwise, your changes won't persist after you close and reopen Visual Studio.

1. On the menu bar, choose **Tools** > **Customize**.

    The **Customize** dialog box opens.

2. On the **Commands** tab, choose the option button for the type of element that you want to customize.

3. In the list for that type of element, choose the menu or toolbar that you want to customize, and then perform one of the following sets of steps:

    - To add a command, choose the **Add Command** button.

        In the **Add Command** dialog box, choose an item in the **Categories** list, choose an item in the **Commands** list, and then choose the **OK** button.

        ::: moniker range="vs-2017"
        ![Add Command dialog box in Visual Studio](../ide/media/addcommand.png)
        ::: moniker-end

    - To delete a command, choose it in the **Controls** list, and then choose the **Delete** button.

    - To reorder commands, choose a command in the **Controls** list, and then choose the **Move Up** or **Move Down** button.

    - To group commands under a horizontal line, choose the first command in the **Controls** list, choose the **Modify Selection** button, and then choose **Begin a Group** in the menu that appears.

## Reset a menu or a toolbar

1. On the menu bar, choose **Tools** > **Customize**.

    The **Customize** dialog box opens.

2. On the **Commands** tab, choose the option button for the type of element that you want to reset.

3. In the list for that type of element, choose the menu or toolbar that you want to reset.

4. Choose the **Modify Selection** button, and then choose **Reset** in the menu that appears.

    You can also reset all menus and toolbars by choosing the **Reset All** button.

## See also

- [Personalize the IDE](../ide/personalizing-the-visual-studio-ide.md)
- [Customize the editor](../ide/how-to-change-text-case-in-the-editor.md)
