---
title: "IDebugEngine2::SetLocale | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngine2::SetLocale"
helpviewer_keywords: 
  - "IDebugEngine2::SetLocale"
ms.assetid: cd0d2cf1-2aac-43da-a830-4bb3d696c219
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugEngine2::SetLocale
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Sets the locale of the debug engine (DE).  
  
## Syntax  
  
```cpp#  
HRESULT SetLocale(   
   WORD wLangID  
);  
```  
  
```csharp  
int SetLocale(   
   ushort wLangID  
);  
```  
  
#### Parameters  
 `wLangID`  
 [in] Specifies the language locale. For example, 1033 for English.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is called by the session debug manager (SDM) to propagate the locale settings of the IDE so that strings returned by the DE are properly localized.  
  
## See Also  
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
