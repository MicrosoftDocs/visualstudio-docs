---
title: "SccGetVersion Function"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SccGetVersion"
helpviewer_keywords: 
  - "SccGetVersion function"
ms.assetid: a6e786bf-744e-4272-9e21-0be44d23b1a1
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# SccGetVersion Function
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