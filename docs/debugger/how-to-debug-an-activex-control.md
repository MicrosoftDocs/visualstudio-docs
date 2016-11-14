---
title: "How to: Debug an ActiveX Control | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Debug an ActiveX Control
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 To debug your ActiveX control, you must specify a container (executable) for the control to run in.  
  
### To specify a container for the debug session  
  
1.  In Solution Explorer, select the project.  
  
2.  From the **View** menu, choose **Property Pages**.  
  
3.  In the **Project Property Pages** dialog box, open the **Configuration Properties** folder, and select **Debugging**.  
  
4.  Under the **Debugging** category, locate the **Command** property.  
  
5.  Specify the path name for the container. For example, C:\Program Files\Internet Explorer\IEXPLORE.EXE.  
  
6.  If you specify Internet Explorer as the container and you are using Active Desktop, type `/new` in the **Command Arguments** box.  
  
7.  Click **OK**.  
  
     If you do not specify a container in the **Project Property Pages** dialog box, you can specify the container when you begin debugging. When you select an execution command to start debugging, the [Executable for Debugging Session Dialog Box](../debugger/executable-for-debugging-session-dialog-box.md) appears. Specify the path name of the container in the dialog box.  
  
## See Also  
 [ActiveX Controls](/visual-cpp/mfc/activex-controls)   
 [Testing Properties and Events with Test Container](/visual-cpp/mfc/testing-properties-and-events-with-test-container)   
 [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)   
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)