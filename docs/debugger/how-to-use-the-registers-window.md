---
title: "How to: Use the Registers Window | Microsoft Docs"
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
  - "vs.debug.registers"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "registers, debugging"
  - "register contents"
  - "flags, Registers window"
  - "register groups"
  - "debugging [Visual Studio], Registers window"
  - "Registers window"
ms.assetid: 2918ffa2-562f-40d6-9053-ef321bbeb767
caps.latest.revision: 37
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
# How to: Use the Registers Window
The Registers window is available only if address-level debugging is enabled in the **Options** dialog box, **Debugging** node, **General** category.  
  
 The **Registers** window displays register contents. If you keep the **Registers** window open as you step through your program, you can see register values change as your code executes. Values that have changed recently are displayed in red. You can edit register values. For more information, see [How to: Edit a Register Value](../debugger/how-to-edit-a-register-value.md).  
  
 To reduce clutter, the **Registers** window organizes registers into groups, which vary according to platform and processor type. You can display or hide groups as you want. For more information, see [How to: Display and Hide Register Groups](../debugger/how-to-display-and-hide-register-groups.md).  
  
 For a high-level introduction to concepts behind registers and the Registers window, see [Debugging Basics: Registers Window](../debugger/debugging-basics-registers-window.md).  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To display the Registers window  
  
-   On the **Debug** menu, choose **Windows**, and then choose **Registers**.  
  
     The debugger must be running or in break mode.  
  
    > [!NOTE]
    >  Register information is not available for script or SQL applications.  
  
## See Also  
 [Debugging Basics: Registers Window](../debugger/debugging-basics-registers-window.md)   
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)   
 [Debugging Basics: Registers Window](../debugger/debugging-basics-registers-window.md)