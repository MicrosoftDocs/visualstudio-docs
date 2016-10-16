---
title: "IDebugProgram2::EnumCodeContexts"
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
  - "IDebugProgram2::EnumCodeContexts"
helpviewer_keywords: 
  - "IDebugProgram2::EnumCodeContexts"
ms.assetid: 478e06a2-07bb-4841-8887-deab0f42ebd0
caps.latest.revision: 10
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
# IDebugProgram2::EnumCodeContexts
Retrieves a list of the code contexts for a given position in a source file.  
  
## Syntax  
  
```cpp#  
HRESULT EnumCodeContexts(   
   IDebugDocumentPosition2*  pDocPos,  
   IEnumDebugCodeContexts2** ppEnum  
);  
```  
  
```c#  
int EnumCodeContexts(   
   IDebugDocumentPosition2     pDocPos,  
   out IEnumDebugCodeContexts2 ppEnum  
);  
```  
  
#### Parameters  
 `pDocPos`  
 [in] An [IDebugDocumentPosition2](../extensibility/idebugdocumentposition2.md) object representing an abstract position in a source file known to the IDE.  
  
 `ppEnum`  
 [out] Returns an [IEnumDebugCodeContexts2](../extensibility/ienumdebugcodecontexts2.md) object that contains a list of the code contexts.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method allows the session debug manager (SDM) or IDE to map a source file position into a code position. More than one code context is returned if the source generates multiple blocks of code (for example, C++ templates).  
  
## See Also  
 [IDebugProgram2](../extensibility/idebugprogram2.md)   
 [IDebugDocumentPosition2](../extensibility/idebugdocumentposition2.md)   
 [IEnumDebugCodeContexts2](../extensibility/ienumdebugcodecontexts2.md)