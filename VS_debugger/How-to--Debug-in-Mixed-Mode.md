---
title: "How to: Debug in Mixed Mode"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2859067d-7fcc-46b0-a4df-8c2101500977
caps.latest.revision: 29
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
# How to: Debug in Mixed Mode
The following procedures describe how to debug both managed and native code, also known as mixed-mode debugging. There are two scenarios for doing so, depending on whether the DLL or the application is written in native code:  
  
-   The calling application that calls your DLL is written in native code. In this case your DLL is managed, and both managed and native debuggers must be enabled to debug both. You can check this in the **<Project\> Property Pages** dialog box. How you do this depends on whether you start debugging from the DLL project or the calling application project.  
  
-   The calling application that calls your DLL is written in managed code and your DLL is written in native code.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To enable mixed-mode debugging  
  
1.  In **Solution Explorer**, select the project.  
  
2.  On the **View** menu, click **Property Pages**.  
  
3.  In the **<Project\> Property Pages** dialog box, expand the **Configuration Properties** node, and then select **Debugging**.  
  
4.  Set **Debugger Type** to **Mixed** or **Auto**.  
  
## See Also  
 [How to: Debug from a DLL Project](../VS_debugger/How-to--Debug-from-a-DLL-Project.md)