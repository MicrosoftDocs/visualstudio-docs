---
title: "IDebugDocumentContext::EnumCodeContexts | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentContext.EnumCodeContexts"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentContext::EnumCodeContexts"
ms.assetid: fb0aa64e-c458-4ef1-bcd8-5cebdc972549
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentContext::EnumCodeContexts
Enumerates the code contexts associated with this document context.  
  
## Syntax  
  
```cpp
HRESULT EnumCodeContexts(  
   IEnumDebugCodeContexts**  ppescc  
);  
```  
  
#### Parameters  
 `ppescc`  
 [out] The code contexts associated with this document context.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 A document is usually associated with only one code context, unless the document is an include file or a template.  
  
## See also  
 [IDebugDocumentContext Interface](../../winscript/reference/idebugdocumentcontext-interface.md)