---
title: "IActiveScriptSiteWindow | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptSiteWindow interface"
ms.assetid: 96d5c493-2c0b-47e2-848b-4a8dacdcd65c
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteWindow
This interface is implemented by hosts that support a user interface on the same object as [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) . Hosts that do not support a user interface, such as servers, would not implement the `IActiveScriptSiteWindow` interface. The scripting engine accesses this interface by calling `QueryInterface` from `IActiveScriptSite`.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptSiteWindow::GetWindow](../../winscript/reference/iactivescriptsitewindow-getwindow.md)|Retrieves the window handle that can act as the owner of a pop-up window that the scripting engine must display.|  
|[IActiveScriptSiteWindow::EnableModeless](../../winscript/reference/iactivescriptsitewindow-enablemodeless.md)|Causes the host to enable or disable its main window as well as any modeless dialog boxes.|  
  
## See also  
 [Active Script Interfaces](../../winscript/reference/active-script-interfaces.md)