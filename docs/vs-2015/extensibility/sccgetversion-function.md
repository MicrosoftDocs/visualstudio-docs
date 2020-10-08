---
title: "SccGetVersion Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SccGetVersion"
helpviewer_keywords: 
  - "SccGetVersion function"
ms.assetid: a6e786bf-744e-4272-9e21-0be44d23b1a1
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# SccGetVersion Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This function gets the version number of the Source Control Plug-in API supported by the source control plug-in.  
  
## Syntax  
  
```cpp#  
LONG SccGetVersion(void);  
```  
  
#### Parameters  
 None.  
  
## Return Value  
 A `LONG` data type that contains the version number of the supported Source Control Plug-in API:  
  
|WORD|Description|  
|----------|-----------------|  
|HIWORD|Major version|  
|LOWORD|Minor version|  
  
## Remarks  
 For example, if a source control plug-in supports version 1.3 of the Source Control Plug-in API, this function would return 0x0103.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
