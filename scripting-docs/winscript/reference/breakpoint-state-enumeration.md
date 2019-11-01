---
title: "BREAKPOINT_STATE Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "BREAKPOINT_STATE"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "BREAKPOINT_STATE enumeration"
ms.assetid: 7adc9341-129a-4948-9669-0906d545fd5c
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# BREAKPOINT_STATE Enumeration
Indicates the state of a breakpoint.  
  
## Syntax  
  
```cpp
typedef enum tagBREAKPOINT_STATE {  
   BREAKPOINT_DELETED = 0,  
   BREAKPOINT_DISABLED = 1,  
   BREAKPOINT_ENABLED = 2  
} BREAKPOINT_STATE;  
```  
  
## Members  
  
|Member|Description|  
|------------|-----------------|  
|BREAKPOINT_DELETED|The breakpoint no longer exists, but there are still references to it.|  
|BREAKPOINT_DISABLED|The breakpoint exists but is disabled.|  
|BREAKPOINT_ENABLED|The breakpoint exists and is enabled.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)