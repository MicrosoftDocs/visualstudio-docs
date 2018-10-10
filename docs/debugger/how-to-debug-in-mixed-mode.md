---
title: "How to: Debug in Mixed Mode | Microsoft Docs"
ms.custom: ""
ms.date: "06/19/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging DLLs"
  - "debugging [Visual Studio], mixed-mode"
  - "mixed-mode debugging"
ms.assetid: 2859067d-7fcc-46b0-a4df-8c2101500977
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# How to: Debug in mixed mode
The following procedures describe how to debug managed and native code together, also known as mixed-mode debugging. You can enable both managed and native debuggers in an app or DLL project's **Property** pages. The settings differ depending on whether you start debugging from the managed project or from the native project. 

There are two different mixed-mode debugging scenarios, depending on whether a DLL and its calling app are written in native or managed code:  
  
1. The app that calls your DLL is written in managed code, and your DLL is in native code. For a tutorial that walks you through this scenario in more detail, see [Debug managed and native code](../debugger/how-to-debug-managed-and-native-code.md).
   
2. The app that calls your DLL is written in native code, and your DLL is managed code. 
  
If you don't have access to a calling app's project, you can debug a DLL from the DLL project. You don't need mixed mode to debug just the DLL project. For more information, see [How to: Debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md). 

> [!NOTE]
> The dialog boxes and commands you see might differ from the ones in this article, depending on your Visual Studio settings or edition. To change your settings, choose **Tools** > **Import and Export Settings**. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## To enable mixed-mode debugging for a C++ app  
  
1. Select the C++ project in **Solution Explorer** and click the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.
   
1. In the **\<Project> Property Pages** dialog box, expand **Configuration Properties**, and then select **Debugging**.  
   
1. Set **Debugger Type** to **Managed and Native**. (You can also use **Mixed** or **Auto**, if available.)
   
1. Select **OK**.
   
   ![Enable mixed mode debugging](../debugger/media/dbg-mixed-mode-from-native.png "Enable mixed mode debugging")

## To enable mixed-mode debugging for a C# or VB app  
  
1. Select the C# or VB project in **Solution Explorer** and select the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.
   
1. Select the **Debug** tab, and then select **Enable native code debugging**.
   
1. Use **File** > **Save Selected Items** or **Ctrl+S** to save changes.

   ![Enable native code debugging](../debugger/media/dbg-mixed-mode-from-csharp.png "Enable native code debugging")
  
## See also  
 [How to: Debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md)