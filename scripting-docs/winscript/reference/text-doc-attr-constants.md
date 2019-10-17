---
title: "TEXT_DOC_ATTR Constants | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "TEXT_DOC_ATTR"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "TEXT_DOC_ATTR constants"
ms.assetid: fd9c53a4-8f73-4c6a-abe5-6b831ecd5b1e
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# TEXT_DOC_ATTR Constants
Describe the attributes of the document.  
  
## Syntax  
  
```cpp
typedef DWORD TEXT_DOC_ATTR;  
```  
  
## Constants  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|TEXT_DOC_ATTR_READONLY|0x00000001|The document is read-only.|  
|TEXT_DOC_ATTR_TYPE_PRIMARY|0x00000002|The document is the primary file of this document tree.|  
|TEXT_DOC_ATTR_TYPE_WORKER|0x00000004|The document is a worker.|  
|TEXT_DOC_ATTR_TYPE_SCRIPT|0x00000008|The document is a script file.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)