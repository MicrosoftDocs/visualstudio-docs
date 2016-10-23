---
title: "How to: Debug an Executable Not Part of a Visual Studio Solution"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3ea176e8-1ce5-42c4-b7a2-abe3a2765033
caps.latest.revision: 23
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Debug an Executable Not Part of a Visual Studio Solution
Sometimes, you may want to debug an executable that is not part of a Visual Studio project. It may be an executable you created outside of Visual Studio or an executable you received from someone else.  
  
 The usual answer to this problem is to start the executable outside of Visual Studio and attach to it using the Visual Studio debugger. For more information, see[Attach to Running Processes](../VS_debugger/Attach-to-Running-Processes-with-the-Visual-Studio-Debugger.md).  
  
 Attaching to an application requires some manual steps, so it takes a few seconds. This slight delay means that attaching will not help if you are trying to debug a problem that occurs during startup. Also, if you are debugging a program that does not wait for user input and finishes quickly, you may not have time to attach to it. If you have Visual C++ installed, you can create an EXE project for such a program.  
  
### To create an EXE project for an existing executable  
  
1.  On the **File** menu, click **Open** and select **Project**.  
  
2.  In the **Open Project** dialog box, click the drop-down list next to the **File name** box, and select **All Project Files**.  
  
3.  Locate the executable, and click **OK**.  
  
     This creates a temporary solution that contains the executable.  
  
### To import an executable into a Visual Studio solution  
  
1.  On the **File** menu, point to **Add Project**, and then click **Existing Project**.  
  
2.  In the **Add Existing Project** dialog box, click the drop-down list next to the **File name** box, and select **All Project Files**.  
  
3.  Locate and select the executable.  
  
4.  Click **OK**.  
  
5.  Start the executable by choosing an execution command, such as **Start**, from the **Debug** menu.  
  
    > [!NOTE]
    >  Not all programming languages support EXE projects. Install Visual C++ if you need to use this feature.  
  
     When you are debugging an executable without the source code, the available debugging features are limited, whether you attach to a running executable or add the executable to a Visual Studio solution. If the executable was built without debug information in a compatible format, available features are further limited. If you have the source code, the best approach is to import the source code into Visual Studio and create a debug build of the executable in Visual Studio.  
  
## See Also  
 [Debugger Settings and Preparation](../VS_debugger/Debugger-Settings-and-Preparation.md)   
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [DBG Files](assetId:///91e449e9-8b65-4123-960f-2107cd1f1cfd)