---
title: "IProvideExpressionContexts::EnumExpressionContexts | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IProvideExpressionContexts.EnumExpressionContexts"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IProvideExpressionContexts::EnumExpressionContexts"
ms.assetid: ec5f0065-00df-41e6-b480-4c04ba464872
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IProvideExpressionContexts::EnumExpressionContexts
Returns an enumerator of expression contexts known by this component.  
  
## Syntax  
  
```cpp
HRESULT EnumExpressionContexts(  
   IEnumDebugExpressionContexts**  ppedec  
);  
```  
  
#### Parameters  
 `ppedec`  
 [out] An enumerator of expression contexts known by this component.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The process debug manager uses this method to find all global expression contexts associated with a given thread.  
  
> [!NOTE]
> This method is called from within the thread of interest. It is up to the implementer to identify the current thread and return an appropriate enumerator.  
  
## See also  
 [IProvideExpressionContexts Interface](../../winscript/reference/iprovideexpressioncontexts-interface.md)