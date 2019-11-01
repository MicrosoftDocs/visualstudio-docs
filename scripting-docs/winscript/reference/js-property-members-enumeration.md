---
title: "JS_PROPERTY_MEMBERS Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "JS_PROPERTY_MEMBERS"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 3b870e5c-5518-4073-8384-f0c9c1777d9e
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JS_PROPERTY_MEMBERS Enumeration
Flags to specify the type of information to return in a request for members of an object.  
  
## Syntax  
  
```cpp
enum JS_PROPERTY_MEMBERS{   JS_PROPERTY_MEMBERS_ALL = 0,   JS_PROPERTY_MEMBERS_ARGUMENTS = 1} JS_PROPERTY_MEMBERS;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`JS_PROPERTY_MEMBERS_ALL`|Represents a request to enumerate all members.|  
|`JS_PROPERTY_MEMBERS_ARGUMENTS`|Represents a request to enumerate arguments only.|  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)