---
title: "Class Tab, Window Properties Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Window Properties dialog box, Class Tab"
ms.assetid: eaec9f07-d580-436d-934d-76c4e59439aa
caps.latest.revision: 7
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Class Tab, Window Properties Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Use the **Class** tab to show information on the class of the selected window. To display the [Window Properties Dialog Box](../debugger/window-properties-dialog-box.md), move the focus to the [Windows View](../debugger/windows-view.md) window. Select any window node in the tree, then choose **Properties** from the **View** menu.  
  
 The following settings are available on the **Class** tab:  
  
|Entry|Description|  
|-----------|-----------------|  
|**Class Name**|The name (or ordinal number) of this window class.|  
|**Class Styles**|A combination of class style codes.|  
|**Class Bytes**|Application-specific data associated with this window class.|  
|**Class Atom**|The atom for the class returned by the **RegisterClass** call.|  
|**Instance Handle**|The instance handle of the module that registered the class. Instance handles are not unique.|  
|**Window Bytes**|The number of extra bytes associated with each window of this class. The meaning of these bytes is determined by the application. Expand the list box to see the byte values in DWORD format.|  
|**Window Proc**|The current address of the **WndProc** function for windows of this class. This differs from **Window Proc** on the **General** tab if the window is subclassed.|  
|**Menu Name**|The name of the main menu that is associated with windows of this class ("none" if there is no menu).|  
|**Icon Handle**|The handle for the icon that is associated with windows of this class ("none" if there is no icon).|  
|**Cursor Handle**|The handle for the cursor that is associated with windows of this class ("none" if there is no cursor).|  
|**Bkgnd Brush**|The handle for the background brush that is associated with windows of this class, or one of the predefined COLOR_* colors for painting the window background ("none" if there is no brush).|
