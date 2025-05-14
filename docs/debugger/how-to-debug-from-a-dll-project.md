---
title: Debug a DLL Project from the Project Itself
description: Learn how to start debugging a DLL project from the project itself by specifying the calling application in the project properties.
ms.date: 04/18/2025
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - DLL projects, debugging
  - debugging DLLs
  - DLLs, debugging projects
  - debugging [Visual Studio], DLLs
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
#customer intent: As a developer, I want to debug a DLL project from the project itself in Visual Studio, so I can trigger debug actions from the calling application.
---
# Debug from a DLL project in Visual Studio (C#, C++, Visual Basic, F#)

One way to debug a DLL project is to specify the calling app in the DLL project properties. This approach lets you start debugging from the DLL project itself. For this method to work, the app must call the same DLL in the same location as the one you configure. If the app finds and loads a different version of the DLL, that version doesn't contain your breakpoints. For other methods of debugging DLLs, see [Debugging DLL projects](../debugger/debugging-dll-projects.md).

If your managed app calls a native DLL, or your native app calls a managed DLL, you can debug both the DLL and the calling app. For more information, see [How to: Debug in mixed mode](../debugger/how-to-debug-in-mixed-mode.md).

Native and managed DLL projects have different settings to specify calling apps.

## Specify a calling app in a native DLL project

1. In **Solution Explorer**, right-click the C++ DLL project and select **Properties** (**Alt**+**Enter**).

1. In the **\<Project> Property Pages** dialog, set the **Configuration** field at the top to **Debug**.

1. Select **Configuration Properties** > **Debugging**.

1. Expand the **Debugger to launch** list and select **Local Windows Debugger** or **Remote Windows Debugger**.

1. In the **Command** or **Remote Command** box, add the fully qualified path and filename of the calling app, such as an *.exe* file.

   :::image type="content" source="../debugger/media/dbg-debugging-properties-dll.png" alt-text="Screenshot of the Debug Properties window in Visual Studio showing the value for the command." lightbox="../debugger/media/dbg-debugging-properties-dll.png":::

1. Add any necessary program arguments to the **Command Arguments** box.

1. Select **OK**.

::: moniker range=">= vs-2022"

## Specify a calling app in a managed DLL project (.NET Core, .NET 5+)

1. In **Solution Explorer**, right-click the C# or Visual Basic DLL project and select **Properties** (**Alt**+**Enter**).

1. In the Debug tab, select **Open Debug launch profiles UI**.

1. In the **Launch Profiles** dialog, select the **Create a new profile** icon, and select **Executable**.

   :::image type="content" source="../debugger/media/vs-2022/dbg-profile-create-new.png" border="false" alt-text="Screenshot of the UI to create a new debug profile in Visual Studio 2022." lightbox="../debugger/media/vs-2022/dbg-profile-create-new.png":::

1. In the new profile, under **Executable**, browse to the location of the executable (*.exe* file) and select it.

1. In the **Launch Profiles** dialog, note the name of the default profile, then select the profile and delete it.

1. Rename the new profile to the same name as the default profile.

   An alternate approach is to manually edit the *launchSettings.json* file. You want the first profile in the *launchSettings.json* file to match the name of the Class Library, and you want the profile listed first in the file.

::: moniker-end

## Specify a calling app in a managed DLL project (.NET Framework)

1. In **Solution Explorer**, right-click the C# or Visual Basic DLL project and select **Properties** (**Alt**+**Enter**).

1. Set the **Configuration** field at the top to **Debug**.

1. Under **Start action**:

   - For .NET Framework DLLs, select **Start external program**, and add the fully qualified path and name of the calling app.

   - Or, select **Start browser with URL** and enter the URL of a local ASP.NET app.

   ::: moniker range=">= vs-2022"

   - For .NET Core DLLs in Visual Basic, the **Debug** Properties page is different. Expand the **Launch** dropdown and select **Executable**, and then add the fully qualified path and name of the calling app in the **Executable** field.

   ::: moniker-end
   ::: moniker range="<= vs-2019"

   - For .NET Core DLLs, the **Debug** Properties page is different. Expand the **Launch** dropdown and select **Executable**, and then add the fully qualified path and name of the calling app in the **Executable** field.

   ::: moniker-end

1. Add any necessary command-line arguments in the **Command line arguments** or **Application arguments** field.

   :::image type="content" source="../debugger/media/dbg-debugging-properties-dll-csharp.png" border="false" alt-text="Screenshot of the C# Debug Properties window in Visual Studio." lightbox="../debugger/media/dbg-debugging-properties-dll-csharp.png":::

1. To save your changes, select **File** > **Save Selected Items** (**Ctrl**+**S**).

## Debug from the DLL project

1. Set breakpoints in the DLL project.

1. Right-click the DLL project and select **Set as Startup Project**.

1. Set the **Solutions Configuration** field at the top to **Debug**. Select **F5** and then select the green **Start** arrow, or select **Debug** > **Start Debugging**.

> [!TIP]
>
> - If debugging doesn't hit your breakpoints, make sure your DLL output (by default, the *\<project>\Debug* folder) is the target call location for the calling app.
>
> - If you want to break into code in a managed calling app from a native DLL, or vice versa, enable [mixed mode debugging](../debugger/how-to-debug-in-mixed-mode.md).
>
> - In some scenarios, you might need to instruct the debugger where to find the source code. For more information, see [Use the No Symbols Loaded/No Source Loaded pages](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md#use-the-no-symbols-loadedno-source-loaded-pages).

## Related content

- [Debugging DLL projects](../debugger/debugging-dll-projects.md)
- [Project settings for  C# debug configurations](../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project settings for a Visual Basic debug configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
- [Project settings for a C++ debug configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)
