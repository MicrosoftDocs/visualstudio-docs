---
title: "SCRIPTUICITEM Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: fbf01f1b-5d7f-4d92-8d10-3da65e352d93
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTUICITEM Enumeration
Represents the type of UI item. Used in the [IActiveScriptSiteUIControl::GetUIBehavior Method](../../winscript/reference/iactivescriptsiteuicontrol-getuibehavior-method.md).  
  
## Syntax  
  
```vb  
typedef enum tagSCRIPTUICITEM {     SCRIPTUICITEM_INPUTBOX = 1,     SCRIPTUICITEM_MSGBOX = 2,     } SCRIPTUICITEM;   
```  
  
## Enumeration Values  
  
|||  
|-|-|  
|SCRIPTUICITEM_INPUTBOX|An input control.|  
|SCRIPTUICITEM_MSGBOX|A message box.|