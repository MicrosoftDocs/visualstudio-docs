---
title: 'Specify an application icon (Visual Basic, C#)'
description: Learn how to use the Icon property to specify the icon that File Explorer and the Windows taskbar displays for the compiled application.
ms.date: 07/07/2023
ms.topic: how-to
helpviewer_keywords:
- icons [Visual Studio], application
- application properties [Visual Studio], icons
- application icons [Visual Studio]
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Specify an application icon (Visual Basic, C#)

The `Icon` property for a project specifies the icon file (*.ico*) that's displayed for the compiled application in **File Explorer** and in the Windows taskbar.

You can access the `Icon` property from the **Application** section of the **Project Designer**, which contains a list of icons that have been added to a project either as resources or as content files.

> [!NOTE]
> After you set the icon property for an application, you might also set the `Icon` property of each **Window** or **Form** in the application. For information about window icons for Windows Presentation Foundation (WPF) standalone applications, see <xref:System.Windows.Window.Icon%2A> property.

## To specify an application icon

::: moniker range=">=vs-2022"

1. In **Solution Explorer**, choose a [Project node](use-solution-explorer.md#solution-explorer-ui) (not the **Solution** node).

1. On the menu bar, choose **Project** > **Properties**.

    > [!TIP]
    > You might see your project's file name when you view **Project** > **Properties**. For example, if you're working on a project that's named "Calculator", Visual Studio displays **Project** > **Calculator Properties**.

1. The **Project Designer** appears. Then, in the **Application** section, select one of the following:
   - For C#, select **Win32 Resources** 
   - For Visual Basic, select **Resources**

1. In the **Icon** section, select the **Browse** button to browse to the location of the icon file that you want.

::: moniker-end

::: moniker range="<=vs-2019" 

1. In **Solution Explorer**, choose a [project node](use-solution-explorer.md#solution-explorer-ui) (not the **Solution** node).

1. On the menu bar, choose **Project** > **Properties**.

    > [!TIP]
    > You might see your project's file name when you view **Project** > **Properties**. For example, if you're working on a project that's named "Calculator", Visual Studio displays **Project** > **Calculator Properties**.

1. When the **Project Designer** appears, select the **Application** tab.

1. In the **Icon** section, choose an icon (*.ico*) file by using either of the following methods:
    - For **Visual Basic**&mdash;In the **Icon** list, choose an icon (*.ico*) file.
    - For **C#**&mdash;Near the **Icon** list, select the **\<Browse...>** button, and then browse to the location of the icon file that you want.

::: moniker-end

## Related content

- [Application page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)
- [Application page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)
