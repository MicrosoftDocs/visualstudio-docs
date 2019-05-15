---
title: "How to: Debug an ActiveX Control | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vc.controls.debug"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "testing [Visual Studio], test containers"
  - "ActiveX control container debugging [Visual Studio]"
  - "debugging ActiveX controls"
  - "data-bound controls, ActiveX"
  - "test container"
  - "containers, specifying for debug sessions"
  - "ActiveX controls, debugging"
  - "testing [Visual Studio], ActiveX controls"
ms.assetid: bbc02cf7-a7e6-44fe-99af-87a43e1d7251
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug an ActiveX Control
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 To debug your ActiveX control, you must specify a container (executable) for the control to run in.  
  
### To specify a container for the debug session  
  
1. In Solution Explorer, select the project.  
  
2. From the **View** menu, choose **Property Pages**.  
  
3. In the **Project Property Pages** dialog box, open the **Configuration Properties** folder, and select **Debugging**.  
  
4. Under the **Debugging** category, locate the **Command** property.  
  
5. Specify the path name for the container. For example, C:\Program Files\Internet Explorer\IEXPLORE.EXE.  
  
6. If you specify Internet Explorer as the container and you are using Active Desktop, type `/new` in the **Command Arguments** box.  
  
7. Click **OK**.  
  
     If you do not specify a container in the **Project Property Pages** dialog box, you can specify the container when you begin debugging. When you select an execution command to start debugging, the [Executable for Debugging Session Dialog Box](../debugger/executable-for-debugging-session-dialog-box.md) appears. Specify the path name of the container in the dialog box.  
  
## See Also  
 [ActiveX Controls](https://msdn.microsoft.com/library/52aaec4d-3889-402e-b57d-758078f8ac57)   
 [Testing Properties and Events with Test Container](https://msdn.microsoft.com/library/626867cf-fe53-4c30-8973-55bb93ef3917)   
 [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)   
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)
