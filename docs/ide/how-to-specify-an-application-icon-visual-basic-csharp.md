---
title: 'Set an app icon (Visual Basic, C#)'
description: Learn how to specify the icon that File Explorer and the Windows taskbar display for a compiled Visual Basic or C# application.
ms.date: 09/27/2024
ms.topic: how-to
helpviewer_keywords:
- icons [Visual Studio], application
- application properties [Visual Studio], icons
- application icons [Visual Studio]
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to specify an icon for my application so that users see the icon in the taskbar and File Explorer.
---

# Specify an application icon (Visual Basic, C#)

The `Icon` property for a project specifies the icon file (*.ico*) that displays for the compiled application in File Explorer and the Windows taskbar. This article describes how to specify an application icon. 

You can access the `Icon` property from the **Application** section of the Project Designer, which contains a list of icons that have been added to a project either as resources or as content files.

> [!NOTE]
> After you set the icon property for an application, you might also set the `Icon` property of each Window or Form in the application. For information about window icons for Windows Presentation Foundation (WPF) standalone applications, see <xref:System.Windows.Window.Icon%2A> property.

## To specify an application icon

Complete these steps to specify an application icon. 

::: moniker range=">=vs-2022"

1. In Solution Explorer, select a [Project node](use-solution-explorer.md#solution-explorer-ui) (not the Solution node).

1. On the menu bar, select **Project** > **Properties**.

    > [!TIP]
    > You might see your project's file name when you view **Project** > **Properties**. For example, if you're working on a project that's named "Calculator", Visual Studio displays **Project** > **Calculator Properties**.

1. The Project Designer appears. In the **Application** section, select one of the following:
   - For C#, select **Win32 Resources**. 
   - For Visual Basic, select **Resources**.

1. In the **Icon** section, select the **Browse** button to browse to the location of the icon file that you want to use.

::: moniker-end

::: moniker range="<=vs-2019" 

1. In Solution Explorer, select a [project node](use-solution-explorer.md#solution-explorer-ui) (not the Solution node).

1. On the menu bar, select **Project** > **Properties**.

    > [!TIP]
    > You might see your project's file name when you view **Project** > **Properties**. For example, if you're working on a project that's named "Calculator", Visual Studio displays **Project** > **Calculator Properties**.

1. When the Project Designer appears, select the **Application** tab.

1. In the **Icon** section, choose an icon (*.ico*) file by using either of the following methods:
    - For Visual Basic, in the **Icon** list, choose an icon file.
    - For C#, near the **Icon** list, select the **Browse** button to browse to the location of the icon file that you want to use.

::: moniker-end

## Related content

- [Application page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)
- [Application page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)
- [How to: Create Resources (C++)](/cpp/windows/how-to-create-a-resource-script-file)
- [Project Resource Files (C++)](/cpp/build/reference/resource-files-cpp)
