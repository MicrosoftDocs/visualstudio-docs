---
title: "DOCUMENTNAMETYPE Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "DOCUMENTNAMETYPE"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "DOCUMENTNAMETYPE enumeration"
ms.assetid: d36d550e-efb4-493d-8971-4de267005654
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DOCUMENTNAMETYPE Enumeration
Describes which type to get for a document.  
  
## Syntax  
  
```cpp
typedef enum tagDOCUMENTNAMETYPE {  
   DOCUMENTNAMETYPE_APPNODE,  
   DOCUMENTNAMETYPE_TITLE,  
   DOCUMENTNAMETYPE_FILE_TAIL,  
   DOCUMENTNAMETYPE_URL,  
DOCUMENTNAMETYPE_UNIQUE_TITLE,} DOCUMENTNAMETYPE;  
```  
  
## Members  
  
|Member|Description|  
|------------|-----------------|  
|DOCUMENTNAMETYPE_APPNODE|Gets the name as it appears in the application tree.|  
|DOCUMENTNAMETYPE_TITLE|Gets the name as it appears on the viewer title bar.|  
|DOCUMENTNAMETYPE_FILE_TAIL|Gets the file name without a path.|  
|DOCUMENTNAMETYPE_URL|Gets the URL of the document.|  
|DOCUMENTNAMETYPE_UNIQUE_TITLE|Gets the title appended with enumeration for identification.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)