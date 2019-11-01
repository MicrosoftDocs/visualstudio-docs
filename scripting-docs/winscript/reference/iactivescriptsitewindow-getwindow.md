---
title: "IActiveScriptSiteWindow::GetWindow | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteWindow.GetWindow"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteWindow_GetWindow"
ms.assetid: 6284e38c-9dfb-4d69-903d-f243f78c0331
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteWindow::GetWindow
Retrieves the handle to a window that can act as the owner of a pop-up window that the scripting engine must display.  
  
## Syntax  
  
```cpp
HRESULT GetWindow(  
    HWND *phwnd  // address of variable for window handle  
);  
```  
  
#### Parameters  
 `phwnd`  
 [out] Address of a variable that receives the window handle.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_FAIL` if an error occurred.  
  
## Remarks  
 This method is similar to the `IOleWindow::GetWindow` method.  
  
## See also  
 [IActiveScriptSiteWindow](../../winscript/reference/iactivescriptsitewindow.md)