---
title: "IActiveScriptSiteWindow::EnableModeless | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteWindow.EnableModeless"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteWindow_EnableModeless"
ms.assetid: 83fe4f62-8e97-4f03-bc6f-d90aa888657d
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteWindow::EnableModeless
Causes the host to enable or disable its main window as well as any modeless dialog boxes.  
  
## Syntax  
  
```cpp
HRESULT EnableModeless(  
    BOOL fEnable  // enable flag  
);  
```  
  
#### Parameters  
 `fEnable`  
 [in] Flag that, if `TRUE`, enables the main window and modeless dialogs or, if `FALSE`, disables them.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_FAIL` if an error occurred.  
  
## Remarks  
 This method is identical to the `IOleInPlaceFrame::EnableModeless` method.  
  
 Calls to this method can be nested.  
  
## See also  
 [IActiveScriptSiteWindow](../../winscript/reference/iactivescriptsitewindow.md)