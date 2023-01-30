---
title: Customize menus and toolbars
description: Learn how to customize Visual Studio menus and toolbars, and also learn how to customize any commands included in the menus and toolbars.
ms.custom: SEO-VS-2020
ms.date: 01/27/2023
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

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can customize Visual Studio not only by adding and removing toolbars and menus on the menu bar, but also by adding and removing commands on any given toolbar or menu.

> [!TIP]
> To learn more about how to personalize the toolbar so that you can make it yours, see our recent blog post, [**Optimizing toolbars for your workflow**](https://devblogs.microsoft.com/visualstudio/optimizing-toolbars-for-your-workflow/).

## Add, remove, or move a menu on the menu bar

1. On the menu bar, select **Tools** > **Customize**.

     The **Customize** dialog box opens.

2. On the **Commands** tab, leave the **Menu bar** option button selected, leave **Menu Bar** selected in the list next to that option, and then perform one of the following sets of steps:

    - To add a menu, select the **Add New Menu** button, select the **Modify Selection** button, and then name the menu that you want to add.

    - To remove a menu, select it in the **Preview** list, and then select the **Delete** button.

    - To move a menu within the menu bar, select the menu in the **Preview** list, and then select the **Move Up** or **Move Down** button.

## Add, remove, or move a toolbar

1. On the menu bar, select **Tools** > **Customize**.

     The **Customize** dialog box opens.

2. On the **Toolbars** tab, perform one of the following sets of steps:

    - To add a toolbar, select the **New** button, specify a name for the toolbar that you want to add, and then select the **OK** button.

    - To remove a custom toolbar, select it in the **Toolbars** list, and then select the **Delete** button.

        > [!IMPORTANT]
        > You can delete toolbars that you create but not default toolbars.

    - To move a custom toolbar to a different docking location, drag the toolbar by its left edge and move it anywhere in the main docking area.

        > [!NOTE]
        > For more information about how to improve the usability and accessibility of text, toolbars, and more, see [Set accessibility options](how-to-change-fonts-and-colors-in-visual-studio.md#set-accessibility-options).

## <a name="customizing_menu">Customize a menu or a toolbar</a>

> [!WARNING]
> After you customize a toolbar or menu, make sure that its check box remains selected in the **Customize** dialog box. Otherwise, your changes won't persist after you close and reopen Visual Studio.

1. On the menu bar, select **Tools** > **Customize**.

    The **Customize** dialog box opens.

2. On the **Commands** tab, select the option button for the type of element that you want to customize.

3. In the list for that type of element, select the menu or toolbar that you want to customize, and then perform one of the following sets of steps:

    - To add a command, select the **Add Command** button.

        In the **Add Command** dialog box, select an item in the **Categories** list, select an item in the **Commands** list, and then select the **OK** button.

    - To delete a command, select it in the **Controls** list, and then select the **Delete** button.

    - To reorder commands, select a command in the **Controls** list, and then select the **Move Up** or **Move Down** button.

    - To group commands under a horizontal line, select the first command in the **Preview** list, select the **Modify Selection** button, and then select **Begin a Group**.

## Reset a menu or a toolbar

1. On the menu bar, select **Tools** > **Customize**.

    The **Customize** dialog box opens.

2. On the **Commands** tab, select the option button for the type of element that you want to reset.

3. In the list for that type of element, select the menu or toolbar that you want to reset.

4. Select the **Modify Selection** button, and then select **Reset** in the menu that appears.

    You can also reset all menus and toolbars by choosing the **Reset All** button.

## See also

- [Personalize the IDE](../ide/personalizing-the-visual-studio-ide.md)
- [Customize the editor](../ide/how-to-change-text-case-in-the-editor.md)
